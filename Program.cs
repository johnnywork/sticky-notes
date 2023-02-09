using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmMain frmMain = new frmMain();
            frmMain.WorkingFolder = extractRootFolder(Environment.GetCommandLineArgs());

            Application.Run(frmMain);
        }

        static string extractRootFolder(string[] args)
        {
            string switchArgument = "--root=";

            foreach (string arg in args)
            {
                if (arg.StartsWith(switchArgument))
                {
                    return arg.Replace(switchArgument, "");
                }
            }

            return null;
        }
    }
}
