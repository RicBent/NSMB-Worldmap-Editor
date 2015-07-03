namespace NSMB_Worldmap_Editor
{
    partial class InsertStraightWalkDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButtom = new System.Windows.Forms.Button();
            this.numericUpDownSX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(233, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // startButtom
            // 
            this.startButtom.Location = new System.Drawing.Point(152, 110);
            this.startButtom.Name = "startButtom";
            this.startButtom.Size = new System.Drawing.Size(75, 23);
            this.startButtom.TabIndex = 1;
            this.startButtom.Text = "Finish";
            this.startButtom.UseVisualStyleBackColor = true;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // numericUpDownSX
            // 
            this.numericUpDownSX.Location = new System.Drawing.Point(67, 39);
            this.numericUpDownSX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownSX.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownSX.Name = "numericUpDownSX";
            this.numericUpDownSX.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSX.TabIndex = 3;
            // 
            // numericUpDownSY
            // 
            this.numericUpDownSY.Location = new System.Drawing.Point(67, 65);
            this.numericUpDownSY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownSY.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownSY.Name = "numericUpDownSY";
            this.numericUpDownSY.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Y";
            // 
            // comboBoxD
            // 
            this.comboBoxD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxD.FormattingEnabled = true;
            this.comboBoxD.Items.AddRange(new object[] {
            "Right",
            "Up",
            "Down",
            "Left"});
            this.comboBoxD.Location = new System.Drawing.Point(67, 12);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(75, 21);
            this.comboBoxD.TabIndex = 5;
            this.comboBoxD.SelectedIndexChanged += new System.EventHandler(this.comboBoxD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destination X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination Y";
            // 
            // numericUpDownDX
            // 
            this.numericUpDownDX.Location = new System.Drawing.Point(233, 39);
            this.numericUpDownDX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownDX.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownDX.Name = "numericUpDownDX";
            this.numericUpDownDX.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDX.TabIndex = 3;
            // 
            // numericUpDownDY
            // 
            this.numericUpDownDY.Location = new System.Drawing.Point(233, 63);
            this.numericUpDownDY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownDY.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownDY.Name = "numericUpDownDY";
            this.numericUpDownDY.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDY.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 2);
            this.label6.TabIndex = 7;
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(233, 13);
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownZ.TabIndex = 8;
            this.numericUpDownZ.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Z (any place)";
            // 
            // InsertStraightWalkDialog
            // 
            this.AcceptButton = this.startButtom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(322, 143);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDY);
            this.Controls.Add(this.numericUpDownSY);
            this.Controls.Add(this.numericUpDownDX);
            this.Controls.Add(this.numericUpDownSX);
            this.Controls.Add(this.startButtom);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertStraightWalkDialog";
            this.ShowInTaskbar = false;
            this.Text = "Insert Straight Walk...";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButtom;
        private System.Windows.Forms.NumericUpDown numericUpDownSX;
        private System.Windows.Forms.NumericUpDown numericUpDownSY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDX;
        private System.Windows.Forms.NumericUpDown numericUpDownDY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label label7;
    }
}