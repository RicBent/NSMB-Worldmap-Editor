namespace NSMB_Worldmap_Editor
{
    partial class WorldmapEditor
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldmapEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.worldComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.nodesPage = new System.Windows.Forms.TabPage();
            this.nodeEditor = new NSMB_Worldmap_Editor.Controls.NodeEditor();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.pathAnimationsPage = new System.Windows.Forms.TabPage();
            this.pathEditor = new NSMB_Worldmap_Editor.Controls.PathEditor();
            this.editor = new NSMB_Worldmap_Editor.Controls.EditorControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.nodesPage.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.pathAnimationsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1247, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // worldComboBox
            // 
            this.worldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worldComboBox.Enabled = false;
            this.worldComboBox.Items.AddRange(new object[] {
            "World 1",
            "World 2",
            "World 3",
            "World 4",
            "World 5",
            "World 6",
            "World 7",
            "World 8"});
            this.worldComboBox.Name = "worldComboBox";
            this.worldComboBox.Size = new System.Drawing.Size(121, 25);
            this.worldComboBox.SelectedIndexChanged += new System.EventHandler(this.worldComboBox_SelectionChangeCommitted);
            // 
            // nodesPage
            // 
            this.nodesPage.Controls.Add(this.nodeEditor);
            this.nodesPage.Location = new System.Drawing.Point(4, 22);
            this.nodesPage.Name = "nodesPage";
            this.nodesPage.Padding = new System.Windows.Forms.Padding(3);
            this.nodesPage.Size = new System.Drawing.Size(256, 704);
            this.nodesPage.TabIndex = 0;
            this.nodesPage.Text = "Nodes";
            this.nodesPage.UseVisualStyleBackColor = true;
            // 
            // nodeEditor
            // 
            this.nodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodeEditor.Enabled = false;
            this.nodeEditor.Location = new System.Drawing.Point(3, 3);
            this.nodeEditor.Name = "nodeEditor";
            this.nodeEditor.Size = new System.Drawing.Size(250, 698);
            this.nodeEditor.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.nodesPage);
            this.mainTabControl.Controls.Add(this.pathAnimationsPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainTabControl.Location = new System.Drawing.Point(0, 49);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(264, 730);
            this.mainTabControl.TabIndex = 2;
            // 
            // pathAnimationsPage
            // 
            this.pathAnimationsPage.Controls.Add(this.pathEditor);
            this.pathAnimationsPage.Location = new System.Drawing.Point(4, 22);
            this.pathAnimationsPage.Name = "pathAnimationsPage";
            this.pathAnimationsPage.Size = new System.Drawing.Size(256, 704);
            this.pathAnimationsPage.TabIndex = 1;
            this.pathAnimationsPage.Text = "Paths Animations";
            this.pathAnimationsPage.UseVisualStyleBackColor = true;
            // 
            // pathEditor
            // 
            this.pathEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathEditor.Enabled = false;
            this.pathEditor.Location = new System.Drawing.Point(0, 0);
            this.pathEditor.Name = "pathEditor";
            this.pathEditor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pathEditor.Size = new System.Drawing.Size(256, 704);
            this.pathEditor.TabIndex = 0;
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(264, 49);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(983, 730);
            this.editor.TabIndex = 3;
            // 
            // WorldmapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 779);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 570);
            this.Name = "WorldmapEditor";
            this.Text = "NSMB Worldmap Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.nodesPage.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.pathAnimationsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Controls.EditorControl editor;
        private System.Windows.Forms.TabPage nodesPage;
        private Controls.NodeEditor nodeEditor;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripComboBox worldComboBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabPage pathAnimationsPage;
        private Controls.PathEditor pathEditor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;





    }
}

