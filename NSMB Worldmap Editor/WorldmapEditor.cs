using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace NSMB_Worldmap_Editor
{
    public partial class WorldmapEditor : Form
    {
        private int[] dataNodesWorldOffsets, visibleNodesWorldOffsets;
        int[] nodesPerWorld;

        public List<List<visibleNode>> visibleNodeList;
        public List<List<dataNode>> dataNodeList;

        public string overlayPath;

        public WorldmapEditor()
        {
            InitializeComponent();
            this.CenterToScreen();
            loadXmlFiles();

            nodeEditor.ec = editor;
            editor.ne = nodeEditor;
            pathEditor.ec = editor;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nodeEditor.Enabled) loadOverlay();
            else
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes.\nIf you open another file without saving, you will lose them.\nDo you want to save?", "NSMB Worldmap Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                if (dialogResult == DialogResult.Yes)
                {
                    save(false);
                    loadOverlay();
                }
                else if (dialogResult == DialogResult.No)
                {
                    loadOverlay();
                }
            }      
        }

        private void loadOverlay()
        {
            long overlayLength = 0;

            OpenFileDialog openOverlayDialog = new OpenFileDialog();
            openOverlayDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            openOverlayDialog.FileName = "overlay9_8.bin";
            openOverlayDialog.Filter = "Binary Files|*.bin|All Files|*.*";
            openOverlayDialog.Title = "Open overlay9_8";


            DialogResult openOverlayDialogResult = openOverlayDialog.ShowDialog();
            overlayPath = openOverlayDialog.FileName;

            try
            {
                overlayLength = new FileInfo(overlayPath).Length;
            }
            catch { }

            if (openOverlayDialogResult == DialogResult.OK && overlayLength == 139360)
            {
                try
                {
                    try
                    {
                        Directory.CreateDirectory("Backup");
                    }
                    catch { }

                    File.Copy(overlayPath, "Backup/overlay9_8.tmp", true);
                    editor.nodeSelected = false;
                    nodeEditor.disableEditor();
                    worldComboBox.SelectedIndex = 0;
                    readOverlay();
                }
                catch
                {
                    MessageBox.Show("Temping Overlay failed!", "Error");
                    Environment.Exit(0);
                }
            }
            else if (overlayLength == 0) { }
            else
            {
                MessageBox.Show("Your file has a wrong size!", "Error");
            }            
        }

        private void readOverlay()
        {
            visibleNodeList = new List<List<visibleNode>>();
            dataNodeList = new List<List<dataNode>>();

            //Read Visible Nodes
            BinaryReader brVN = new BinaryReader(File.Open("Backup/overlay9_8.tmp", FileMode.Open));
            for (int i = 0; i < 8; i++)
            {
                List<visibleNode> subVisibleNodeList = new List<visibleNode>();
                brVN.BaseStream.Position = visibleNodesWorldOffsets[i];
                for (int j = 0; j < nodesPerWorld[i]; j++)
                {
                    int x, y, z, p1, p2, p3, p4, sp1, sp2, sp3, sp4, c, sc;
                    p1 = brVN.ReadByte();
                    p2 = brVN.ReadByte();
                    p3 = brVN.ReadByte();
                    p4 = brVN.ReadByte();
                    sp1 = brVN.ReadByte();
                    sp2 = brVN.ReadByte();
                    sp3 = brVN.ReadByte();
                    sp4 = brVN.ReadByte();
                    c = brVN.ReadInt16();
                    sc = brVN.ReadInt16();
                    x = brVN.ReadInt32();
                    z = brVN.ReadInt32();
                    y = brVN.ReadInt32();
                    subVisibleNodeList.Add(new visibleNode(x, y, z, p1, p2, p3, p4, sp1, sp2, sp3, sp4, c, sc));
                }
                visibleNodeList.Add(subVisibleNodeList);
            }
            brVN.Close();

            //Read Data Nodes
            BinaryReader brDN = new BinaryReader(File.Open("Backup/overlay9_8.tmp", FileMode.Open));
            for (int i = 0; i < 8; i++)
            {
                List<dataNode> subDataNodeList = new List<dataNode>();
                brDN.BaseStream.Position = dataNodesWorldOffsets[i];
                for (int j = 0; j < nodesPerWorld[i]; j++)
                {
                    int area, settings, icon;
                    byte[] ptr;
                    ptr = brDN.ReadBytes(4);
                    area = brDN.ReadByte();
                    brDN.BaseStream.Position += 2;
                    icon = brDN.ReadByte();
                    settings = brDN.ReadByte();
                    brDN.BaseStream.Position += 3;
                    subDataNodeList.Add(new dataNode(area, icon, settings, ptr));
                }
                dataNodeList.Add(subDataNodeList);
            }
            brDN.Close();

            editor.visibleNodeList = visibleNodeList[0];
            editor.ScrollEditorMiddle();
            editor.redraw();

            nodeEditor.dataNodeList = dataNodeList[0];
            nodeEditor.Enabled = true;

            updateMenu(true);
        }

        private void loadXmlFiles()
        {
            XmlDocument dataNodesXml = new XmlDocument();
            XmlDocument visibleNodesXml = new XmlDocument();

            dataNodesWorldOffsets = new int[8];
            visibleNodesWorldOffsets = new int[8];
            nodesPerWorld = new int[8];

            //Visible Nodes XML
            if (File.Exists("Supporting Files/visibleNodes.xml") == false)
            {
                MessageBox.Show("The VisibleNodes.xml File is missing!", "Error");
                Environment.Exit(0);
            }
            else
            {
                visibleNodesXml.Load("Supporting Files/VisibleNodes.xml");
                XmlNodeList visibleNodesXmlList = visibleNodesXml.GetElementsByTagName("World");
                for (int i = 0; i < 8; i++)
                {
                    visibleNodesWorldOffsets[i] = int.Parse(visibleNodesXmlList[i].InnerText.Remove(0, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }

            //Data Nodes XML
            if (File.Exists("Supporting Files/DataNodes.xml") == false)
            {
                MessageBox.Show("The DataNodes.xml File is missing!", "Error");
                Environment.Exit(0);
            }
            else
            {
                dataNodesXml.Load("Supporting Files/DataNodes.xml");
                XmlNodeList dataNodesXmlList = dataNodesXml.GetElementsByTagName("World");
                for (int i = 0; i < 8; i++)
                {
                    dataNodesWorldOffsets[i] = int.Parse(dataNodesXmlList[i].InnerText.Remove(0, 2), System.Globalization.NumberStyles.HexNumber);
                    nodesPerWorld[i] = int.Parse(dataNodesXmlList[i].Attributes["nodes"].Value);
                }
            }
        }

        private void writeOverlay()
        {
            //Write visible Nodes
            BinaryWriter bwVN = new BinaryWriter(new FileStream("Backup/overlay9_8.tmp", FileMode.Open));
            for (int i = 0; i < 8; i++)
            {
                bwVN.BaseStream.Position = visibleNodesWorldOffsets[i];
                for (int j = 0; j < nodesPerWorld[i]; j++)
                {
                    bwVN.Write((byte)visibleNodeList[i][j].p1);
                    bwVN.Write((byte)visibleNodeList[i][j].p2);
                    bwVN.Write((byte)visibleNodeList[i][j].p3);
                    bwVN.Write((byte)visibleNodeList[i][j].p4);
                    bwVN.Write((byte)visibleNodeList[i][j].sp1);
                    bwVN.Write((byte)visibleNodeList[i][j].sp2);
                    bwVN.Write((byte)visibleNodeList[i][j].sp3);
                    bwVN.Write((byte)visibleNodeList[i][j].sp4);
                    bwVN.Write((Int16)visibleNodeList[i][j].c);
                    bwVN.Write((Int16)visibleNodeList[i][j].sc);
                    bwVN.Write(visibleNodeList[i][j].posX);
                    bwVN.Write(visibleNodeList[i][j].posZ);
                    bwVN.Write(visibleNodeList[i][j].posY);
                }
            }
            bwVN.Close();

            //Write data Nodes
            BinaryWriter bwDN = new BinaryWriter(new FileStream("Backup/overlay9_8.tmp", FileMode.Open));
            for (int i = 0; i < 8; i++)
            {
                bwDN.BaseStream.Position = dataNodesWorldOffsets[i];
                for (int j = 0; j < nodesPerWorld[i]; j++)
                {
                    bwDN.BaseStream.Position += 4;
                    bwDN.Write((byte)dataNodeList[i][j].area);
                    bwDN.BaseStream.Position += 2;
                    bwDN.Write((byte)dataNodeList[i][j].icon);
                    bwDN.Write((byte)dataNodeList[i][j].settings);
                    bwDN.BaseStream.Position += 3;
                }
            }
            bwDN.Close();
        }

        int oldWorldIndex;
        private void worldComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (visibleNodeList != null)
            {
                visibleNodeList[oldWorldIndex] = editor.visibleNodeList;
                dataNodeList[oldWorldIndex] = nodeEditor.dataNodeList;
                editor.visibleNodeList = visibleNodeList[worldComboBox.SelectedIndex];
                nodeEditor.dataNodeList = dataNodeList[worldComboBox.SelectedIndex];
                editor.nodeSelected = false;
                editor.redraw();
                editor.ScrollEditorMiddle();
                nodeEditor.nodeChanged(0, false);
                oldWorldIndex = worldComboBox.SelectedIndex;
            }            
        }

        private void updateMenu(bool load)
        {
            worldComboBox.Enabled = true;
            if (worldComboBox.SelectedIndex == -1) worldComboBox.SelectedIndex = 0;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nodeEditor.Enabled) Environment.Exit(0);
            else
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes.\nIf you close the editor without saving, you will lose them.\nDo you want to save?", "NSMB Worldmap Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                if (dialogResult == DialogResult.Yes)
                {
                    save(false);
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(false);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(true);
        }

        private void save(bool saveTo)
        {
            visibleNodeList[oldWorldIndex] = editor.visibleNodeList;
            dataNodeList[oldWorldIndex] = nodeEditor.dataNodeList;
            writeOverlay();

            if (!saveTo)
            {
                File.Copy("Backup/overlay9_8.tmp", overlayPath, true);
            }
            else
            {
                SaveFileDialog saveOverlayDialog = new SaveFileDialog();
                saveOverlayDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
                saveOverlayDialog.FileName = "overlay9_8.bin";
                saveOverlayDialog.Filter = "Binary Files|*.bin";
                saveOverlayDialog.Title = "Save overlay9_8";

                DialogResult saveOverlayDialogResult = saveOverlayDialog.ShowDialog();
                if (saveOverlayDialogResult == DialogResult.OK)
                {
                    overlayPath = saveOverlayDialog.FileName;
                    File.Copy("Backup/overlay9_8.tmp", overlayPath, true);
                }
            }
        }

    }
}