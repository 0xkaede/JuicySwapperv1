using JuicyIDSwapper.Main.GUI;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicyIDSwapper
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Version = new WebClient().DownloadString("https://juicyswapper.xyz/api/id/version");
            if (Version != $"{Application.ProductVersion}")
            {
                new Update().ShowDialog();
            }
            if (Path.GetFileName(Path.GetDirectoryName(Environment.CurrentDirectory)) == "Temp")
            {
                MessageBox.Show("Juicy ID Swapper cannot be run from WinRAR! Please extract to a folder and try again.", "Juicy ID Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                Juicy.DevModeCheck();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Loader());
            }
        }
    }
}
