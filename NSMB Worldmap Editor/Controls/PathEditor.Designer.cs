namespace NSMB_Worldmap_Editor.Controls
{
    partial class PathEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openNsbcaButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.insertStraightWalksButton = new System.Windows.Forms.Button();
            this.groupBoxAtFrame = new System.Windows.Forms.GroupBox();
            this.comboBoxPD = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownPZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelectedFrame = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrames = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelectedPath = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveNsbcaButton = new System.Windows.Forms.Button();
            this.createNsbcaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxAtFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedPath)).BeginInit();
            this.SuspendLayout();
            // 
            // openNsbcaButton
            // 
            this.openNsbcaButton.Location = new System.Drawing.Point(3, 8);
            this.openNsbcaButton.Name = "openNsbcaButton";
            this.openNsbcaButton.Size = new System.Drawing.Size(244, 23);
            this.openNsbcaButton.TabIndex = 1;
            this.openNsbcaButton.Text = "Open Path Animations";
            this.openNsbcaButton.UseVisualStyleBackColor = true;
            this.openNsbcaButton.Click += new System.EventHandler(this.openNsbcaButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupBoxTools);
            this.contentPanel.Controls.Add(this.groupBoxAtFrame);
            this.contentPanel.Controls.Add(this.numericUpDownSelectedFrame);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.numericUpDownFrames);
            this.contentPanel.Controls.Add(this.numericUpDownSelectedPath);
            this.contentPanel.Controls.Add(this.label7);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Enabled = false;
            this.contentPanel.Location = new System.Drawing.Point(0, 95);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(250, 412);
            this.contentPanel.TabIndex = 2;
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.button1);
            this.groupBoxTools.Controls.Add(this.insertStraightWalksButton);
            this.groupBoxTools.Location = new System.Drawing.Point(3, 212);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(244, 129);
            this.groupBoxTools.TabIndex = 7;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools";
            // 
            // insertStraightWalksButton
            // 
            this.insertStraightWalksButton.Location = new System.Drawing.Point(9, 19);
            this.insertStraightWalksButton.Name = "insertStraightWalksButton";
            this.insertStraightWalksButton.Size = new System.Drawing.Size(229, 23);
            this.insertStraightWalksButton.TabIndex = 0;
            this.insertStraightWalksButton.Text = "Insert Straight Walk";
            this.insertStraightWalksButton.UseVisualStyleBackColor = true;
            this.insertStraightWalksButton.Click += new System.EventHandler(this.insertStraightWalksButton_Click);
            // 
            // groupBoxAtFrame
            // 
            this.groupBoxAtFrame.Controls.Add(this.comboBoxPD);
            this.groupBoxAtFrame.Controls.Add(this.label12);
            this.groupBoxAtFrame.Controls.Add(this.label8);
            this.groupBoxAtFrame.Controls.Add(this.label9);
            this.groupBoxAtFrame.Controls.Add(this.label10);
            this.groupBoxAtFrame.Controls.Add(this.numericUpDownPZ);
            this.groupBoxAtFrame.Controls.Add(this.numericUpDownPY);
            this.groupBoxAtFrame.Controls.Add(this.numericUpDownPX);
            this.groupBoxAtFrame.Location = new System.Drawing.Point(3, 81);
            this.groupBoxAtFrame.Name = "groupBoxAtFrame";
            this.groupBoxAtFrame.Size = new System.Drawing.Size(244, 125);
            this.groupBoxAtFrame.TabIndex = 6;
            this.groupBoxAtFrame.TabStop = false;
            this.groupBoxAtFrame.Text = "Position at selected frame";
            // 
            // comboBoxPD
            // 
            this.comboBoxPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPD.FormattingEnabled = true;
            this.comboBoxPD.Items.AddRange(new object[] {
            "Right",
            "Up",
            "Down",
            "Left"});
            this.comboBoxPD.Location = new System.Drawing.Point(66, 96);
            this.comboBoxPD.Name = "comboBoxPD";
            this.comboBoxPD.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPD.TabIndex = 7;
            this.comboBoxPD.SelectedIndexChanged += new System.EventHandler(this.positionAtFrameChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Direction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Z-Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Y-Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "X-Position";
            // 
            // numericUpDownPZ
            // 
            this.numericUpDownPZ.Location = new System.Drawing.Point(66, 71);
            this.numericUpDownPZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownPZ.Name = "numericUpDownPZ";
            this.numericUpDownPZ.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownPZ.TabIndex = 5;
            this.numericUpDownPZ.ValueChanged += new System.EventHandler(this.positionAtFrameChanged);
            // 
            // numericUpDownPY
            // 
            this.numericUpDownPY.Location = new System.Drawing.Point(66, 45);
            this.numericUpDownPY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownPY.Name = "numericUpDownPY";
            this.numericUpDownPY.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownPY.TabIndex = 5;
            this.numericUpDownPY.ValueChanged += new System.EventHandler(this.positionAtFrameChanged);
            // 
            // numericUpDownPX
            // 
            this.numericUpDownPX.Location = new System.Drawing.Point(66, 19);
            this.numericUpDownPX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownPX.Name = "numericUpDownPX";
            this.numericUpDownPX.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownPX.TabIndex = 5;
            this.numericUpDownPX.ValueChanged += new System.EventHandler(this.positionAtFrameChanged);
            // 
            // numericUpDownSelectedFrame
            // 
            this.numericUpDownSelectedFrame.Location = new System.Drawing.Point(96, 55);
            this.numericUpDownSelectedFrame.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedFrame.Name = "numericUpDownSelectedFrame";
            this.numericUpDownSelectedFrame.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownSelectedFrame.TabIndex = 0;
            this.numericUpDownSelectedFrame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedFrame.ValueChanged += new System.EventHandler(this.numericUpDownSelectedFrame_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frames";
            // 
            // numericUpDownFrames
            // 
            this.numericUpDownFrames.Location = new System.Drawing.Point(96, 29);
            this.numericUpDownFrames.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrames.Name = "numericUpDownFrames";
            this.numericUpDownFrames.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownFrames.TabIndex = 1;
            this.numericUpDownFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrames.ValueChanged += new System.EventHandler(this.numericUpDownFrames_ValueChanged);
            // 
            // numericUpDownSelectedPath
            // 
            this.numericUpDownSelectedPath.Location = new System.Drawing.Point(96, 3);
            this.numericUpDownSelectedPath.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedPath.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedPath.Name = "numericUpDownSelectedPath";
            this.numericUpDownSelectedPath.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownSelectedPath.TabIndex = 1;
            this.numericUpDownSelectedPath.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelectedPath.ValueChanged += new System.EventHandler(this.numericUpDownSelectedPath_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Selected Frame";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Path";
            // 
            // saveNsbcaButton
            // 
            this.saveNsbcaButton.Enabled = false;
            this.saveNsbcaButton.Location = new System.Drawing.Point(3, 37);
            this.saveNsbcaButton.Name = "saveNsbcaButton";
            this.saveNsbcaButton.Size = new System.Drawing.Size(244, 23);
            this.saveNsbcaButton.TabIndex = 1;
            this.saveNsbcaButton.Text = "Save Path Animations";
            this.saveNsbcaButton.UseVisualStyleBackColor = true;
            this.saveNsbcaButton.Click += new System.EventHandler(this.saveNsbcaButton_Click);
            // 
            // createNsbcaButton
            // 
            this.createNsbcaButton.Location = new System.Drawing.Point(3, 66);
            this.createNsbcaButton.Name = "createNsbcaButton";
            this.createNsbcaButton.Size = new System.Drawing.Size(244, 23);
            this.createNsbcaButton.TabIndex = 1;
            this.createNsbcaButton.Text = "Create Path Animations";
            this.createNsbcaButton.UseVisualStyleBackColor = true;
            this.createNsbcaButton.Click += new System.EventHandler(this.createNsbcaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modify Z-Positions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insertStraightWalksButton_Click);
            // 
            // PathEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.createNsbcaButton);
            this.Controls.Add(this.saveNsbcaButton);
            this.Controls.Add(this.openNsbcaButton);
            this.Name = "PathEditor";
            this.Size = new System.Drawing.Size(250, 541);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxAtFrame.ResumeLayout(false);
            this.groupBoxAtFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNsbcaButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedFrame;
        private System.Windows.Forms.Button saveNsbcaButton;
        private System.Windows.Forms.GroupBox groupBoxAtFrame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownPZ;
        private System.Windows.Forms.NumericUpDown numericUpDownPY;
        private System.Windows.Forms.NumericUpDown numericUpDownPX;
        private System.Windows.Forms.NumericUpDown numericUpDownFrames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button createNsbcaButton;
        private System.Windows.Forms.ComboBox comboBoxPD;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button insertStraightWalksButton;
        private System.Windows.Forms.Button button1;

    }
}
