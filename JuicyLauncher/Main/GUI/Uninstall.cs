using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace JuicyLauncher.Main.GUI
{
    public partial class Uninstall : Form
    {
        public Uninstall()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DevMode_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Process.Start("Uninstall.exe");
            Environment.Exit(0);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
