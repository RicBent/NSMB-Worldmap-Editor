namespace NSMB_Worldmap_Editor
{
    partial class ReplacePathDialog
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
            this.selectedMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedMethod
            // 
            this.selectedMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedMethod.FormattingEnabled = true;
            this.selectedMethod.Items.AddRange(new object[] {
            "Jump into Tower",
            "Jump into Castle"});
            this.selectedMethod.Location = new System.Drawing.Point(89, 12);
            this.selectedMethod.Name = "selectedMethod";
            this.selectedMethod.Size = new System.Drawing.Size(139, 21);
            this.selectedMethod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Replace with:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(153, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(72, 102);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Y Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start X Position";
            // 
            // numericUpDownSY
            // 
            this.numericUpDownSY.Location = new System.Drawing.Point(96, 65);
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
            this.numericUpDownSY.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownSY.TabIndex = 7;
            // 
            // numericUpDownSX
            // 
            this.numericUpDownSX.Location = new System.Drawing.Point(96, 39);
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
            this.numericUpDownSX.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownSX.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 2);
            this.label6.TabIndex = 11;
            // 
            // ReplacePathDialog
            // 
            this.AcceptButton = this.replaceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(238, 132);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSY);
            this.Controls.Add(this.numericUpDownSX);
            this.Controls.Add(this.selectedMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.replaceButton);
            this.Name = "ReplacePathDialog";
            this.Text = "Replace Path with...";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSY;
        private System.Windows.Forms.NumericUpDown numericUpDownSX;
        private System.Windows.Forms.Label label6;
    }
}