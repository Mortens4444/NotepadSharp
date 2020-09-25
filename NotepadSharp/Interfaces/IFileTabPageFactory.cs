using NotepadSharp.Controls;
using NotepadSharp.FileHandling;
using System.ComponentModel;
using System.Windows.Forms;

namespace NotepadSharp.Interfaces
{
    public interface IFileTabPageFactory
    {
        FileTabPage Create(FileDetails fileDetails, int tabNumber, IContainer components, ContextMenuStrip contextMenuStrip);
    }
}