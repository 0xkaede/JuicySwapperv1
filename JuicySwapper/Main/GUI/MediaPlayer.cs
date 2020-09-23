using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectPakPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            musicPathTextbox.Text = Properties.Settings.Default.musicPath;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            musicPathTextbox.Text = openFileDialog1.FileName;
            Properties.Settings.Default.musicPath = musicPathTextbox.Text;
            Properties.Settings.Default.musicName = openFileDialog1.SafeFileName;
            Properties.Settings.Default.Save();
            musicPathTextbox.Text = Properties.Settings.Default.musicPath;
        }
    }
}
