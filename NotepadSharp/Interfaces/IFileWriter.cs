namespace NotepadSharp.Interfaces
{
    public interface IFileWriter
    {
        void CreateOrOverwriteFile(string filePath, string content);
    }
}