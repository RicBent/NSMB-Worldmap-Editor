using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NSMB_Worldmap_Editor.Controls
{
    public partial class PathEditor : UserControl
    {
        public EditorControl ec;

        private string nsbcaPath;

        private List<pathAnimation> pathAnimations;
        private List<Point> frameList;
        private int numberOfPaths;
        private int jacOffset;

        public PathEditor()
        {
            InitializeComponent();
        }

        private void openNsbcaButton_Click(object sender, EventArgs e)
        {
            loadNsbca();
        }

        private void loadNsbca()
        {
            OpenFileDialog openNsbcaDialog = new OpenFileDialog();
            openNsbcaDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            openNsbcaDialog.FileName = "wX_move.nsbca";
            openNsbcaDialog.Filter = "Nitro Model Animation|*.nsbca|All Files|*.*";
            openNsbcaDialog.Title = "Open Path Animations";


            DialogResult openOverlayDialogResult = openNsbcaDialog.ShowDialog();
            nsbcaPath = openNsbcaDialog.FileName;

            if (openOverlayDialogResult == DialogResult.OK)
            {
                try
                {
                    //readNsbca();
                }
                catch
                {
                    MessageBox.Show("Error reading Animation data!", "Error");
                }
                readNsbca();
            }
        }

        private void readNsbca()
        {
            List<Byte> nsbcaFile = new List<Byte>(File.ReadAllBytes(nsbcaPath));
            pathAnimations = new List<pathAnimation>();
            BinaryReader br = new BinaryReader(File.Open(nsbcaPath, FileMode.Open));

            br.BaseStream.Position = 29;
            numberOfPaths = br.ReadByte();
            numberOfPathsLabel.Text = "Number of Paths: " + numberOfPaths.ToString();

            jacOffset = 44 + 4 * numberOfPaths + 4 * numberOfPaths + 16 * numberOfPaths;

            br.BaseStream.Position = jacOffset;

            for (int i = 0; i < numberOfPaths; i++)
            {
                int fr, fl, of;
                int iX = 0, iY = 0, iZ = 0, iD = 0;
                int pX = 0, pY = 0, pZ = 0, pD = 0;

                of = (int)br.BaseStream.Position;

                br.BaseStream.Position += 4;
                fr = br.ReadInt16();

                br.BaseStream.Position += 18;
                fl = br.ReadInt16();

                if (fl == 14864) //103A
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    iZ = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pD = br.ReadInt32();
                }

                if (fl == 15128) //183B
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    iZ = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    iD = br.ReadInt32();
                }

                if (fl == 15152) //303B
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    iZ = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    iY = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    iD = br.ReadInt32();
                }

                if (fl == 15192) //583B
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    iZ = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                }

                if (fl == 15112) //083B
                {
                    br.BaseStream.Position += 26;
                }

                pathAnimations.Add(new pathAnimation(of, fr, fl, iX, iY, iZ, iD, pX, pY, pZ, pD));
            }

            br.Close();

            numericUpDownFrames.Value = pathAnimations[0].fr;
            flagLabel.Text = "Flag: " + pathAnimations[0].fl;
            numericUpDownIX.Value = pathAnimations[0].iX;
            numericUpDownIY.Value = pathAnimations[0].iY;
            numericUpDownIZ.Value = pathAnimations[0].iZ;
            numericUpDownID.Value = pathAnimations[0].iD;
            numericUpDownPZ.Value = pathAnimations[0].pZ;
            numericUpDownPD.Value = pathAnimations[0].pD;
            numericUpDownSelectedPath.Maximum = numberOfPaths;
            numericUpDownSelectedFrame.Maximum = pathAnimations[0].fr;
            updateUI(pathAnimations[0].fl);
            generateFrameList(pathAnimations[0]);
            numericUpDownPX.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].X;
            numericUpDownPY.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].Y;
        }

       /* private int calcPosition(int smallValue, int bigValue)
        {
            float temp = (float)Math.Abs(smallValue) / 65535 * 16 + bigValue * 16;
            return (int)temp;
        }*/

        private int calcPosition(byte[] smallValue, byte[] bigValue)
        {
            int sv = BitConverter.ToUInt16(smallValue, 0);
            int bv = BitConverter.ToInt16(bigValue, 0);
            //MessageBox.Show(BitConverter.ToString(smallValue) + "\n " + BitConverter.ToUInt16(smallValue, 0));
            float temp = (float)sv / UInt16.MaxValue * 16 + bv * 16; 
            return (int)temp;
        }

        private void numericUpDownSelectedPath_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownFrames.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].fr;
            flagLabel.Text = "Flag: " + pathAnimations[(int)numericUpDownSelectedPath.Value - 1].fl;
            numericUpDownIX.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].iX;
            numericUpDownIY.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].iY;
            numericUpDownIZ.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].iZ;
            numericUpDownID.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].iD;
            numericUpDownPZ.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].pZ;
            numericUpDownPD.Value = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].pD;
            numericUpDownSelectedFrame.Value = 1;
            numericUpDownSelectedFrame.Maximum = pathAnimations[(int)numericUpDownSelectedPath.Value - 1].fr;
            updateUI(pathAnimations[(int)numericUpDownSelectedPath.Value - 1].fl);
            generateFrameList(pathAnimations[(int)numericUpDownSelectedPath.Value - 1]);
            numericUpDownPX.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].X;
            numericUpDownPY.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].Y;
        }

        private void numericUpDownSelectedFrame_ValueChanged(object sender, EventArgs e)
        {
            ec.highlightedFrame = (int)numericUpDownSelectedFrame.Value - 1;
            ec.redraw();
            numericUpDownPX.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].X;
            numericUpDownPY.Value = frameList[(int)numericUpDownSelectedFrame.Value - 1].Y;
        }

        private void updateUI(int flag)
        {
            if (flag == 14864) //103A XY
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = true;

                modeComboBox.SelectedIndex = 2;
            }

            else if (flag == 15128) //183B / 583B Y
            {
                numericUpDownIX.Enabled = true;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = true;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                modeComboBox.SelectedIndex = 1;
            }

            else if (flag == 15152) //303B X
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = true;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = true;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = false;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                modeComboBox.SelectedIndex = 0;
            }

            else if (flag == 15112) //083B X
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = false;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                modeComboBox.SelectedIndex = 6;
            }

            else
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = false;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                modeComboBox.SelectedIndex = -1;
            }
        }

        private void generateFrameList(pathAnimation pA)
        {
            frameList = new List<Point>();

            BinaryReader br = new BinaryReader(File.Open(nsbcaPath, FileMode.Open));

            if (pA.fl == 15152) //303B
            {
                br.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new Point(calcPosition(br.ReadBytes(2), br.ReadBytes(2)), pA.iY));
                }    
            }

            else if (pA.fl == 15128) //183B
            {
                br.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new Point(pA.iX, calcPosition(br.ReadBytes(2), br.ReadBytes(2))));
                }
            }
            
            
            else if (pA.fl == 14864) //103A
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX = 0, tempY = 0;
                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadBytes(2), br.ReadBytes(2));
                    frameList.Add(new Point(tempX, tempY));
                }
            }

            br.Close();

            ec.frameList = frameList;
            ec.redraw();
        }
    }
}
