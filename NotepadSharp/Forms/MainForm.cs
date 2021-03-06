﻿using NotepadSharp.Controls;
using NotepadSharp.FileHandling;
using NotepadSharp.Interfaces;
using NotepadSharp.Options;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadSharp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IFileReader fileReader;
        private readonly IFileTabPageFactory fileTabPageFactory;
        private readonly IOptionsHandler optionsHandler;
        private readonly OptionsDto options;
		private readonly ContextMenuStrip contextMenuStrip;

		public MainForm(IFileReader fileReader,
            IFileTabPageFactory fileTabPageFactory,
            IOptionsHandler optionsHandler)
        {
            InitializeComponent();

            if (components == null)
            {
                components = new System.ComponentModel.Container();
            }

            this.fileReader = fileReader;
            this.fileTabPageFactory = fileTabPageFactory;
            this.optionsHandler = optionsHandler;
            options = optionsHandler.Options;
            wrapLongLinesMenuItem.Checked = !options.WrapLongLines;

			var menuItems = new ToolStripItem[]
			{
				copyPathMenuItem,
				toolStripSeparator3,
				closeMenuItem,
				closeAllButThisMenuItem,
				closeAllMenuItem
			};
			contextMenuStrip = new ContextMenuStrip(components)
			{
				Name = $"contextMenuStrip",
				Size = new Size(197, 98)
			};
			contextMenuStrip.Items.AddRange(menuItems);
		}

		private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = options.FormWindowState;
            Location = new Point(options.X, options.Y);
            Size = new Size(options.Width, options.Height);
            if (options.OpenedFiles == String.Empty)
            {
                OpenNewTab(null);
            }
            else
            {
                var openedFiles = options.OpenedFiles.Split(';');
                foreach (var openedFile in openedFiles)
                {
                    if (!String.IsNullOrWhiteSpace(openedFile) && File.Exists(openedFile))
                    {
                        OpenFile(openedFile);
                    }
                }
            }
            wrapLongLinesMenuItem.Checked = options.WrapLongLines;
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            options.FormWindowState = WindowState;
            options.X = Location.X;
            options.Y = Location.Y;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            options.FormWindowState = WindowState;
            options.Width = Width;
            options.Height = Height;
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewTab(null);
        }

        private void OpenNewTab(FileDetails fileDetails)
        {
            var tabNumber = tabControl.Controls.Count + 1;
            var newTab = fileTabPageFactory.Create(fileDetails, tabNumber, components, contextMenuStrip);
            tabControl.Controls.Add(newTab);
            tabControl.SelectedTab = newTab;
        }

        private void CopyPathMenuItem_Click(object sender, EventArgs e)
        {
            var textBox = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl as FileRichTextBox;
            if (textBox != null && textBox.FileDetails != null)
            {
                Clipboard.SetText(textBox.FileDetails.FileName);
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
                options.AppendToOpenedFiles(openFileDialog.FileName);
            }
        }

        private void OpenFile(string fileName)
        {
            var fileContent = fileReader.GetFileContent(fileName);
            var fileDetails = new FileDetails(fileName);
            OpenNewTab(fileDetails);
            var activeTab = tabControl.SelectedTab as FileTabPage;
            activeTab.TextBox.Text = fileContent;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            var fileTabPage = tabControl.SelectedTab as FileTabPage;
            fileTabPage.SaveFile(options);
        }

        private void SaveAllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in tabControl.TabPages)
            {
                tabPage.SaveFile(options);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^X");
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^C");
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^V");
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            optionsHandler.SetOptions();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            var fileTabPage = tabControl.SelectedTab as FileTabPage;
            CloseTabPage(fileTabPage);
        }

        private void CloseAllButThisMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTabPage = tabControl.SelectedTab as FileTabPage;
            foreach (FileTabPage tabPage in tabControl.TabPages)
            {
                if (tabPage != selectedTabPage)
                {
                    CloseTabPage(tabPage);
                }
            }
        }

        private void CloseAllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in tabControl.TabPages)
            {
                CloseTabPage(tabPage);
            }
        }

        private void CloseTabPage(FileTabPage fileTabPage)
        {
            tabControl.TabPages.Remove(fileTabPage);
            if (fileTabPage.FileDetails != null)
            {
                if (options.OpenedFiles == fileTabPage.FileDetails.FileName)
                {
                    options.OpenedFiles = String.Empty;
                }
                else
                {
                    options.OpenedFiles = options.OpenedFiles.EndsWith($";{fileTabPage.FileDetails.FileName}")
                        ? options.OpenedFiles.Replace($";{fileTabPage.FileDetails.FileName}", String.Empty)
                        : options.OpenedFiles.Replace($"{fileTabPage.FileDetails.FileName};", String.Empty);
                }
            }
        }

        private void WrapLongLinesMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            foreach (FileTabPage tabPage in tabControl.TabPages)
            {
                tabPage.RefreshScrollBars(wrapLongLinesMenuItem.Checked);
            }
        }

		private void TabControl_Selected(object sender, TabControlEventArgs e)
		{
			var fileTabPage = e.TabPage as FileTabPage;
			if (fileTabPage != null)
			{
				contextMenuStrip.Items[0].Enabled = fileTabPage.FileDetails != null;
			}
		}
	}
}
