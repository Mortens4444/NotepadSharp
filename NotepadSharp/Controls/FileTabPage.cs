using NotepadSharp.FileHandling;
using NotepadSharp.Interfaces;
using NotepadSharp.Options;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadSharp.Controls
{
    public class FileTabPage : TabPage
    {
        public FileRichTextBox TextBox { get; private set; }

        public FileDetails FileDetails
        {
            get
            {
                return TextBox.FileDetails;
            }
            set
            {
                TextBox.FileDetails = value;
            }
        }

        private readonly IFileWriter fileWriter;

        public FileTabPage(IFileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public void Initialize(FileDetails fileDetails, int tabNumber)
        {
            Location = new Point(4, 22);
            Name = $"Tab{tabNumber}";
            Padding = new Padding(3);
            Size = new Size(711, 375);
            TabIndex = 0;
            Text = fileDetails?.ShowFileName ?? $"New Document {tabNumber}";
            UseVisualStyleBackColor = true;
            Visible = false;

            TextBox = new FileRichTextBox(tabNumber);
            Controls.Add(TextBox);
            TextBox.FileDetails = fileDetails;
        }

        public void SaveFile(OptionsDto options)
        {
            if (FileDetails != null)
            {
                fileWriter.CreateOrOverwriteFile(FileDetails.FileName, TextBox.Text);
            }
            else
            {
                var saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileWriter.CreateOrOverwriteFile(saveFileDialog.FileName, TextBox.Text);
                    // TODO: Add in correct position, not to the end
                    options.AppendToOpenedFiles(saveFileDialog.FileName);
                    FileDetails = new FileDetails(saveFileDialog.FileName);
                    Text = FileDetails.ShowFileName;
                }
            }
        }

        public void RefreshScrollBars(bool wrapLongLines)
        {
            TextBox.RefreshScrollBars(wrapLongLines);
        }
    }
}
