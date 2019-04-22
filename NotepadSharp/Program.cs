using Ninject;
using NotepadSharp.Forms;
using System;
using System.Windows.Forms;

namespace NotepadSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kernel = new StandardKernel();
            kernel.Load<DefaultNinjectModule>();
            var mainForm = kernel.Get<MainForm>();
            Application.Run(mainForm);
        }
    }
}
