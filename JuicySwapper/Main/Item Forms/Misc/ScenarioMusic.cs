using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using System.ComponentModel;
using System.Threading.Tasks;

namespace JuicySwapper.Main.GUI
{
    public partial class ScenarioMusic : Form
    {
        public ScenarioMusic()
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

        private static byte[] Scenario = new byte[]
        {
            47, 71, 97, 109, 101, 47, 65, 116, 104, 101, 110, 97, 47, 83, 111, 117, 110, 100, 115, 47, 69, 109, 111, 116, 101, 115, 47, 75, 80, 111, 112, 68, 97, 110, 99, 101, 48, 51, 47, 69, 109, 111, 116, 101, 95, 75, 80, 111, 112, 68, 97, 110, 99, 101, 48, 51, 95, 76, 111, 111, 112, 46, 69, 109, 111, 116, 101, 95, 75, 80, 111, 112, 68, 97, 110, 99, 101, 48, 51, 95, 76, 111, 111, 112, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
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
                ReplaceBytes(filePath, 30265668, Scenario);
                RichTextBoxInfo.AppendText("[LOG] Music Pack added\n");
                Settings.Default.ScenarioMusicEnabled = true;
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
                ReplaceBytes(filePath, 30265668, Scenario);
                ReplaceBytes(filePath, 30265668, Coral);
                RichTextBoxInfo.AppendText("[LOG] Music Pack removed\n");
                Settings.Default.ScenarioMusicEnabled = false;
                Settings.Default.Save();
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("[LOG] Done! Reverted in " + num + " ms.");
            }
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ScenarioMusicEnabled == true)
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
                Stream str = Resources.Scenario;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Stop();
                previewButton.Text = "Play";
            }
            else
            {
                Stream str = Resources.Scenario;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
                player.Play();
                previewButton.Text = "Stop";
            }
        }

        private void ScenarioMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stream str = Resources.Scenario;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
            player.Stop();
        }
    }
}
