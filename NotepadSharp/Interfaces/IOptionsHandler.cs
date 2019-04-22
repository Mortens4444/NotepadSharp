using NotepadSharp.Options;

namespace NotepadSharp.Interfaces
{
    public interface IOptionsHandler
    {
        OptionsDto Options { get; }

        void SetOptions();
    }
}