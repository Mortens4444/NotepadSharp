namespace NotepadSharp.Forms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMenuItemFM = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllButThisMenuItemFM = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllMenuItemFM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.wrapLongLinesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.copyPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.closeAllButThisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.splitter = new System.Windows.Forms.Splitter();
			this.menuStrip.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.toolStripSeparator1,
            this.openMenuItem,
            this.closeMenuItemFM,
            this.closeAllButThisMenuItemFM,
            this.closeAllMenuItemFM,
            this.toolStripSeparator5,
            this.saveMenuItem,
            this.saveAllMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// newMenuItem
			// 
			this.newMenuItem.Image = global::NotepadSharp.Properties.Resources.text_page;
			this.newMenuItem.Name = "newMenuItem";
			this.newMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.newMenuItem.Size = new System.Drawing.Size(185, 22);
			this.newMenuItem.Text = "New";
			this.newMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
			// 
			// openMenuItem
			// 
			this.openMenuItem.Image = global::NotepadSharp.Properties.Resources.folder_explore;
			this.openMenuItem.Name = "openMenuItem";
			this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openMenuItem.Size = new System.Drawing.Size(185, 22);
			this.openMenuItem.Text = "Open";
			this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
			// 
			// closeMenuItemFM
			// 
			this.closeMenuItemFM.Name = "closeMenuItemFM";
			this.closeMenuItemFM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this.closeMenuItemFM.Size = new System.Drawing.Size(185, 22);
			this.closeMenuItemFM.Text = "Close";
			this.closeMenuItemFM.Click += new System.EventHandler(this.CloseMenuItem_Click);
			// 
			// closeAllButThisMenuItemFM
			// 
			this.closeAllButThisMenuItemFM.Name = "closeAllButThisMenuItemFM";
			this.closeAllButThisMenuItemFM.Size = new System.Drawing.Size(185, 22);
			this.closeAllButThisMenuItemFM.Text = "Close all but this";
			this.closeAllButThisMenuItemFM.Click += new System.EventHandler(this.CloseAllButThisMenuItem_Click);
			// 
			// closeAllMenuItemFM
			// 
			this.closeAllMenuItemFM.Name = "closeAllMenuItemFM";
			this.closeAllMenuItemFM.Size = new System.Drawing.Size(185, 22);
			this.closeAllMenuItemFM.Text = "Close all";
			this.closeAllMenuItemFM.Click += new System.EventHandler(this.CloseAllMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Image = global::NotepadSharp.Properties.Resources.save;
			this.saveMenuItem.Name = "saveMenuItem";
			this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveMenuItem.Size = new System.Drawing.Size(185, 22);
			this.saveMenuItem.Text = "Save";
			this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
			// 
			// saveAllMenuItem
			// 
			this.saveAllMenuItem.Name = "saveAllMenuItem";
			this.saveAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAllMenuItem.Size = new System.Drawing.Size(185, 22);
			this.saveAllMenuItem.Text = "Save all";
			this.saveAllMenuItem.Click += new System.EventHandler(this.SaveAllMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Image = global::NotepadSharp.Properties.Resources.exit;
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitMenuItem.Size = new System.Drawing.Size(185, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.toolStripSeparator4,
            this.wrapLongLinesMenuItem});
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "Edit";
			// 
			// cutMenuItem
			// 
			this.cutMenuItem.Image = global::NotepadSharp.Properties.Resources.cut;
			this.cutMenuItem.Name = "cutMenuItem";
			this.cutMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
			this.cutMenuItem.Size = new System.Drawing.Size(156, 22);
			this.cutMenuItem.Text = "Cut";
			this.cutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Image = global::NotepadSharp.Properties.Resources.copy;
			this.copyMenuItem.Name = "copyMenuItem";
			this.copyMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
			this.copyMenuItem.Size = new System.Drawing.Size(156, 22);
			this.copyMenuItem.Text = "Copy";
			this.copyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
			// 
			// pasteMenuItem
			// 
			this.pasteMenuItem.Image = global::NotepadSharp.Properties.Resources.paste_plain;
			this.pasteMenuItem.Name = "pasteMenuItem";
			this.pasteMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
			this.pasteMenuItem.Size = new System.Drawing.Size(156, 22);
			this.pasteMenuItem.Text = "Paste";
			this.pasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
			// 
			// wrapLongLinesMenuItem
			// 
			this.wrapLongLinesMenuItem.CheckOnClick = true;
			this.wrapLongLinesMenuItem.Name = "wrapLongLinesMenuItem";
			this.wrapLongLinesMenuItem.Size = new System.Drawing.Size(156, 22);
			this.wrapLongLinesMenuItem.Text = "Wrap long lines";
			this.wrapLongLinesMenuItem.CheckedChanged += new System.EventHandler(this.WrapLongLinesMenuItem_CheckedChanged);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Image = global::NotepadSharp.Properties.Resources.tag_blue;
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
			// 
			// closeMenuItem
			// 
			this.closeMenuItem.Name = "closeMenuItem";
			this.closeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this.closeMenuItem.Size = new System.Drawing.Size(185, 22);
			this.closeMenuItem.Text = "Close";
			this.closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "toolStrip1";
			this.toolStrip.Visible = false;
			// 
			// copyPathMenuItem
			// 
			this.copyPathMenuItem.Name = "copyPathMenuItem";
			this.copyPathMenuItem.Size = new System.Drawing.Size(196, 22);
			this.copyPathMenuItem.Text = "Copy path to clipboard";
			this.copyPathMenuItem.Click += new System.EventHandler(this.CopyPathMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
			// 
			// closeAllButThisMenuItem
			// 
			this.closeAllButThisMenuItem.Name = "closeAllButThisMenuItem";
			this.closeAllButThisMenuItem.Size = new System.Drawing.Size(196, 22);
			this.closeAllButThisMenuItem.Text = "Close all but this";
			this.closeAllButThisMenuItem.Click += new System.EventHandler(this.CloseAllButThisMenuItem_Click);
			// 
			// closeAllMenuItem
			// 
			this.closeAllMenuItem.Name = "closeAllMenuItem";
			this.closeAllMenuItem.Size = new System.Drawing.Size(196, 22);
			this.closeAllMenuItem.Text = "Close all";
			this.closeAllMenuItem.Click += new System.EventHandler(this.CloseAllMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.tabControl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 24);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(800, 404);
			this.mainPanel.TabIndex = 3;
			// 
			// tabControl
			// 
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 404);
			this.tabControl.TabIndex = 1;
			this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
			// 
			// splitter
			// 
			this.splitter.Location = new System.Drawing.Point(0, 0);
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(3, 379);
			this.splitter.TabIndex = 1;
			this.splitter.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Notepad#";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyPathMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItemFM;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisMenuItemFM;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenuItemFM;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem wrapLongLinesMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

