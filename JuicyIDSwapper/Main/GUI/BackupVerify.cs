using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class BackupVerify : Form
    {
        public BackupVerify()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdvancedSettings_Load(object sender, EventArgs e)
        {

        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            string pathto0 = Properties.Settings.Default.pakPath + "\\pakchunk0-WindowsClient.pak";
            if (File.Exists(pathto0))
            {
                backupWorker.RunWorkerAsync();
            }
            else
            {
                new PakError().ShowDialog();
            }
        }

        private void backupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string pathto0 = Home.GetPaksFolder + "\\pakchunk0-WindowsClient.pak";
            try
            {
                if (Directory.Exists("IDPakBackup"))
                {
                    if (File.Exists("IDPakBackup/pakchunk0-WindowsClient.pak"))
                    {
                        File.Delete("IDPakBackup/pakchunk0-WindowsClient.pak");
                    }
                    Directory.Delete("IDPakBackup");
                }

                richTextBox1.Text += "[" + DateTime.Now + "] Creating Pak Backup folder...\n";

                Directory.CreateDirectory("IDPakBackup");

                richTextBox1.Text += "[" + DateTime.Now + "] Pak Backup folder created!\n";

                richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 1/1\n";

                File.Copy(pathto0, "IDPakBackup/pakchunk0-WindowsClient.pak");

                richTextBox1.Text += "[" + DateTime.Now + "] Copied 1/1 game files!\n";

                richTextBox1.Text += "[" + DateTime.Now + "] Successfully created backup of your game files!\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("[" + DateTime.Now + "] Error! Please contact the Juicy ID Swapper support team! \nException:" + ex, "Juicy ID Swapper - Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void verifyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string pathto0 = Home.GetPaksFolder + "\\pakchunk0-WindowsClient.pak";
            richTextBox1.Text = "[" + DateTime.Now + "] Starting...\n";
            try
            {
                if (File.Exists("IDPakBackup/pakchunk0-WindowsClient.pak"))
                {
                    if (File.Exists(pathto0))
                    {
                        File.Delete(pathto0);
                    }

                    richTextBox1.Text += "[" + DateTime.Now + "] Pak Backup folder detected!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 1/1\n";

                    File.Copy("IDPakBackup/pakchunk10-WindowsClient.pak", pathto0);

                    richTextBox1.Text += "[" + DateTime.Now + "] Copied 1/1 game files!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Successfully verified your game files!\n";

                    File.Delete("IDPakBackup/pakchunk0-WindowsClient.pak");

                    Directory.Delete("IDPakBackup");
                }
                else
                {
                    MessageBox.Show("[" + DateTime.Now + "] Pak Backup folder found, but no .pak files exist!", "Juicy ID Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[" + DateTime.Now + "] Error! Please contact the Juicy ID Swapper support team! \nException:" + ex, "Juicy ID Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
