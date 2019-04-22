using NotepadSharp.Interfaces;
using System.IO;

namespace NotepadSharp.Options
{
    public class OptionsFileWriter : IOptionsFileWriter
    {
        public void CreateOptionsFileIfNotExists(string optionsFilename)
        {
            if (File.Exists(optionsFilename))
            {
                return;
            }

            WriteOptionsToFile(optionsFilename, new OptionsDto());
        }

        public void WriteOptionsToFile(string optionsFilename, OptionsDto options)
        {
            using (var sw = File.CreateText(optionsFilename))
            {
                var properties = options.GetType().GetProperties();
                foreach (var property in properties)
                {
                    sw.WriteLine($"{property.Name} = {property.GetValue(options)}");
                }
                sw.Close();
            }
        }
    }
}
