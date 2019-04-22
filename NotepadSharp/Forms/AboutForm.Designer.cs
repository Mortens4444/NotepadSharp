namespace NotepadSharp.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.authorLink = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gbMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(284, 111);
            this.panelMain.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.textBox1);
            this.gbMain.Controls.Add(this.authorLink);
            this.gbMain.Controls.Add(this.lblAuthor);
            this.gbMain.Controls.Add(this.lblTitle);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(284, 111);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notepad#";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(177, 26);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author: ";
            // 
            // authorLink
            // 
            this.authorLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLink.AutoSize = true;
            this.authorLink.Location = new System.Drawing.Point(227, 26);
            this.authorLink.Name = "authorLink";
            this.authorLink.Size = new System.Drawing.Size(45, 13);
            this.authorLink.TabIndex = 2;
            this.authorLink.TabStop = true;
            this.authorLink.Text = "Mortens";
            this.authorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLink_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 52);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Please feel to free to modify or use the source code of this project without any " +
    "restrictions.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panelMain.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel authorLink;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox textBox1;
    }
}