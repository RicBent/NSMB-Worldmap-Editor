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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flagLabel = new System.Windows.Forms.Label();
            this.numberOfPathsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownPZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPX = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelectedFrame = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrames = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelectedPath = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIX)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.flagLabel);
            this.panel1.Controls.Add(this.numberOfPathsLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.modeComboBox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.numericUpDownSelectedFrame);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownFrames);
            this.panel1.Controls.Add(this.numericUpDownSelectedPath);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 431);
            this.panel1.TabIndex = 2;
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Location = new System.Drawing.Point(9, 385);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flagLabel.Size = new System.Drawing.Size(57, 18);
            this.flagLabel.TabIndex = 7;
            this.flagLabel.Text = "Flag: 0000";
            // 
            // numberOfPathsLabel
            // 
            this.numberOfPathsLabel.AutoSize = true;
            this.numberOfPathsLabel.Location = new System.Drawing.Point(9, 367);
            this.numberOfPathsLabel.Name = "numberOfPathsLabel";
            this.numberOfPathsLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.numberOfPathsLabel.Size = new System.Drawing.Size(98, 18);
            this.numberOfPathsLabel.TabIndex = 7;
            this.numberOfPathsLabel.Text = "Number of Paths: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.Enabled = false;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "X Changes",
            "Y Changes",
            "X/Y Changes",
            "X/Z Changes",
            "Y/Z-Changes",
            "X/Y/ZChanges",
            "Y Changes (No Direction)",
            "X/Y Changes (No Direction)",
            "Y/Z Changes (No Direction)",
            "X/Y/Z Changes (No Direction)"});
            this.modeComboBox.Location = new System.Drawing.Point(61, 80);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(186, 21);
            this.modeComboBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownPZ);
            this.groupBox2.Controls.Add(this.numericUpDownPD);
            this.groupBox2.Controls.Add(this.numericUpDownPY);
            this.groupBox2.Controls.Add(this.numericUpDownPX);
            this.groupBox2.Location = new System.Drawing.Point(3, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position at selected frame";
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
            // 
            // numericUpDownPD
            // 
            this.numericUpDownPD.Location = new System.Drawing.Point(66, 97);
            this.numericUpDownPD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPD.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPD.Name = "numericUpDownPD";
            this.numericUpDownPD.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownPD.TabIndex = 5;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownID);
            this.groupBox1.Controls.Add(this.numericUpDownIZ);
            this.groupBox1.Controls.Add(this.numericUpDownIY);
            this.groupBox1.Controls.Add(this.numericUpDownIX);
            this.groupBox1.Location = new System.Drawing.Point(3, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Positions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Direction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z-Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y-Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X-Position";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(66, 97);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownID.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownID.TabIndex = 5;
            // 
            // numericUpDownIZ
            // 
            this.numericUpDownIZ.Location = new System.Drawing.Point(66, 71);
            this.numericUpDownIZ.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownIZ.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownIZ.Name = "numericUpDownIZ";
            this.numericUpDownIZ.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownIZ.TabIndex = 5;
            // 
            // numericUpDownIY
            // 
            this.numericUpDownIY.Location = new System.Drawing.Point(66, 45);
            this.numericUpDownIY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownIY.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownIY.Name = "numericUpDownIY";
            this.numericUpDownIY.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownIY.TabIndex = 5;
            // 
            // numericUpDownIX
            // 
            this.numericUpDownIX.Location = new System.Drawing.Point(66, 19);
            this.numericUpDownIX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownIX.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownIX.Name = "numericUpDownIX";
            this.numericUpDownIX.ReadOnly = true;
            this.numericUpDownIX.Size = new System.Drawing.Size(172, 20);
            this.numericUpDownIX.TabIndex = 5;
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
            this.numericUpDownFrames.Name = "numericUpDownFrames";
            this.numericUpDownFrames.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownFrames.TabIndex = 1;
            this.numericUpDownFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Path Animations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PathEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openNsbcaButton);
            this.Name = "PathEditor";
            this.Size = new System.Drawing.Size(250, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNsbcaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedFrame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIZ;
        private System.Windows.Forms.NumericUpDown numericUpDownIY;
        private System.Windows.Forms.NumericUpDown numericUpDownIX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownPZ;
        private System.Windows.Forms.NumericUpDown numericUpDownPY;
        private System.Windows.Forms.NumericUpDown numericUpDownPX;
        private System.Windows.Forms.NumericUpDown numericUpDownFrames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numberOfPathsLabel;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownPD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownID;

    }
}
