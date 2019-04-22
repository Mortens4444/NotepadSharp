using NotepadSharp.Interfaces;
using System.IO;

namespace NotepadSharp.FileHandling
{
    public class FileDetails : IFileDetails
    {
        public string FileName { get; private set; }

        public string ShowFileName { get; private set; }

        public bool Changed { get; set; }

        public FileDetails(string fileName)
        {
            FileName = fileName;
            ShowFileName = Path.GetFileName(fileName);
        }
    }
}
