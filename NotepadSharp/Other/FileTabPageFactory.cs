using NotepadSharp.Controls;
using NotepadSharp.FileHandling;
using NotepadSharp.Interfaces;
using System.ComponentModel;
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

        public FileTabPage Create(FileDetails fileDetails, int tabNumber, IContainer components, ContextMenuStrip contextMenuStrip)
        {
            var result = new FileTabPage(fileWriter);
            result.Initialize(fileDetails, tabNumber);
			contextMenuStrip.Items[0].Enabled = fileDetails != null;
			result.TextBox.ContextMenuStrip = contextMenuStrip;
            return result;
        }
    }
}
