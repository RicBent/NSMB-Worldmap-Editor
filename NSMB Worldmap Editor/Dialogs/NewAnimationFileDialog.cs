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
    public partial class NewAnimationFileDialog : Form
    {
        public NewAnimationFileDialog()
        {
            InitializeComponent();
            this.CenterToScreen();

            selectedWorld.SelectedIndex = 0;

            createButton.Focus();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public int worldIndex() { return selectedWorld.SelectedIndex; }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
