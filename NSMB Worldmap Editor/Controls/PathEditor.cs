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
        private List<List<frame>> frameList;

        private int numberOfPaths;
        private int jacOffset;

        private int selectedPath, selectedFrame;

        private bool frameChangesAccepted = true;
        private bool frameCountChangesAccepted = true;

        public PathEditor()
        {
            InitializeComponent();
        }

        #region Button Events/UI Stuff
        private void openNsbcaButton_Click(object sender, EventArgs e)
        {
            loadNsbca();
        }

        private void saveNsbcaButton_Click(object sender, EventArgs e)
        {
            writeFrameList();
            File.Copy("Backup/animationData.tmp", nsbcaPath, true);
        }

        private void numericUpDownSelectedPath_ValueChanged(object sender, EventArgs e)
        {
            if (frameList != null) writeFrameList();
            selectedPath = (int)numericUpDownSelectedPath.Value - 1;
            selectPath(selectedPath);
        }

        private void numericUpDownSelectedFrame_ValueChanged(object sender, EventArgs e)
        {
            selectedFrame = (int)numericUpDownSelectedFrame.Value - 1;
            selectFrame(selectedFrame);
        }

        private void numericUpDownFrames_ValueChanged(object sender, EventArgs e)
        {
            if (frameCountChangesAccepted) insertRemoveFrames((int)numericUpDownFrames.Value - pathAnimations[selectedPath].fr);
        }

        private void createNsbcaButton_Click(object sender, EventArgs e)
        {
            int[] pathsPerWorld = { 23, 24, 21, 23, 30, 26, 24, 19 };
            NewAnimationFileDialog nsfd = new NewAnimationFileDialog();
            int worldIndex;
            if (nsfd.ShowDialog() == DialogResult.OK)
            {
                worldIndex = nsfd.worldIndex();
                nsfd.Close();
                createNsbca(pathsPerWorld[worldIndex]);
            }
        }


        #endregion


        #region Nsbca Stuff (Loading/Reading/etc)
        private void loadNsbca()
        {
            OpenFileDialog openNsbcaDialog = new OpenFileDialog();
            openNsbcaDialog.FileName = "wX_move.nsbca";
            openNsbcaDialog.Filter = "Nitro Model Animation|*.nsbca|All Files|*.*";
            openNsbcaDialog.Title = "Open Path Animations";


            DialogResult openOverlayDialogResult = openNsbcaDialog.ShowDialog();
            nsbcaPath = openNsbcaDialog.FileName;

            if (openOverlayDialogResult == DialogResult.OK)
            {
                try
                {
                    File.Copy(nsbcaPath, "Backup/animationData.tmp", true);
                    BinaryReader br = new BinaryReader(File.Open("Backup/animationData.tmp", FileMode.Open));

                    br.BaseStream.Position = 4;
                    int createdByEditorFlag = br.ReadInt32();
                    br.Close();

                    if (createdByEditorFlag == 1)
                    {
                        readNsbca();
                        selectPath(0);
                        saveNsbcaButton.Enabled = true;
                    }
                    else MessageBox.Show("This Animation File was not created with this editor!", "NSMB Worldmap Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error reading Animation data!", "Error");
                }
                
            }
        }

        private void readNsbca()
        {
            pathAnimations = new List<pathAnimation>();
            BinaryReader br = new BinaryReader(File.Open("Backup/animationData.tmp", FileMode.Open));

            br.BaseStream.Position = 29;
            numberOfPaths = br.ReadByte();

            jacOffset = 44 + 4 * numberOfPaths + 4 * numberOfPaths + 16 * numberOfPaths;

            br.BaseStream.Position = jacOffset;

            for (int i = 0; i < numberOfPaths; i++)
            {
                int fr, of;
                int pX = 0, pY = 0, pZ = 0, pD = 0;

                of = (int)br.BaseStream.Position;

                br.BaseStream.Position += 4;
                fr = br.ReadInt16();

                br.BaseStream.Position += 26;
 
                pX = br.ReadInt32();
                br.BaseStream.Position += 4;
                pZ = br.ReadInt32();
                br.BaseStream.Position += 4;
                pY = br.ReadInt32();
                br.BaseStream.Position += 4;
                pD = br.ReadInt32();

                contentPanel.Enabled = true;

                pathAnimations.Add(new pathAnimation(of, fr, pX, pY, pZ, pD));
            }

            br.Close();

            numericUpDownSelectedPath.Maximum = numberOfPaths;
            generateFrameList();
        }
        #endregion


        #region Calculate Positions
        private int calcPosition(UInt16 smallValue, Int16 bigValue)
        {
            float temp = (float)smallValue / UInt16.MaxValue * 16 + bigValue * 16;
            return (int)temp;
        }

        private byte[] calcBackPosition(int value)
        {
            if (value > 0) value++;

            byte[] temp = new byte[4];
            Int16 bigValue;
            UInt16 smallValue;

            bigValue = Convert.ToInt16(value / 16);
            if (((value - bigValue * 16) * UInt16.MaxValue / 16) < 0) bigValue--;

            smallValue = Convert.ToUInt16((value - bigValue * 16) * UInt16.MaxValue / 16);

            Array.Copy(BitConverter.GetBytes(smallValue), temp, 2);
            Array.Copy(BitConverter.GetBytes(bigValue), 0, temp, 2, 2);

            return temp;
        }
        #endregion


        #region Frame Reading/Writing
        private void writeFrameList()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("Backup/animationData.tmp", FileMode.Open));

            for (int i = 0; i < numberOfPaths; i++)
            {
                bw.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pX;
                for (int j = 0; j < pathAnimations[i].fr; j++)
                {
                    bw.Write(calcBackPosition(frameList[i][j].x));
                }

                bw.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pZ;
                for (int j = 0; j < pathAnimations[i].fr; j++)
                {
                    bw.Write(calcBackPosition(frameList[i][j].z));
                }

                bw.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pY;
                for (int j = 0; j < pathAnimations[i].fr; j++)
                {
                    bw.Write(calcBackPosition(frameList[i][j].y));
                }

                bw.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pD;
                for (int j = 0; j < pathAnimations[i].fr; j++)
                {
                    bw.Write((ushort)frameList[i][j].d);
                }
            }
            bw.Close();
        }

        private void generateFrameList()
        {
            frameList = new List<List<frame>>();

            BinaryReader br = new BinaryReader(File.Open("Backup/animationData.tmp", FileMode.Open));

            for (int i = 0; i < numberOfPaths; i++)
            {
                List<frame> subFrameList = new List<frame>();
                for (int j = 0; j < pathAnimations[i].fr; j++)
                {
                    int tempX, tempY, tempZ, tempD;

                    br.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pX + j * 4;
                    tempX = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pY + j * 4;
                    tempY = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pZ + j * 4;
                    tempZ = calcPosition(br.ReadUInt16(), br.ReadInt16());

                    br.BaseStream.Position = pathAnimations[i].of + pathAnimations[i].pD + j * 2;
                    tempD = br.ReadUInt16();

                    subFrameList.Add(new frame(tempX, tempY, tempZ, tempD));
                }
                frameList.Add(subFrameList);
            }

            br.Close();

            ec.frameList = frameList[selectedPath];
            ec.redraw();
        }

        private void positionAtFrameChanged(object sender, EventArgs e)
        {
            if (frameChangesAccepted)
            {
                int x = (int)numericUpDownPX.Value;
                int y = (int)numericUpDownPY.Value;
                int z = (int)numericUpDownPZ.Value;
                int d = (int)comboBoxPD.SelectedIndex + 32768;

                frameList[selectedPath][selectedFrame] = new frame(x, y, z, d);

                ec.frameList = frameList[selectedPath];
                ec.redraw();
            }
        }

        #endregion


        #region Frame Adding/Removing
        private void insertRemoveFrames(int changedFrames)
        {
            List<byte> tempXYZ = new List<byte>(), tempD = new List<byte>(), tempBuffer = new List<byte>();

            if (changedFrames > 0)
            {
                for (int i = 0; i < changedFrames; i++)
                {
                    for (int j = 0; j < 4; j++) tempXYZ.Add(0);
                    tempD.Add(0x80); tempD.Add(0);
                    for (int j = 0; j < 2; j++) tempBuffer.Add(0xFF);
                }

                insertBytes(pathAnimations[selectedPath].pX + pathAnimations[selectedPath].fr * 4 + pathAnimations[selectedPath].of, tempXYZ.ToArray());
                insertBytes(pathAnimations[selectedPath].pZ + pathAnimations[selectedPath].fr * 4 + pathAnimations[selectedPath].of + changedFrames * 4, tempXYZ.ToArray());
                insertBytes(pathAnimations[selectedPath].pY + pathAnimations[selectedPath].fr * 4 + pathAnimations[selectedPath].of + changedFrames * 4 * 2, tempXYZ.ToArray());
                insertBytes(pathAnimations[selectedPath].pD + pathAnimations[selectedPath].fr * 2 + pathAnimations[selectedPath].of + changedFrames * 4 * 3, tempD.ToArray());
                insertBytes(pathAnimations[selectedPath].pD + pathAnimations[selectedPath].fr * 2 * 2 + pathAnimations[selectedPath].of + changedFrames * 4 * 3 + changedFrames * 2, tempBuffer.ToArray());           
            }
            else
            {
                removeBytes(pathAnimations[selectedPath].pD + pathAnimations[selectedPath].of + pathAnimations[selectedPath].fr * 4 + changedFrames * 2, Math.Abs(changedFrames) * 2);
                removeBytes(pathAnimations[selectedPath].pD + pathAnimations[selectedPath].of + pathAnimations[selectedPath].fr * 2 + changedFrames * 2, Math.Abs(changedFrames) * 2);
                removeBytes(pathAnimations[selectedPath].pY + pathAnimations[selectedPath].of + pathAnimations[selectedPath].fr * 4 + changedFrames * 4, Math.Abs(changedFrames) * 4);
                removeBytes(pathAnimations[selectedPath].pZ + pathAnimations[selectedPath].of + pathAnimations[selectedPath].fr * 4 + changedFrames * 4, Math.Abs(changedFrames) * 4);
                removeBytes(pathAnimations[selectedPath].pX + pathAnimations[selectedPath].of + pathAnimations[selectedPath].fr * 4 + changedFrames * 4, Math.Abs(changedFrames) * 4);
            }

            pathAnimations[selectedPath].fr += changedFrames;
            updatePointers(changedFrames);
            writePointers(); //And frame count
            generateFrameList();
            writeFrameList();

            numericUpDownSelectedFrame.Maximum = pathAnimations[selectedPath].fr;          
        }

        private void updatePointers(int changedFrames)
        {
            pathAnimations[selectedPath].pZ += changedFrames * 4;
            pathAnimations[selectedPath].pY += changedFrames * 4 * 2;
            pathAnimations[selectedPath].pD += changedFrames * 4 * 3;

            foreach (pathAnimation pA in pathAnimations)
            {
                if (pathAnimations.IndexOf(pA) > selectedPath)
                {
                    pA.pX += changedFrames * 4 * 4;
                    pA.pZ += changedFrames * 4 * 4;
                    pA.pY += changedFrames * 4 * 4;
                    pA.pD += changedFrames * 4 * 4;
                }
            }
        }

        private void writePointers()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("Backup/animationData.tmp", FileMode.Open));

            foreach (pathAnimation pA in pathAnimations)
            {
                bw.BaseStream.Position = pA.of;

                bw.BaseStream.Position += 4;

                bw.Write((ushort)pA.fr);

                bw.BaseStream.Position += 26;

                bw.Write((int)pA.pX);
                bw.BaseStream.Position += 4;
                bw.Write((int)pA.pZ);
                bw.BaseStream.Position += 4;
                bw.Write((int)pA.pY);
                bw.BaseStream.Position += 4;
                bw.Write((int)pA.pD);
            }

            bw.Close();
        }
        #endregion


        #region Create Nsbca
        private void createNsbca(int pathCount)
        {
            string createdNsbcaPath;

            SaveFileDialog saveNsbcaDialog = new SaveFileDialog();
            saveNsbcaDialog.FileName = "wX_move.nsbca";
            saveNsbcaDialog.Filter = "Nitro Model Animation|*.nsbca|All Files|*.*";
            saveNsbcaDialog.Title = "Save Path Animations";

            DialogResult saveOverlayDialogResult = saveNsbcaDialog.ShowDialog();
            if (saveOverlayDialogResult == DialogResult.OK)
            {
                createdNsbcaPath = saveNsbcaDialog.FileName;

                BinaryWriter bw = new BinaryWriter(new FileStream(createdNsbcaPath, FileMode.Create));

                //NSBCA write header
                bw.Write((int)0x30414342); //BCA0 Magic Stamp
                bw.Write((int)1); //Flag for "Created by Editor"
                bw.Write((int)0); //Filesize (This doesn't matter -> Just 0)
                bw.Write((short)16); //Header Size
                bw.Write((short)1); //Number of JAC Sections (allways 1)
                bw.Write((int)0x14); //Offset to JAC Section
                //20

                //JNTO Header
                bw.Write((int)0x30544E4A); //JNT0 Magic Stamp
                bw.Write((int)0); //Sections Size (has to be updated at the end)

                //Object header
                bw.Write((byte)0); //Dummy
                bw.Write((byte)pathCount); //Number of Objects (Paths)
                int objectHeaderSize = 4 + 8 + pathCount * 4 + 4 + pathCount * 4 + pathCount * 16;
                bw.Write((ushort)objectHeaderSize);
                //Unknown Block
                bw.Write((short)8); //Data Size
                bw.Write((short)(pathCount * 4 + 12)); //Block Size
                bw.Write((int)0x0000017F); //Constant
                for (int i = 0; i < pathCount; i++) bw.Write((int)0); //Unknown Data (This doesn't matter -> Just 0)
                //Offset Block
                bw.Write((short)4); //Data Size
                bw.Write((short)(pathCount * 4 + 4)); //Block Size
                for (int i = 0; i < pathCount; i++) bw.Write((int)24 + pathCount * 4 * 2 + pathCount * 16 + i * 60); //Offsets to JAC Sections
                //Name Block
                for (int i = 0; i < pathCount; i++) //Names
                {
                    byte[] temp = new byte[16];
                    temp = Encoding.ASCII.GetBytes("move" + i.ToString("D2") + "\0\0\0\0\0\0\0\0\0\0");
                    bw.Write(temp);
                }

                int chunk1Offset = 44 + pathCount * 4 * 2 + pathCount * 16 + pathCount * 60;
                int chunk2Offset = chunk1Offset + 24;

                //JAC Blocks
                for (int i = 0; i < pathCount; i++)
                {
                    int jacOffset = (int)bw.BaseStream.Position;
                    bw.Write((int)0x4341004A); //J.AC Magic Stamp
                    bw.Write((ushort)25); //Frames (Initial set to 25)
                    bw.Write((short)1); //Number of Objects (Allways 1)
                    bw.Write((int)1); //Unknown (Allways 1)
                    int offsetToChunk1 = chunk1Offset - jacOffset;
                    bw.Write((int)offsetToChunk1); //Offset to Chunk 1
                    int offsetToChunk2 = chunk2Offset - jacOffset;
                    bw.Write((int)offsetToChunk2); //Offset to Chunk 2
                    bw.Write((int)24); //Unknown (Allways 24)
                    bw.Write((ushort)0x3A00); //Flag (Set to 003A -> X Z Y D Changes)
                    bw.Write((short)0); //Unknown (Allways 0)
                    //X Changes
                    bw.Write((short)0); //Unknown (Allways 0)
                    bw.Write((ushort)25); //Frames for X Changes (Initial set to 25)
                    int offsetToXChanges = offsetToChunk2 + i * (25 * 4 * 4);
                    bw.Write((int)offsetToXChanges); //Offset to X Changes
                    //Z Changes
                    bw.Write((short)0); //Unknown (Allways 0)
                    bw.Write((ushort)25); //Frames for Z Changes (Initial set to 25)
                    int offsetToZChanges = offsetToChunk2 + i * (25 * 4 * 4) + 25 * 4;
                    bw.Write((int)offsetToZChanges); //Offset to Z Changes
                    //Y Changes
                    bw.Write((short)0); //Unknown (Allways 0)
                    bw.Write((ushort)25); //Frames for Y Changes (Initial set to 25)
                    int offsetToYChanges = offsetToChunk2 + i * (25 * 4 * 4) + 25 * 4 * 2;
                    bw.Write((int)offsetToYChanges); //Offset to Y Changes
                    //D Changes
                    bw.Write((short)0); //Unknown (Allways 0)
                    bw.Write((ushort)25); //Frames for D Changes (Initial set to 25)
                    int offsetToDChanges = offsetToChunk2 + i * (25 * 4 * 4) + 25 * 4 * 3;
                    bw.Write((int)offsetToDChanges); //Offset to D Changes
                }

                //Chunk 1
                byte[] chunk1 = { 0x12, 0x00, 0x00, 0x00, 0x00, 0x10, 0x50, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10,
                                  0x00, 0x00, 0x22, 0x00, 0x00, 0x00, 0x00, 0x10 };
                bw.Write(chunk1);

                //Chunk 2
                for (int i = 0; i < pathCount; i++)
                {
                    //Create X Frames
                    for (int j = 0; j < 25; j++)
                    {
                        bw.Write((int)0);
                    }
                    //Create Z Frames
                    for (int j = 0; j < 25; j++)
                    {
                        bw.Write((int)0);
                    }
                    //Create Y Frames
                    for (int j = 0; j < 25; j++)
                    {
                        bw.Write((int)0);
                    }
                    //Create D Frames
                    for (int j = 0; j < 25; j++)
                    {
                        bw.Write((ushort)32768); //Set Initial Direction to right
                    }
                    //Insert Buffer (hopefully that'll fix that friggn bug :P)
                    for (int j = 0; j < 25; j++)
                    {
                        bw.Write((ushort)0xFFFF);
                    }
                }
                
                bw.Close();
            }
        }
        #endregion


        private void selectPath(int pathNumber)
        {
            if (numberOfPaths != 0)
            {
                frameCountChangesAccepted = false;
                numericUpDownFrames.Value = pathAnimations[pathNumber].fr;
                frameCountChangesAccepted = true;

                numericUpDownSelectedFrame.Maximum = pathAnimations[pathNumber].fr;
                numericUpDownSelectedPath.Value = pathNumber + 1;
                numericUpDownSelectedFrame.Value = 1;
                ec.frameList = frameList[selectedPath];
                ec.highlightedFrame = 1;
                ec.redraw();

                selectFrame(0);
            }
        }

        private void selectFrame(int frameNumber)
        {
            selectedFrame = frameNumber;
            ec.highlightedFrame = selectedFrame;

            frameChangesAccepted = false;
            numericUpDownPX.Value = frameList[selectedPath][selectedFrame].x;
            numericUpDownPY.Value = frameList[selectedPath][selectedFrame].y;
            numericUpDownPZ.Value = frameList[selectedPath][selectedFrame].z;
            comboBoxPD.SelectedIndex = frameList[selectedPath][selectedFrame].d - 32768;
            frameChangesAccepted = true;

            ec.redraw();
        }

        public void insertBytes(int offset, byte[] bytes)
        {
            List<byte> tempNsbcaFile = File.ReadAllBytes("Backup/animationData.tmp").ToList();

            for (int i = 0; i < bytes.Length; i++) tempNsbcaFile.Insert(offset, bytes[i]);

            System.IO.FileStream ws = new System.IO.FileStream("Backup/animationData.tmp", System.IO.FileMode.Create);
            ws.Write(tempNsbcaFile.ToArray(), 0, tempNsbcaFile.Count);
            ws.Close();
        }

        public void removeBytes(int offset, int count)
        {
            List<byte> tempNsbcaFile = File.ReadAllBytes("Backup/animationData.tmp").ToList();

            for (int i = 0; i < count; i++) tempNsbcaFile.RemoveAt(offset);

            System.IO.FileStream ws = new System.IO.FileStream("Backup/animationData.tmp", System.IO.FileMode.Create);
            ws.Write(tempNsbcaFile.ToArray(), 0, tempNsbcaFile.Count);
            ws.Close();
        }

        private void insertStraightWalksButton_Click(object sender, EventArgs e)
        {
            List<frame> tempList = null;
            InsertStraightWalkDialog iswd = new InsertStraightWalkDialog();
            if (iswd.ShowDialog() == DialogResult.OK)
            {
                tempList = iswd.frameList;
                iswd.Close();
            }

            if (tempList != null)
            {
                List<frame> tempList2 = new List<frame>();
                for (int i = 0; i < (int)numericUpDownSelectedFrame.Value - 1; i++)
                {
                    tempList2.Add(frameList[selectedPath][i]);
                }

                for (int i = 0; i < tempList.Count; i++)
                {
                    tempList2.Add(tempList[i]);
                }

                insertRemoveFrames(tempList2.Count() - pathAnimations[selectedPath].fr);
                frameList[selectedPath] = tempList2;

                frameCountChangesAccepted = false;
                numericUpDownFrames.Value = pathAnimations[selectedPath].fr;
                frameCountChangesAccepted = true;
                numericUpDownSelectedFrame.Maximum = pathAnimations[selectedPath].fr;
                selectFrame(selectedFrame);

                ec.frameList = frameList[selectedPath];
                ec.redraw();
            }
        }

        private void replacePathButton_Click(object sender, EventArgs e)
        {
            ReplacePathDialog rpd = new ReplacePathDialog();

            if (rpd.ShowDialog() == DialogResult.OK)
            {
                rpd.Close();
            }
        }
    }
}
