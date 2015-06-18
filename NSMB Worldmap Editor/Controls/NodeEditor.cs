using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMB_Worldmap_Editor.Controls
{
    public partial class NodeEditor : UserControl
    {
        public EditorControl ec;

        private int selectedNode;
        private bool nodeSelected;
        private int x, y, z;
        private int p1, p2, p3, p4, sp1, sp2, sp3, sp4, c, sc;
        private int area, icon, settings;
        private byte[] ptr;

        public List<dataNode> dataNodeList;

        private bool ignoreNumericUpDownChange;

        public NodeEditor()
        {
            InitializeComponent();
        }
        
        public void nodeChanged(int selectedNode, bool nodeSelected)
        {
            ignoreNumericUpDownChange = true;
            
            numericUpDownX.Maximum = ec.areaWidth / 2;
            numericUpDownX.Minimum = -ec.areaWidth / 2;
            numericUpDownY.Maximum = ec.areaHeight / 2;
            numericUpDownY.Minimum = -ec.areaHeight / 2;            

            this.selectedNode = selectedNode;
            this.nodeSelected = nodeSelected;

            x = ec.visibleNodeList[selectedNode].posX;
            y = ec.visibleNodeList[selectedNode].posY;
            z = ec.visibleNodeList[selectedNode].posZ;

            p1 = ec.visibleNodeList[selectedNode].p1;
            p2 = ec.visibleNodeList[selectedNode].p2;
            p3 = ec.visibleNodeList[selectedNode].p3;
            p4 = ec.visibleNodeList[selectedNode].p4;
            
            sp1 = ec.visibleNodeList[selectedNode].sp1;
            sp2 = ec.visibleNodeList[selectedNode].sp2;
            sp3 = ec.visibleNodeList[selectedNode].sp3;
            sp4 = ec.visibleNodeList[selectedNode].sp4;

            c = ec.visibleNodeList[selectedNode].c;
            sc = ec.visibleNodeList[selectedNode].sc;

            area = dataNodeList[selectedNode].area;
            icon = dataNodeList[selectedNode].icon;
            settings = dataNodeList[selectedNode].settings;
            ptr = dataNodeList[selectedNode].ptr;

            if (nodeSelected)
            {
                selectedNodeLabel.Text = "Node: " + selectedNode;
                coordinatesBox.Enabled = true;
                settingsBox.Enabled = true;
                normalExitBox.Enabled = true;
                secretExitBox.Enabled = true;
                pointerPanel.Enabled = true;
            }

            else
            {
                disableEditor();
            }

            numericUpDownX.Value = x;
            numericUpDownY.Value = y;
            numericUpDownZ.Value = z;

            numericUpDownP1.Value = p1;
            numericUpDownP2.Value = p2;
            numericUpDownP3.Value = p3;
            numericUpDownP4.Value = p4;

            numericUpDownSp1.Value = sp1;
            numericUpDownSp2.Value = sp2;
            numericUpDownSp3.Value = sp3;
            numericUpDownSp4.Value = sp4;

            numericUpDownC.Value = c;
            numericUpDownSc.Value = sc;

            numericUpDownArea.Value = area;
            numericUpDownLevelIcon.Value = icon;
            numericUpDownSettings.Value = settings;
            pointerBox.Text = BitConverter.ToString(ptr).Replace("-", " ");

            updateLevelIcon();
            updateSettingsComboBox();

            ignoreNumericUpDownChange = false;
        }

        private void updateNode()
        {
            ec.visibleNodeList[selectedNode] = new visibleNode(x, y, z, p1, p2, p3, p4, sp1, sp2, sp3, sp4, c, sc);
            ec.redraw();
        }

        private void numericUpDownsVisible_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoreNumericUpDownChange)
            {
                x = (int)numericUpDownX.Value;
                y = (int)numericUpDownY.Value;
                z = (int)numericUpDownZ.Value;
                p1 = (int)numericUpDownP1.Value;
                p2 = (int)numericUpDownP2.Value;
                p3 = (int)numericUpDownP3.Value;
                p4 = (int)numericUpDownP4.Value;
                sp1 = (int)numericUpDownSp1.Value;
                sp2 = (int)numericUpDownSp2.Value;
                sp3 = (int)numericUpDownSp3.Value;
                sp4 = (int)numericUpDownSp4.Value;
                c = (int)numericUpDownC.Value;
                sc = (int)numericUpDownSc.Value;
                if (nodeSelected) updateNode();
            }
        }

        private void numericUpDownsData_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoreNumericUpDownChange)
            {
                area = (int)numericUpDownArea.Value;
                icon = (int)numericUpDownLevelIcon.Value;
                settings = (int)numericUpDownSettings.Value;
                updateLevelIcon();
                updateSettingsComboBox();
                dataNodeList[selectedNode] = new dataNode(area, icon, settings, ptr);
            }
        }

        private void updateLevelIcon()
        {
            if (nodeSelected)
            {
                switch (icon)
                {
                    case 0: levelIconBox.Image = Properties.Resources._0; break;
                    case 1: levelIconBox.Image = Properties.Resources._1; break;
                    case 2: levelIconBox.Image = Properties.Resources._2; break;
                    case 3: levelIconBox.Image = Properties.Resources._3; break;
                    case 4: levelIconBox.Image = Properties.Resources._4; break;
                    case 5: levelIconBox.Image = Properties.Resources._5; break;
                    case 6: levelIconBox.Image = Properties.Resources._6; break;
                    case 7: levelIconBox.Image = Properties.Resources._7; break;
                    case 8: levelIconBox.Image = Properties.Resources._8; break;
                    case 9: levelIconBox.Image = Properties.Resources._9; break;
                    case 10: levelIconBox.Image = Properties.Resources._10; break;
                    case 11: levelIconBox.Image = Properties.Resources._11; break;
                    case 12: levelIconBox.Image = Properties.Resources._12; break;
                    case 13: levelIconBox.Image = Properties.Resources._13; break;
                    case 14: levelIconBox.Image = Properties.Resources._14; break;
                    case 15: levelIconBox.Image = Properties.Resources._15; break;
                    case 16: levelIconBox.Image = Properties.Resources._16; break;
                    case 17: levelIconBox.Image = Properties.Resources._17_18_19_23; break;
                    case 18: levelIconBox.Image = Properties.Resources._17_18_19_23; break;
                    case 19: levelIconBox.Image = Properties.Resources._17_18_19_23; break;
                    case 20: levelIconBox.Image = Properties.Resources._20; break;
                    case 21: levelIconBox.Image = Properties.Resources._21; break;
                    case 22: levelIconBox.Image = Properties.Resources._22; break;
                    case 23: levelIconBox.Image = Properties.Resources._17_18_19_23; break;
                    default: levelIconBox.Image = null; break;
                }
            }
            else levelIconBox.Image = null;
        }  

        private void updateSettingsComboBox()
        {
            if (nodeSelected == true)
            {
                switch (settings) 
                {
                    case 9: settingsComboBox.SelectedIndex = 0; break;//Normal
                    case 1: settingsComboBox.SelectedIndex = 1; break;//No level point
                    case 0: settingsComboBox.SelectedIndex = 2; break;//No starcoins/fork
                    case 8: settingsComboBox.SelectedIndex = 3; break;//No starcoins/Starting point
                    case 11: settingsComboBox.SelectedIndex = 4; break;//Leaving out of tower
                    case 29: settingsComboBox.SelectedIndex = 5; break;//Leaving out of castle
                    default: settingsComboBox.SelectedIndex = -1; break;
                }
            }
            else settingsComboBox.SelectedIndex = -1;
        }

        private void settingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (settingsComboBox.SelectedIndex) 
            {
                case 0: settings = 9; break;//Normal
                case 1: settings = 1; break; //No level point
                case 2: settings = 0; break;//No starcoins/fork
                case 3: settings = 8; break;//No starcoins/Starting point
                case 4: settings = 11; break;//Leaving out of tower
                case 5: settings = 29; break;//Leaving out of castle
                default: break;
            }
            numericUpDownSettings.Value = settings;
        }

        public void disableEditor()
        {
            selectedNodeLabel.Text = "Select a Node";
            coordinatesBox.Enabled = false;
            settingsBox.Enabled = false;
            secretExitBox.Enabled = false;
            normalExitBox.Enabled = false;
            pointerPanel.Enabled = false;
            x = 0;
            y = 0;
            z = 0;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            sp1 = 0;
            sp2 = 0;
            sp3 = 0;
            sp4 = 0;
            c = 0;
            sc = 0;
            area = 0;
            icon = 0;
            settings = 0;
            ptr = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            levelIconBox.Image = null;
        }
    }
}
