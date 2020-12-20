using System;
using System.Windows.Forms;
using Logging;

namespace ControllApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.InitLogger();
            Logger.Log.Info($"Start {typeof(Program)}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
