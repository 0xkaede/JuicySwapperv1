using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace JuicyLauncher.Main.GUI
{
    public partial class FileError : Form
    {
        public FileError()
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
            SystemSounds.Hand.Play();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
