using Ninject.Modules;
using NotepadSharp.FileHandling;
using NotepadSharp.Forms;
using NotepadSharp.Interfaces;
using NotepadSharp.Options;
using NotepadSharp.Other;

namespace NotepadSharp
{
    public class DefaultNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IFileDetails>().To<FileDetails>();
            Kernel.Bind<IFileReader>().To<FileReader>();
            Kernel.Bind<IFileWriter>().To<FileWriter>();
            Kernel.Bind<IOptionsFileWriter>().To<OptionsFileWriter>();
            Kernel.Bind<IOptionsHandler>().To<OptionsHandler>();
            Kernel.Bind<IFileTabPageFactory>().To<FileTabPageFactory>();
            
            Kernel.Bind<MainForm>().ToSelf();
        }
    }
}
