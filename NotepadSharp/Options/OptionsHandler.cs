using NotepadSharp.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NotepadSharp.Options
{
    public class OptionsHandler : IOptionsHandler
    {
        public OptionsDto Options { get; private set; }

        private readonly IOptionsFileWriter optionsFileWriter;
        private readonly string optionsFilename = Path.Combine(Application.StartupPath, "options.ini");

        public OptionsHandler(IOptionsFileWriter optionsFileWriter)
        {
            this.optionsFileWriter = optionsFileWriter;
            optionsFileWriter.CreateOptionsFileIfNotExists(optionsFilename);
            Options = GetOptions();
        }

        public void SetOptions()
        {
            optionsFileWriter.WriteOptionsToFile(optionsFilename, Options);
        }

        private OptionsDto GetOptions()
        {
            var result = new OptionsDto();
            var optionsFileContent = File.ReadAllText(optionsFilename);
            var options = optionsFileContent.Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var option in options)
            {
                try
                {
                    var nameAndValue = option.Split('=');
                    var name = nameAndValue.First().Trim();
                    var value = nameAndValue.Last().Trim();
                    var property = typeof(OptionsDto).GetProperty(name);
                    if (property.PropertyType.IsEnum)
                    {
                        var convertedValue = Enum.Parse(property.PropertyType, value);
                        property.SetValue(result, convertedValue);
                    }
                    else
                    {
                        var convertedValue = Convert.ChangeType(value, property.PropertyType);
                        property.SetValue(result, convertedValue);
                    }
                }
                catch { }
            }
            return result;
        }
    }
}
