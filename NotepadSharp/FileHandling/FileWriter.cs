using NotepadSharp.Interfaces;
using System.IO;

namespace NotepadSharp.FileHandling
{
    public class FileWriter : IFileWriter
    {
        public void CreateOrOverwriteFile(string filePath, string content)
        {
            using (var streamWriter = File.CreateText(filePath))
            {
                streamWriter.Write(content);
                streamWriter.Close();
            }
        }
    }
}