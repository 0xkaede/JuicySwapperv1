using JuicySwapper.Main.GUI;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var version = "1.0.1.1";
            if (version != $"{Application.ProductVersion}")
            {
                new Update().ShowDialog();
            }
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Juicy Swapper cannot be run from WinRAR! Please extract to a folder and try again.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                //Juicy.DevModeCheck();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Loader());
            }
        }
    }
}
