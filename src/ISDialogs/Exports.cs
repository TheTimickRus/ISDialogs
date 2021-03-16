using System.IO;
using System.Runtime.InteropServices;
using Ookii.Dialogs.Wpf;

namespace ISDialogs
{
    public class Exports
    {
        #region Task dialog



        #endregion

        #region Vista-style common file dialogs

        [DllExport(CallingConvention.StdCall)]
        public static string OpenFile(string filter)
        {
            var dialog = new VistaOpenFileDialog
            {
                AddExtension = true,
                Filter = filter != string.Empty
                    ? filter
                    : "All Files|*.*"
            };

            return dialog.ShowDialog() ?? false
                ? dialog.FileName
                : string.Empty;
        }

        [DllExport(CallingConvention.StdCall)]
        public static string SaveFile(string filename, string filter)
        {
            var dialog = new VistaSaveFileDialog
            {
                AddExtension = true,
                CreatePrompt = true,
                FileName = filename,
                Filter = filter != string.Empty
                    ? filter
                    : "All Files|*.*"
            };

            return dialog.ShowDialog() ?? false
                ? dialog.FileName
                : string.Empty;
        }

        [DllExport(CallingConvention.StdCall)]
        public static string OpenFolder(string folder, string description)
        {
            var dialog = new VistaFolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            if (description != string.Empty)
                dialog.Description = description;

            return dialog.ShowDialog() ?? false
                ? Path.Combine(dialog.SelectedPath, folder ?? string.Empty)
                : string.Empty;
        }

        #endregion
    }
}
