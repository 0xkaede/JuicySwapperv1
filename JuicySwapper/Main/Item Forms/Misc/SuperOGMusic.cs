using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class SuperOGMusic : Form
    {
        public SuperOGMusic()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        string PakFolder = Settings.Default.pakPath;

        private static byte[] OG = new byte[]
        {
            47,71,97,109,101,47,83,111,117,110,100,115,47,70,111,114,116,95,77,117,115,105,99,47,77,101,110,117,47,102,111,114,116,110,105,116,101,95,76,111,103,105,110,95,83,99,114,101,101,110,46,102,111,114,116,110,105,116,101,95,76,111,103,105,110,95,83,99,114,101,101,110,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] Coral = new byte[]
        {
            47, 71, 97, 109, 101, 47, 65, 116, 104, 101, 110, 97, 47, 83, 111, 117, 110, 100, 115, 47, 77, 117, 115, 105, 99, 80, 97, 99, 107, 115, 47, 77, 117, 115, 105, 99, 80, 97, 99, 107, 95, 67, 111, 114, 97, 108, 67, 114, 117, 105, 115, 101, 114, 95, 66, 80, 77, 95, 56, 52, 95, 76, 79, 79, 80, 46, 77, 117, 115, 105, 99, 80, 97, 99, 107, 95, 67, 111, 114, 97, 108, 67, 114, 117, 105, 115, 101, 114, 95, 66, 80, 77, 95, 56, 52, 95, 76, 79, 79, 80
        };

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (convertButton.Text == "Convert")
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string filePath = PakFolder + "/pakchunk10_s9-WindowsClient.pak";
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.AppendText("[LOG] Starting...\n");
                ReplaceBytes(filePath, 30265668, Coral);
                ReplaceBytes(filePath, 30265668, OG);
                RichTextBoxInfo.AppendText("[LOG] Music Pack added\n");
                Settings.Default.SuperOGEnabled = true;
                Settings.Default.Save();
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string filePath = PakFolder + "/pakchunk10_s9-WindowsClient.pak";
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.AppendText("[LOG] Starting...\n");
                ReplaceBytes(filePath, 30265668, OG);
                ReplaceBytes(filePath, 30265668, Coral);
                RichTextBoxInfo.AppendText("[LOG] Music Pack removed\n");
                Settings.Default.SuperOGEnabled = false;
                Settings.Default.Save();
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("[LOG] Done! Reverted in " + num + " ms.");
            }
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SuperOGEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (previewButton.Text == "Stop")
            {
                Stream str = Resources.SuperOG;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Stop();
                previewButton.Text = "Play";
            }
            else
            {
                Stream str = Resources.SuperOG;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play(); 
                previewButton.Text = "Stop";
            }
        }

        private void SuperOGMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stream str = Resources.SuperOG;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
            player.Stop();
        }
    }
}
