using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace JuicyLauncher.Main.GUI
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin("Juicy Updater.exe");
            Environment.Exit(0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
