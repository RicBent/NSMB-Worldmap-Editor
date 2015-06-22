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
        private List<frame> frameList;
        private List<Byte> nsbcaFile;

        private int numberOfPaths;
        private int jacOffset;

        private int selectedPath, selectedFrame;

        private bool frameChangesAccepted = true;

        public PathEditor()
        {
            InitializeComponent();
        }

        private void openNsbcaButton_Click(object sender, EventArgs e)
        {
            loadNsbca();
            saveNsbcaButton.Enabled = true;
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
                    File.Copy(nsbcaPath, "Backup/animationData.temp", true);
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
            // = new List<Byte>(File.ReadAllBytes(nsbcaPath));
            pathAnimations = new List<pathAnimation>();
            BinaryReader br = new BinaryReader(File.Open("Backup/animationData.temp", FileMode.Open));

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

                if (fl == 14864) //103A X Y D
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    iZ = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pD = br.ReadInt32();
                }

                if (fl == 15128) //183B Y
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    iZ = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    iD = br.ReadInt32();
                }

                if (fl == 15152) //303B X
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    iZ = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    iY = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    iD = br.ReadInt32();
                }

                if (fl == 15192) //583B Y
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    iZ = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                }

                if (fl == 15112) //083B
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    iD = br.ReadInt32();
                }

                if (fl == 15136) //203B
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    iY = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    iD = br.ReadInt32();
                }

                if (fl == 15200) //603B
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    iY = calcPosition(br.ReadUInt16(), br.ReadInt16());
                }

                if (fl == 14848) //003A X Y Z D
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pD = br.ReadInt32();
                }

                if (fl == 15176) //483B
                {
                    br.BaseStream.Position += 2;
                    iX = calcPosition(br.ReadUInt16(), br.ReadInt16());
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
                }

                if (fl == 15168) //403B X Y Z
                {
                    br.BaseStream.Position += 6;
                    pX = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pZ = br.ReadInt32();
                    br.BaseStream.Position += 4;
                    pY = br.ReadInt32();
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
            ec.highlightedFrame = 0;
            generateFrameList(pathAnimations[0]);
            updateUI(pathAnimations[0].fl);
            numericUpDownSelectedPath.Value = 1;
        }

        private int calcPosition(UInt16 smallValue, Int16 bigValue)
        {
            float temp = (float)smallValue / UInt16.MaxValue * 16 + bigValue * 16; 
            return (int)temp;
        }

        private byte[] calcBackPosition(int value)
        {
            byte[] temp = new byte[4];
            Int16 bigValue;
            UInt16 smallValue;

            bigValue = Convert.ToInt16(value / 16);
            if (((value - bigValue * 16) * UInt16.MaxValue / 16) < 0) bigValue--;

            //MessageBox.Show(value + " " + bigValue.ToString() + " " + ((value - bigValue * 16) * UInt16.MaxValue / 16).ToString());
            smallValue = Convert.ToUInt16((value - bigValue * 16) * UInt16.MaxValue / 16);            

            Array.Copy(BitConverter.GetBytes(smallValue), temp, 2);
            Array.Copy(BitConverter.GetBytes(bigValue), 0, temp, 2, 2);

            return temp;
        }

        private void numericUpDownSelectedPath_ValueChanged(object sender, EventArgs e)
        {
            writeFrameList(pathAnimations[selectedPath]);
            selectedPath = (int)numericUpDownSelectedPath.Value - 1;
            numericUpDownFrames.Value = pathAnimations[selectedPath].fr;
            flagLabel.Text = "Flag: " + pathAnimations[selectedPath].fl;
            numericUpDownIX.Value = pathAnimations[selectedPath].iX;
            numericUpDownIY.Value = pathAnimations[selectedPath].iY;
            numericUpDownIZ.Value = pathAnimations[selectedPath].iZ;
            numericUpDownID.Value = pathAnimations[selectedPath].iD;
            numericUpDownSelectedFrame.Value = 1;
            numericUpDownSelectedFrame.Maximum = pathAnimations[selectedPath].fr;
            generateFrameList(pathAnimations[selectedPath]);
            updateUI(pathAnimations[selectedPath].fl);
        }

        private void numericUpDownSelectedFrame_ValueChanged(object sender, EventArgs e)
        {
            selectedFrame = (int)numericUpDownSelectedFrame.Value - 1;
            ec.highlightedFrame = selectedFrame;
            ec.redraw();
            updateUI(pathAnimations[selectedPath].fl);
        }

        private void updateUI(int flag)
        {
            frameChangesAccepted = false;

            numericUpDownPX.Value = 0;
            numericUpDownPY.Value = 0;
            numericUpDownPZ.Value = 0;
            numericUpDownPD.Value = 0;

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

                numericUpDownPX.Value = frameList[selectedFrame].x;
                numericUpDownPY.Value = frameList[selectedFrame].y;
                numericUpDownPD.Value = frameList[selectedFrame].d;

                modeComboBox.SelectedIndex = 2;
            }

            else if (flag == 15128) //183B Y
            {
                numericUpDownIX.Enabled = true;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = true;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                numericUpDownPY.Value = frameList[selectedFrame].y;

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

                numericUpDownPX.Value = frameList[selectedFrame].x;

                modeComboBox.SelectedIndex = 0;
            }

            else if (flag == 15112) //083B ZY
            {
                numericUpDownIX.Enabled = true;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = true;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = false;

                numericUpDownPZ.Value = frameList[selectedFrame].z;
                numericUpDownPY.Value = frameList[selectedFrame].y;

                modeComboBox.SelectedIndex = 4;
            }

            else if (flag == 15136) //203B XZ
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = true;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = true;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = false;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = false;

                numericUpDownPX.Value = frameList[selectedFrame].x;
                numericUpDownPZ.Value = frameList[selectedFrame].z;

                modeComboBox.SelectedIndex = 3;
            }

            else if (flag == 14848) //003A X Y Z D
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = true;

                numericUpDownPX.Value = frameList[selectedFrame].x;
                numericUpDownPY.Value = frameList[selectedFrame].y;
                numericUpDownPZ.Value = frameList[selectedFrame].z;
                numericUpDownPD.Value = frameList[selectedFrame].d;

                modeComboBox.SelectedIndex = 5;
            }

            else if (flag == 15192) //583B Y / no D
            {
                numericUpDownIX.Enabled = true;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = false;
                numericUpDownPD.Enabled = false;

                numericUpDownPY.Value = frameList[selectedFrame].y;

                modeComboBox.SelectedIndex = 6;
            }

            else if (flag == 15200) //603B X Z / no D
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = true;
                numericUpDownIZ.Enabled = true;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = false;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = false;

                numericUpDownPX.Value = frameList[selectedFrame].x;
                numericUpDownPZ.Value = frameList[selectedFrame].z;

                modeComboBox.SelectedIndex = 7;
            }

            else if (flag == 15176) //483B Z Y / no D
            {
                numericUpDownIX.Enabled = true;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = false;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = false;

                numericUpDownPZ.Value = frameList[selectedFrame].z;
                numericUpDownPY.Value = frameList[selectedFrame].y;

                modeComboBox.SelectedIndex = 8;
            }

            else if (flag == 15168) //403B X Z Y / no D
            {
                numericUpDownIX.Enabled = false;
                numericUpDownIY.Enabled = false;
                numericUpDownIZ.Enabled = false;
                numericUpDownID.Enabled = false;

                numericUpDownPX.Enabled = true;
                numericUpDownPY.Enabled = true;
                numericUpDownPZ.Enabled = true;
                numericUpDownPD.Enabled = false;

                numericUpDownPX.Value = frameList[selectedFrame].x;
                numericUpDownPY.Value = frameList[selectedFrame].y;
                numericUpDownPZ.Value = frameList[selectedFrame].z;

                modeComboBox.SelectedIndex = 9;
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

            frameChangesAccepted = true;
        }
        
        private void writeFrameList(pathAnimation pA)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("Backup/animationData.tmp", FileMode.Open));

            if (pA.fl == 15152) //303B X
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }
            }
            
            else if (pA.fl == 15128) //183B Y
            {
                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }
            }

            else if (pA.fl == 15192) //583B Y / no direction at all
            {
                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }
            }


            else if (pA.fl == 14864) //103A X Y D
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }

                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }

                bw.BaseStream.Position = pA.of + pA.pD;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].d));
                }
            }

            else if (pA.fl == 15112) //083B Y Z
            {
                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }
            }

            else if (pA.fl == 15136) //203B X Z
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }
            }

            else if (pA.fl == 15200) //603B X Z / no direction at all
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }
            }

            else if (pA.fl == 14848) //003B X Y Z D
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }

                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }

                bw.BaseStream.Position = pA.of + pA.pD;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].d));
                }
            }

            else if (pA.fl == 15176) //483B Y Z / no direction at all
            {
                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }
            }

            else if (pA.fl == 15168) //403B X Y Z / no direction at all
            {
                bw.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].x));
                }

                bw.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].y));
                }

                bw.BaseStream.Position = pA.of + pA.pZ;
                for (int i = 0; i < pA.fr; i++)
                {
                    bw.Write(calcBackPosition(frameList[i].z));
                }
            }

            bw.Close();
        }

        private void generateFrameList(pathAnimation pA)
        {
            frameList = new List<frame>();

            BinaryReader br = new BinaryReader(File.Open(nsbcaPath, FileMode.Open));

            if (pA.fl == 15152) //303B X
            {
                br.BaseStream.Position = pA.of + pA.pX;
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new frame(calcPosition(br.ReadUInt16(), br.ReadInt16()), pA.iY, pA.iZ, pA.iD));
                }    
            }

            else if (pA.fl == 15128) //183B Y
            {
                br.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new frame(pA.iX, calcPosition(br.ReadUInt16(), br.ReadInt16()), pA.iZ, pA.iD));
                }
            }

            else if (pA.fl == 15192) //583B Y / no direction at all
            {
                br.BaseStream.Position = pA.of + pA.pY;
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new frame(pA.iX, calcPosition(br.ReadUInt16(), br.ReadInt16()), pA.iZ, pA.iD));
                }
            }
            
            
            else if (pA.fl == 14864) //103A X Y D
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX = 0, tempY = 0, tempD;

                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pD + i * 2;
                    tempD = br.ReadUInt16();

                    frameList.Add(new frame(tempX, tempY, pA.iZ, tempD));
                }
            }

            else if (pA.fl == 15112) //083B Y Z
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempY, tempZ;

                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    frameList.Add(new frame(pA.iX, tempY, tempZ, pA.iD));
                }
            }

            else if (pA.fl == 15136) //203B X Z
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX, tempZ;

                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    frameList.Add(new frame(tempX, pA.iY, tempZ, pA.iD));
                }
            }

            else if (pA.fl == 15200) //603B X Z / no direction at all
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX, tempZ;

                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    frameList.Add(new frame(tempX, pA.iY, tempZ, pA.iD));
                }
            }

            else if (pA.fl == 14848) //003B X Y Z D
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX, tempY, tempZ, tempD;

                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pD + i * 2;
                    tempD = br.ReadUInt16();

                    frameList.Add(new frame(tempX, tempY, tempZ, tempD));
                }
            }

            else if (pA.fl == 15176) //483B Y Z / no direction at all
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempY, tempZ;

                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    frameList.Add(new frame(pA.iX, tempY, tempZ, pA.iD));
                }
            }

            else if (pA.fl == 15168) //403B X Y Z / no direction at all
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    int tempX, tempY, tempZ;

                    br.BaseStream.Position = pA.of + pA.pX + i * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pY + i * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pA.of + pA.pZ + i * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    frameList.Add(new frame(tempX, tempY, tempZ, pA.iD));
                }
            }

            else
            {
                for (int i = 0; i < pA.fr; i++)
                {
                    frameList.Add(new frame(0, 0, 0, 0));
                }
            }

            br.Close();

            ec.frameList = frameList;
            ec.redraw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeFrameList(pathAnimations[selectedPath]);
            File.Copy("Backup/animationData.tmp", nsbcaPath, true);
        }

        private void positionAtFrameChanged(object sender, EventArgs e)
        {
            if (frameChangesAccepted)
            {
                int x = (int)numericUpDownPX.Value;
                int y = (int)numericUpDownPY.Value;
                int z = (int)numericUpDownPZ.Value;
                int d = (int)numericUpDownPD.Value;

                frameList[selectedFrame] = new frame(x, y, z, d);

                ec.frameList = frameList;
                ec.redraw();
            }
        }

    }
}
