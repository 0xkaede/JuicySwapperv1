using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class AdvancedSettings : Form
    {
        public AdvancedSettings()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            new BackupVerify().ShowDialog();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult restart = MessageBox.Show("Are you sure you want to restart?", "Juicy Swapper", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restart == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
            else
            {
            }
        }

        private void openPakButton_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = @"c:\windows\system32\explorer.exe",
                Arguments = Properties.Settings.Default.pakPath
            };
            Process.Start(psi);
        }

        private void checkPakButton_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (File.Exists(Properties.Settings.Default.pakPath + $"\\pakchunk10_s8-WindowsClient.pak"))
            {
                num++;
            }
            if (File.Exists(Properties.Settings.Default.pakPath + $"\\pakchunk10_s9-WindowsClient.pak"))
            {
                num++;
            }
            if (File.Exists(Properties.Settings.Default.pakPath + $"\\pakchunk10-WindowsClient.pak"))
            {
                num++;
            }
            if (num == 3)
            {
                MessageBox.Show("Successfully found pakchunk10_s8, pakchunk10_s9 and pakchunk10!", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (num < 3)
            {
                if (num == 0 && File.Exists(Properties.Settings.Default.pakPath + $"\\pakchunk10-WindowsClient.pak"))
                {
                    MessageBox.Show("You have selected the right paks folder, however one of your pak files seem to be missing. Please verify your game via. the Epic Games Launcher.", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show("Could not find pak files! Please select the correct directory using the pak file selector", "Juicy Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fortniteButton_Click(object sender, EventArgs e)
        {
            new FortniteLaunch().ShowDialog();
            StringBuilder stringBuilder = new StringBuilder(Properties.Settings.Default.pakPath, 1000);
            stringBuilder.Replace("Content\\Paks", "Binaries\\Win64\\");
            Process.Start(stringBuilder.ToString() + "FortniteClient-Win64-Shipping_EAC.exe");
            Properties.Settings.Default.openfortnite = true;
            Environment.Exit(0);
        }
    }
}
