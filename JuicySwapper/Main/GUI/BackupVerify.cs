using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
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
            string pathto10s9 = Properties.Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";
            string pathto0 = Properties.Settings.Default.pakPath + "\\pakchunk0-WindowsClient.pak";
            if (File.Exists(pathto0) && File.Exists(pathto10s9))
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
            string pathto10s8 = Home.GetPaksFolder + "\\pakchunk10_s8-WindowsClient.pak";
            string pathto10s9 = Home.GetPaksFolder + "\\pakchunk10_s9-WindowsClient.pak";
            string pathto10 = Home.GetPaksFolder + "\\pakchunk10-WindowsClient.pak";
            string pathto0 = Home.GetPaksFolder + "\\pakchunk0-WindowsClient.pak";
            try
            {
                if (Directory.Exists("PakBackup"))
                {
                    if (File.Exists("PakBackup/pakchunk10-WindowsClient.pak"))
                    {
                        File.Delete("PakBackup/pakchunk10-WindowsClient.pak");
                    }
                    if (File.Exists("PakBackup/pakchunk10_s9-WindowsClient.pak"))
                    {
                        File.Delete("PakBackup/pakchunk10_s9-WindowsClient.pak");
                    }
                    if (File.Exists("PakBackup/pakchunk10_s8-WindowsClient.pak"))
                    {
                        File.Delete("PakBackup/pakchunk10_s8-WindowsClient.pak");
                    }
                    Directory.Delete("PakBackup");
                }

                richTextBox1.Text += "[" + DateTime.Now + "] Creating Pak Backup folder...\n";

                Directory.CreateDirectory("PakBackup");

                richTextBox1.Text += "[" + DateTime.Now + "] Pak Backup folder created!\n";


                richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 1/3\n";

                File.Copy(pathto10, "PakBackup/pakchunk10-WindowsClient.pak");

                richTextBox1.Text += "[" + DateTime.Now + "] Copied 1/4 game files!\n";

                richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 2/3\n";

                File.Copy(pathto10s9, "PakBackup/pakchunk10_s9-WindowsClient.pak");

                richTextBox1.Text += "[" + DateTime.Now + "] Copied 2/4 game files!\n";

                richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 3/3\n";

                File.Copy(pathto10s8, "PakBackup/pakchunk10_s8-WindowsClient.pak");

                richTextBox1.Text += "[" + DateTime.Now + "] Copied 3/4 game files!\n";

                File.Copy(pathto0, "PakBackup/pakchunk0-WindowsClient.pak");

                richTextBox1.Text += "[" + DateTime.Now + "] Copied 4/4 game files!\n";


                richTextBox1.Text += "[" + DateTime.Now + "] Successfully created backup of your game files!\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("[" + DateTime.Now + "] Error! Please contact the Juicy Swapper support team! \nException:" + ex, "Juicy Swapper - Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string pathto10s9 = Home.GetPaksFolder + "\\pakchunk10_s9-WindowsClient.pak";
            string pathto10s8 = Home.GetPaksFolder + "\\pakchunk10_s8-WindowsClient.pak";
            string pathto10 = Home.GetPaksFolder + "\\pakchunk10-WindowsClient.pak";
            string pathto0 = Home.GetPaksFolder + "\\pakchunk0-WindowsClient.pak";
            richTextBox1.Text = "[" + DateTime.Now + "] Starting...\n";
            try
            {
                if (File.Exists("PakBackup/pakchunk10-WindowsClient.pak") && File.Exists("PakBackup/pakchunk10_s8-WindowsClient.pak"))
                {
                    if (File.Exists(pathto10))
                    {
                        File.Delete(pathto10);
                    }
                    if (File.Exists(pathto10s9))
                    {
                        File.Delete(pathto10s9);
                    }
                    if (File.Exists(pathto10s8))
                    {
                        File.Delete(pathto10s8);
                    }
                    if (File.Exists(pathto0))
                    {
                        File.Delete(pathto0);
                    }

                    richTextBox1.Text += "[" + DateTime.Now + "] Pak Backup folder detected!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 1/3\n";

                    File.Copy("PakBackup/pakchunk10-WindowsClient.pak", pathto10);

                    richTextBox1.Text += "[" + DateTime.Now + "] Copied 1/4 game files!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 2/3\n";

                    File.Copy("PakBackup/pakchunk10_s8-WindowsClient.pak", pathto10s8);

                    richTextBox1.Text += "[" + DateTime.Now + "] Copied 2/4 game files!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Copying game files... 3/3\n";

                    File.Copy("PakBackup/pakchunk10_s9-WindowsClient.pak", pathto10s9);

                    richTextBox1.Text += "[" + DateTime.Now + "] Copied 3/4 game files!\n";

                    File.Copy("PakBackup/pakchunk0-WindowsClient.pak", pathto0);

                    richTextBox1.Text += "[" + DateTime.Now + "] Copied 4/4 game files!\n";

                    richTextBox1.Text += "[" + DateTime.Now + "] Successfully verified your game files!\n";

                    File.Delete("PakBackup/pakchunk0-WindowsClient.pak");
                    File.Delete("PakBackup/pakchunk10-WindowsClient.pak");
                    File.Delete("PakBackup/pakchunk10_s9-WindowsClient.pak");
                    File.Delete("PakBackup/pakchunk10_s8-WindowsClient.pak");

                    Directory.Delete("PakBackup");
                }
                else
                {
                    MessageBox.Show("[" + DateTime.Now + "] Pak Backup folder found, but no .pak files exist!", "Juicy Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[" + DateTime.Now + "] Error! Please contact the Juicy Swapper support team! \nException:" + ex, "Juicy Swapper - Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
