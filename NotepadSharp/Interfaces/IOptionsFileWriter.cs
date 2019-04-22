using NotepadSharp.Options;

namespace NotepadSharp.Interfaces
{
    public interface IOptionsFileWriter
    {
        void CreateOptionsFileIfNotExists(string optionsFilename);
        void WriteOptionsToFile(string optionsFilename, OptionsDto options);
    }
}