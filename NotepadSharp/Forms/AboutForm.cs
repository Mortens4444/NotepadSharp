using System.Diagnostics;
using System.Windows.Forms;

namespace NotepadSharp.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void authorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://w3.hdsnet.hu/mortens");
        }
    }
}
