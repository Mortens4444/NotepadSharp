namespace NotepadSharp.Interfaces
{
    public interface IFileReader
    {
        string GetFileContent(string filename);

        string[] LoadFile(string filename);

        string[] LoadFile(string filename, string separator);
    }
}