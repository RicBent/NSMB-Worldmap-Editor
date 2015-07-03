using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSMB_Worldmap_Editor
{
    public partial class InsertStraightWalkDialog : Form
    {
        public List<frame> frameList;

        public InsertStraightWalkDialog()
        {
            InitializeComponent();
            this.CenterToScreen();

            comboBoxD.SelectedIndex = 0;
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            frameList = new List<frame>();
            double frameCountD;
            int frameCountI;

            if (comboBoxD.SelectedIndex == 0 || comboBoxD.SelectedIndex == 3) frameCountD = (double)(Math.Abs((int)numericUpDownDX.Value - (int)numericUpDownSX.Value)) / (double)2.5;
            else frameCountD = (double)(Math.Abs((int)numericUpDownDY.Value - (int)numericUpDownSY.Value)) / (double)2.5;

            frameCountI = (int)Math.Round(frameCountD, 0);
            if (frameCountI < 1) frameCountI = 1;

            if (comboBoxD.SelectedIndex == 0 || comboBoxD.SelectedIndex == 3)
            {
                bool last3 = false;
                int j = (int)numericUpDownSX.Value;
                for (int i = 0; i < frameCountI + 1; i++)
                {
                    if (i != 0)
                    {
                        if (numericUpDownSX.Value < numericUpDownDX.Value)
                        {
                            if (!last3) j += 3;
                            else j += 2;
                        }
                        else
                        {
                            if (!last3) j -= 3;
                            else j -= 2;
                        }

                        if (numericUpDownSX.Value < numericUpDownDX.Value) if (j > (int)numericUpDownDX.Value) j = (int)numericUpDownDX.Value;
                        if (numericUpDownSX.Value > numericUpDownDX.Value) if (j < (int)numericUpDownDX.Value) j = (int)numericUpDownDX.Value;
                        last3 = !last3;
                    }

                    frameList.Add(new frame(j, (int)numericUpDownSY.Value, (int)numericUpDownZ.Value, comboBoxD.SelectedIndex + 32768));
                }
            }

            else
            {
                bool last3 = false;
                int j = (int)numericUpDownSY.Value;
                for (int i = 0; i < frameCountI + 1; i++)
                {
                    if (i != 0)
                    {
                        if (numericUpDownSY.Value < numericUpDownDY.Value) //Down
                        {
                            if (!last3) j += 3;
                            else j += 2;
                        }
                        else //Up
                        {
                            if (!last3) j -= 3;
                            else j -= 2;
                        }

                        if (numericUpDownSY.Value < numericUpDownDY.Value) if (j > (int)numericUpDownDY.Value) j = (int)numericUpDownDY.Value;
                        if (numericUpDownSX.Value > numericUpDownDY.Value) if (j < (int)numericUpDownDY.Value) j = (int)numericUpDownDY.Value;
                        last3 = !last3;
                    }

                    frameList.Add(new frame((int)numericUpDownSX.Value, j, (int)numericUpDownZ.Value, comboBoxD.SelectedIndex + 32768));
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void comboBoxD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxD.SelectedIndex == 0 || comboBoxD.SelectedIndex == 3)
            {
                numericUpDownDX.Enabled = true;
                numericUpDownDY.Enabled = false;
                numericUpDownDY.Value = 0;
            }
            else
            {
                numericUpDownDY.Enabled = true;
                numericUpDownDX.Enabled = false;
                numericUpDownDX.Value = 0;
            }
        }
    }
}
