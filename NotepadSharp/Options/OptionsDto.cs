using System;
using System.Windows.Forms;

namespace NotepadSharp.Options
{
    public class OptionsDto
    {
        public FormWindowState FormWindowState { get; set; } = FormWindowState.Maximized;

        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        public int Width { get; set; } = 1920;

        public int Height { get; set; } = 1080;

        public string OpenedFiles { get; set; } = String.Empty;

        public bool WrapLongLines { get; set; } = false;

        public void AppendToOpenedFiles(string fileName)
        {
            OpenedFiles = OpenedFiles == String.Empty ? fileName : $"{OpenedFiles};{fileName}";
        }
    }
}
