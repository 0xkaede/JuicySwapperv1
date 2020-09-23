using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class GhoulOG : Form
    {
        public GhoulOG()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string PakFolder = Properties.Settings.Default.pakPath;

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath = Settings.Default.pakPath + "\\pakchunk10_s3-WindowsClient.pak";

            if (!File.Exists(filePath))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }

            else
            {
                CheckForIllegalCrossThreadCalls = false; int offsetskin1 = Settings.Default.offsetskin1; int offsetpick = Settings.Default.offsetpick; int offsetback = Settings.Default.offsetback; int offsetskin2 = Settings.Default.offsetskin2; int offsetemote = Settings.Default.offsetemote; int offsetlobby = Settings.Default.offsetlobby; int offsetpickmesh = Settings.Default.offsetpickmesh;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GhoulOGEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        private static byte[] Body = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,77,95,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,77,95,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,70,95,77,69,68,95,90,111,109,98,105,101,95,80,105,110,107,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,90,111,109,98,105,101,95,80,105,110,107,95,66,111,100,121,46,70,95,77,69,68,95,90,111,109,98,105,101,95,80,105,110,107,95,66,111,100,121,0,0,0,0,0,0,0,0
        };

        private static byte[] Color = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,67,104,97,114,97,99,116,101,114,67,111,108,111,114,83,119,97,116,99,104,101,115,47,83,107,105,110,47,70,95,66,76,75,95,76,117,110,97,46,70,95,66,76,75,95,76,117,110,97
        };

        private static byte[] Color1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,67,104,97,114,97,99,116,101,114,67,111,108,111,114,83,119,97,116,99,104,101,115,47,83,107,105,110,47,70,95,66,76,75,95,76,117,110,97,46,70,95,66,76,75,95,76,117,110,49
        };

        private static byte[] Hair = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] Hair1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,70,95,77,69,68,95,90,111,109,98,105,101,95,80,105,110,107,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,82,97,109,105,114,101,122,95,90,111,109,98,105,101,95,80,105,110,107,95,72,97,105,114,46,70,95,77,69,68,95,82,97,109,105,114,101,122,95,90,111,109,98,105,101,95,80,105,110,107,95,72,97,105,114
        };

        private static byte[] Head = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] Head1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,70,95,77,69,68,95,90,111,109,98,105,101,95,80,105,110,107,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,82,97,109,105,114,101,122,95,90,111,109,98,105,101,95,80,105,110,107,95,72,101,97,100,46,70,95,77,69,68,95,82,97,109,105,114,101,122,95,90,111,109,98,105,101,95,80,105,110,107,95,72,101,97,100
        };

        private static byte[] Glasses = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,71,108,97,115,115,101,115,47,77,97,116,101,114,105,97,108,115,47,77,73,95,65,117,114,111,114,97,71,108,111,119,95,71,108,97,115,115,101,115,46,77,73,95,65,117,114,111,114,97,71,108,111,119,95,71,108,97,115,115,101,115
        };

        private static byte[] Glasses1 = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,71,108,97,115,115,101,115,47,77,97,116,101,114,105,97,108,115,47,77,73,95,65,117,114,111,114,97,71,108,111,119,95,71,108,97,115,115,101,115,46,77,73,95,65,117,114,111,114,97,71,108,111,119,95,71,108,97,115,115,101,49
        };

        private static byte[] Shades = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,71,108,97,115,115,101,115,47,77,101,115,104,101,115,47,70,101,109,97,108,101,95,67,111,109,109,97,110,100,111,95,83,104,97,100,101,115,46,70,101,109,97,108,101,95,67,111,109,109,97,110,100,111,95,83,104,97,100,101,115
        };

        private static byte[] Shades1 = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,72,97,116,115,47,77,101,115,104,47,82,97,109,105,114,101,122,95,71,108,97,115,115,101,115,46,82,97,109,105,114,101,122,95,71,108,97,115,115,101,115,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] CID = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,101
        };

        private static byte[] CID1 = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,49,101
        };



        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int offsetskin = Settings.Default.offsetskin1;
            int offsetskin2 = Settings.Default.offsetskin2;
            int offsetlobby = Settings.Default.offsetlobby;


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream stream = File.OpenRead(bodypath);
                foreach (long num in Researcher.FindPosition(stream, 0, (long)offsetskin, GhoulOG.Body))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(num, SeekOrigin.Begin);
                    binaryWriter.Write(GhoulOG.Body1);
                    long offset = num + 726L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(GhoulOG.CID1);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body added!";
                }
                Stream stream2 = File.OpenRead(headpath);
                foreach (long num2 in Researcher.FindPosition(stream2, 0, (long)offsetskin2, GhoulOG.Hair))
                {
                    stream2.Close();
                    BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long offset2 = num2 - 288L;
                    binaryWriter2.BaseStream.Seek(offset2, SeekOrigin.Begin);
                    binaryWriter2.Write(GhoulOG.Color1);
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Color added!";
                    binaryWriter2.BaseStream.Seek(num2, SeekOrigin.Begin);
                    binaryWriter2.Write(GhoulOG.Hair1);
                    binaryWriter2.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Hair added!";
                    Settings.Default.GhoulOGEnabled = true;
                    Settings.Default.Save();
                }
                Stream stream3 = File.OpenRead(headpath);
                foreach (long offset3 in Researcher.FindPosition(stream3, 0, (long)offsetskin2, GhoulOG.Head))
                {
                    stream3.Close();
                    BinaryWriter binaryWriter3 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter3.BaseStream.Seek(offset3, SeekOrigin.Begin);
                    binaryWriter3.Write(GhoulOG.Head1);
                    binaryWriter3.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Head added!";
                }
                Stream stream4 = File.OpenRead(headpath);
                foreach (long offset4 in Researcher.FindPosition(stream4, 0, (long)offsetskin2, GhoulOG.Glasses))
                {
                    stream4.Close();
                    BinaryWriter binaryWriter4 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter4.BaseStream.Seek(offset4, SeekOrigin.Begin);
                    binaryWriter4.Write(GhoulOG.Glasses1);
                    binaryWriter4.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Glasses added!";
                }
                Stream stream5 = File.OpenRead(headpath);
                foreach (long offset5 in Researcher.FindPosition(stream5, 0, (long)offsetskin2, GhoulOG.Shades))
                {
                    stream5.Close();
                    BinaryWriter binaryWriter5 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter5.BaseStream.Seek(offset5, SeekOrigin.Begin);
                    binaryWriter5.Write(GhoulOG.Shades1);
                    binaryWriter5.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Shades added!";
                }
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double numb = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + numb + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream stream = File.OpenRead(bodypath);
                foreach (long num in Researcher.FindPosition(stream, 0, (long)offsetskin, GhoulOG.Body1))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(num, SeekOrigin.Begin);
                    binaryWriter.Write(GhoulOG.Body);
                    long offset = num + 726L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(GhoulOG.CID);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body removed!";
                }
                Stream stream2 = File.OpenRead(headpath);
                foreach (long num2 in Researcher.FindPosition(stream2, 0, (long)offsetskin2, GhoulOG.Hair1))
                {
                    stream2.Close();
                    BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long offset2 = num2 - 288L;
                    binaryWriter2.BaseStream.Seek(offset2, SeekOrigin.Begin);
                    binaryWriter2.Write(GhoulOG.Color);
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Color removed!";
                    binaryWriter2.BaseStream.Seek(num2, SeekOrigin.Begin);
                    binaryWriter2.Write(GhoulOG.Hair);
                    binaryWriter2.Close();
                    Settings.Default.GhoulOGEnabled = false;
                    Settings.Default.Save();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Hair removed!";
                }
                Stream stream3 = File.OpenRead(headpath);
                foreach (long offset3 in Researcher.FindPosition(stream3, 0, (long)offsetskin2, GhoulOG.Head1))
                {
                    stream3.Close();
                    BinaryWriter binaryWriter3 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter3.BaseStream.Seek(offset3, SeekOrigin.Begin);
                    binaryWriter3.Write(GhoulOG.Head);
                    binaryWriter3.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Head removed!";
                }
                Stream stream4 = File.OpenRead(headpath);
                foreach (long offset4 in Researcher.FindPosition(stream4, 0, (long)offsetskin2, GhoulOG.Glasses1))
                {
                    stream4.Close();
                    BinaryWriter binaryWriter4 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter4.BaseStream.Seek(offset4, SeekOrigin.Begin);
                    binaryWriter4.Write(GhoulOG.Glasses);
                    binaryWriter4.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Glasses removed!";
                }
                Stream stream5 = File.OpenRead(headpath);
                foreach (long offset5 in Researcher.FindPosition(stream5, 0, (long)offsetskin2, GhoulOG.Shades1))
                {
                    stream5.Close();
                    BinaryWriter binaryWriter5 = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter5.BaseStream.Seek(offset5, SeekOrigin.Begin);
                    binaryWriter5.Write(GhoulOG.Shades);
                    binaryWriter5.Close();
                    this.RichTextBoxInfo.Text = this.RichTextBoxInfo.Text + "\n[LOG] Shades removed!";
                }
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double numb = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + numb + " ms.");

            }
        }
    }
}
