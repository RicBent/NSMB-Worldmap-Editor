namespace NSMB_Worldmap_Editor.Controls
{
    partial class NodeEditor
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
            this.selectedNodeLabel = new System.Windows.Forms.Label();
            this.coordinatesBox = new System.Windows.Forms.GroupBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.normalExitBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownP4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownP2 = new System.Windows.Forms.NumericUpDown();
            this.secretExitBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownSc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSp3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSp4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSp1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSp2 = new System.Windows.Forms.NumericUpDown();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownArea = new System.Windows.Forms.NumericUpDown();
            this.areaLabel = new System.Windows.Forms.Label();
            this.settingsComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDownSettings = new System.Windows.Forms.NumericUpDown();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.levelIconBox = new System.Windows.Forms.PictureBox();
            this.numericUpDownLevelIcon = new System.Windows.Forms.NumericUpDown();
            this.iconLabel = new System.Windows.Forms.Label();
            this.labelPointer = new System.Windows.Forms.Label();
            this.pointerBox = new System.Windows.Forms.TextBox();
            this.pointerPanel = new System.Windows.Forms.Panel();
            this.coordinatesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.normalExitBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2)).BeginInit();
            this.secretExitBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp2)).BeginInit();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelIcon)).BeginInit();
            this.pointerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedNodeLabel
            // 
            this.selectedNodeLabel.AutoSize = true;
            this.selectedNodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNodeLabel.Location = new System.Drawing.Point(0, 0);
            this.selectedNodeLabel.Name = "selectedNodeLabel";
            this.selectedNodeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.selectedNodeLabel.Size = new System.Drawing.Size(109, 30);
            this.selectedNodeLabel.TabIndex = 0;
            this.selectedNodeLabel.Text = "Select a Node";
            // 
            // coordinatesBox
            // 
            this.coordinatesBox.Controls.Add(this.labelZ);
            this.coordinatesBox.Controls.Add(this.labelY);
            this.coordinatesBox.Controls.Add(this.labelX);
            this.coordinatesBox.Controls.Add(this.numericUpDownZ);
            this.coordinatesBox.Controls.Add(this.numericUpDownX);
            this.coordinatesBox.Controls.Add(this.numericUpDownY);
            this.coordinatesBox.Enabled = false;
            this.coordinatesBox.Location = new System.Drawing.Point(0, 33);
            this.coordinatesBox.Name = "coordinatesBox";
            this.coordinatesBox.Size = new System.Drawing.Size(250, 100);
            this.coordinatesBox.TabIndex = 1;
            this.coordinatesBox.TabStop = false;
            this.coordinatesBox.Text = "Coordinates";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(6, 73);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 13);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(6, 47);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 21);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(26, 71);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(218, 20);
            this.numericUpDownZ.TabIndex = 2;
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(26, 19);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(218, 20);
            this.numericUpDownX.TabIndex = 1;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(26, 45);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(218, 20);
            this.numericUpDownY.TabIndex = 0;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // normalExitBox
            // 
            this.normalExitBox.Controls.Add(this.numericUpDownC);
            this.normalExitBox.Controls.Add(this.numericUpDownP3);
            this.normalExitBox.Controls.Add(this.label9);
            this.normalExitBox.Controls.Add(this.label3);
            this.normalExitBox.Controls.Add(this.label4);
            this.normalExitBox.Controls.Add(this.numericUpDownP4);
            this.normalExitBox.Controls.Add(this.numericUpDownP1);
            this.normalExitBox.Controls.Add(this.label2);
            this.normalExitBox.Controls.Add(this.label1);
            this.normalExitBox.Controls.Add(this.numericUpDownP2);
            this.normalExitBox.Enabled = false;
            this.normalExitBox.Location = new System.Drawing.Point(0, 275);
            this.normalExitBox.Name = "normalExitBox";
            this.normalExitBox.Size = new System.Drawing.Size(250, 100);
            this.normalExitBox.TabIndex = 2;
            this.normalExitBox.TabStop = false;
            this.normalExitBox.Text = "Normal Exit - Unlocked Paths";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(51, 71);
            this.numericUpDownC.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownC.TabIndex = 7;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownP3
            // 
            this.numericUpDownP3.Location = new System.Drawing.Point(51, 45);
            this.numericUpDownP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownP3.Name = "numericUpDownP3";
            this.numericUpDownP3.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownP3.TabIndex = 7;
            this.numericUpDownP3.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Path 4";
            // 
            // numericUpDownP4
            // 
            this.numericUpDownP4.Location = new System.Drawing.Point(171, 45);
            this.numericUpDownP4.Name = "numericUpDownP4";
            this.numericUpDownP4.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownP4.TabIndex = 4;
            this.numericUpDownP4.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownP1
            // 
            this.numericUpDownP1.Location = new System.Drawing.Point(51, 19);
            this.numericUpDownP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownP1.Name = "numericUpDownP1";
            this.numericUpDownP1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownP1.TabIndex = 3;
            this.numericUpDownP1.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path 2";
            // 
            // numericUpDownP2
            // 
            this.numericUpDownP2.Location = new System.Drawing.Point(171, 19);
            this.numericUpDownP2.Name = "numericUpDownP2";
            this.numericUpDownP2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownP2.TabIndex = 0;
            this.numericUpDownP2.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // secretExitBox
            // 
            this.secretExitBox.Controls.Add(this.numericUpDownSc);
            this.secretExitBox.Controls.Add(this.numericUpDownSp3);
            this.secretExitBox.Controls.Add(this.label10);
            this.secretExitBox.Controls.Add(this.label5);
            this.secretExitBox.Controls.Add(this.label6);
            this.secretExitBox.Controls.Add(this.numericUpDownSp4);
            this.secretExitBox.Controls.Add(this.numericUpDownSp1);
            this.secretExitBox.Controls.Add(this.label7);
            this.secretExitBox.Controls.Add(this.label8);
            this.secretExitBox.Controls.Add(this.numericUpDownSp2);
            this.secretExitBox.Enabled = false;
            this.secretExitBox.Location = new System.Drawing.Point(0, 381);
            this.secretExitBox.Name = "secretExitBox";
            this.secretExitBox.Size = new System.Drawing.Size(250, 100);
            this.secretExitBox.TabIndex = 3;
            this.secretExitBox.TabStop = false;
            this.secretExitBox.Text = "Secret Exit - Unlocked Paths";
            // 
            // numericUpDownSc
            // 
            this.numericUpDownSc.Location = new System.Drawing.Point(50, 71);
            this.numericUpDownSc.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownSc.Name = "numericUpDownSc";
            this.numericUpDownSc.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownSc.TabIndex = 7;
            this.numericUpDownSc.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownSp3
            // 
            this.numericUpDownSp3.Location = new System.Drawing.Point(50, 45);
            this.numericUpDownSp3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSp3.Name = "numericUpDownSp3";
            this.numericUpDownSp3.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownSp3.TabIndex = 15;
            this.numericUpDownSp3.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Camera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Path 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Path 4";
            // 
            // numericUpDownSp4
            // 
            this.numericUpDownSp4.Location = new System.Drawing.Point(170, 45);
            this.numericUpDownSp4.Name = "numericUpDownSp4";
            this.numericUpDownSp4.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownSp4.TabIndex = 12;
            this.numericUpDownSp4.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // numericUpDownSp1
            // 
            this.numericUpDownSp1.Location = new System.Drawing.Point(50, 19);
            this.numericUpDownSp1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSp1.Name = "numericUpDownSp1";
            this.numericUpDownSp1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownSp1.TabIndex = 11;
            this.numericUpDownSp1.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Path 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Path 2";
            // 
            // numericUpDownSp2
            // 
            this.numericUpDownSp2.Location = new System.Drawing.Point(171, 19);
            this.numericUpDownSp2.Name = "numericUpDownSp2";
            this.numericUpDownSp2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownSp2.TabIndex = 8;
            this.numericUpDownSp2.ValueChanged += new System.EventHandler(this.numericUpDownsVisible_ValueChanged);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.numericUpDownArea);
            this.settingsBox.Controls.Add(this.areaLabel);
            this.settingsBox.Controls.Add(this.settingsComboBox);
            this.settingsBox.Controls.Add(this.numericUpDownSettings);
            this.settingsBox.Controls.Add(this.settingsLabel);
            this.settingsBox.Controls.Add(this.levelIconBox);
            this.settingsBox.Controls.Add(this.numericUpDownLevelIcon);
            this.settingsBox.Controls.Add(this.iconLabel);
            this.settingsBox.Enabled = false;
            this.settingsBox.Location = new System.Drawing.Point(0, 139);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(250, 130);
            this.settingsBox.TabIndex = 4;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // numericUpDownArea
            // 
            this.numericUpDownArea.Location = new System.Drawing.Point(70, 100);
            this.numericUpDownArea.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownArea.Name = "numericUpDownArea";
            this.numericUpDownArea.Size = new System.Drawing.Size(171, 20);
            this.numericUpDownArea.TabIndex = 7;
            this.numericUpDownArea.ValueChanged += new System.EventHandler(this.numericUpDownsData_ValueChanged);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(7, 102);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(29, 13);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "Area";
            // 
            // settingsComboBox
            // 
            this.settingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsComboBox.FormattingEnabled = true;
            this.settingsComboBox.Items.AddRange(new object[] {
            "Normal",
            "No level point",
            "No starcoins/No level point",
            "No starcoins",
            "Tower",
            "Castle"});
            this.settingsComboBox.Location = new System.Drawing.Point(69, 73);
            this.settingsComboBox.Name = "settingsComboBox";
            this.settingsComboBox.Size = new System.Drawing.Size(172, 21);
            this.settingsComboBox.TabIndex = 5;
            this.settingsComboBox.SelectedIndexChanged += new System.EventHandler(this.settingsComboBox_SelectedIndexChanged);
            // 
            // numericUpDownSettings
            // 
            this.numericUpDownSettings.Location = new System.Drawing.Point(70, 47);
            this.numericUpDownSettings.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSettings.Name = "numericUpDownSettings";
            this.numericUpDownSettings.Size = new System.Drawing.Size(171, 20);
            this.numericUpDownSettings.TabIndex = 4;
            this.numericUpDownSettings.ValueChanged += new System.EventHandler(this.numericUpDownsData_ValueChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(6, 49);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(49, 13);
            this.settingsLabel.TabIndex = 3;
            this.settingsLabel.Text = "Behavior";
            // 
            // levelIconBox
            // 
            this.levelIconBox.Location = new System.Drawing.Point(217, 23);
            this.levelIconBox.Name = "levelIconBox";
            this.levelIconBox.Size = new System.Drawing.Size(24, 16);
            this.levelIconBox.TabIndex = 2;
            this.levelIconBox.TabStop = false;
            // 
            // numericUpDownLevelIcon
            // 
            this.numericUpDownLevelIcon.Location = new System.Drawing.Point(69, 21);
            this.numericUpDownLevelIcon.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLevelIcon.Name = "numericUpDownLevelIcon";
            this.numericUpDownLevelIcon.Size = new System.Drawing.Size(142, 20);
            this.numericUpDownLevelIcon.TabIndex = 1;
            this.numericUpDownLevelIcon.ValueChanged += new System.EventHandler(this.numericUpDownsData_ValueChanged);
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Location = new System.Drawing.Point(6, 23);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(57, 13);
            this.iconLabel.TabIndex = 0;
            this.iconLabel.Text = "Level Icon";
            // 
            // labelPointer
            // 
            this.labelPointer.AutoSize = true;
            this.labelPointer.Location = new System.Drawing.Point(6, 3);
            this.labelPointer.Name = "labelPointer";
            this.labelPointer.Size = new System.Drawing.Size(40, 13);
            this.labelPointer.TabIndex = 5;
            this.labelPointer.Text = "Pointer";
            // 
            // pointerBox
            // 
            this.pointerBox.Location = new System.Drawing.Point(50, 0);
            this.pointerBox.Name = "pointerBox";
            this.pointerBox.ReadOnly = true;
            this.pointerBox.Size = new System.Drawing.Size(191, 20);
            this.pointerBox.TabIndex = 6;
            this.pointerBox.Text = "00 00 00 00";
            // 
            // pointerPanel
            // 
            this.pointerPanel.Controls.Add(this.labelPointer);
            this.pointerPanel.Controls.Add(this.pointerBox);
            this.pointerPanel.Enabled = false;
            this.pointerPanel.Location = new System.Drawing.Point(0, 487);
            this.pointerPanel.Name = "pointerPanel";
            this.pointerPanel.Size = new System.Drawing.Size(250, 20);
            this.pointerPanel.TabIndex = 7;
            // 
            // NodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pointerPanel);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.secretExitBox);
            this.Controls.Add(this.normalExitBox);
            this.Controls.Add(this.coordinatesBox);
            this.Controls.Add(this.selectedNodeLabel);
            this.Name = "NodeEditor";
            this.Size = new System.Drawing.Size(250, 600);
            this.coordinatesBox.ResumeLayout(false);
            this.coordinatesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.normalExitBox.ResumeLayout(false);
            this.normalExitBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2)).EndInit();
            this.secretExitBox.ResumeLayout(false);
            this.secretExitBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSp2)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelIcon)).EndInit();
            this.pointerPanel.ResumeLayout(false);
            this.pointerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedNodeLabel;
        private System.Windows.Forms.GroupBox coordinatesBox;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.GroupBox normalExitBox;
        private System.Windows.Forms.GroupBox secretExitBox;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.PictureBox levelIconBox;
        private System.Windows.Forms.NumericUpDown numericUpDownLevelIcon;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownSettings;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.ComboBox settingsComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDownArea;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownP3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownP4;
        private System.Windows.Forms.NumericUpDown numericUpDownP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownP2;
        private System.Windows.Forms.NumericUpDown numericUpDownSp3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSp4;
        private System.Windows.Forms.NumericUpDown numericUpDownSp1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSp2;
        private System.Windows.Forms.Label labelPointer;
        private System.Windows.Forms.TextBox pointerBox;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownSc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pointerPanel;

    }
}
