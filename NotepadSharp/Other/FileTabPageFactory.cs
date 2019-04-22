using NotepadSharp.Controls;
using NotepadSharp.FileHandling;
using NotepadSharp.Interfaces;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadSharp.Other
{
    public class FileTabPageFactory : IFileTabPageFactory
    {
        private readonly IFileWriter fileWriter;

        public FileTabPageFactory(IFileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public FileTabPage Create(FileDetails fileDetails, int tabNumber, IContainer components, ToolStripItem[] menuItems)
        {
            var result = new FileTabPage(fileWriter);
            result.Initialize(fileDetails, tabNumber);
            var contextMenuStrip = new ContextMenuStrip(components);
            contextMenuStrip.Items.AddRange(menuItems);
            contextMenuStrip.Name = $"contextMenuStrip{tabNumber}";
            contextMenuStrip.Size = new Size(197, 98);
            contextMenuStrip.Opening += (object sender, CancelEventArgs e) =>
            {
                menuItems[0].Enabled = result.FileDetails != null;
            };
            result.ContextMenuStrip = contextMenuStrip;
            result.TextBox.ContextMenuStrip = contextMenuStrip;
            return result;
        }
    }
}
