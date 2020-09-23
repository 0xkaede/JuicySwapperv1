using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Ruby : Form
    {
        public Ruby()
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
            if (Properties.Settings.Default.RubyEnabled == true)
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
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,47,77,101,115,104,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,46,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110
        };

        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,47,77,101,115,104,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,46,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] BodyPart = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,47,77,101,115,104,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,95,65,110,105,109,66,112,46,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,95,65,110,105,109,66,112,95,67
        };

        private static byte[] BodyPart1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,47,77,101,115,104,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,65,110,105,109,66,80,46,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,65,110,105,109,66,80,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] Head = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,95,70,97,99,101,65,99,99,46,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,95,70,97,99,101,65,99,99
        };

        private static byte[] Head1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,70,97,99,101,65,99,99,46,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,70,97,99,101,65,99,99,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadPart = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,95,72,117,110,116,101,114,95,70,97,115,104,105,111,110,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,84,114,101,97,115,117,114,101,72,117,110,116,101,114,70,97,115,104,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,46,70,95,77,69,68,95,84,114,101,97,115,117,114,101,72,117,110,116,101,114,70,97,115,104,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,95,67
        };

        private static byte[] HeadPart1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,46,70,95,77,69,68,95,83,116,114,101,101,116,95,70,97,115,104,105,111,110,95,82,101,100,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,95,67,0,0,0,0,0
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
            CheckForIllegalCrossThreadCalls = false; int offsetskin1 = Settings.Default.offsetskin1; int offsetpick = Settings.Default.offsetpick; int offsetback = Settings.Default.offsetback; int offsetskin2 = Settings.Default.offsetskin2; int offsetemote = Settings.Default.offsetemote; int offsetlobby = Settings.Default.offsetlobby; int offsetpickmesh = Settings.Default.offsetpickmesh;



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
                foreach (long numb in Researcher.FindPosition(stream, 0, (long)offsetskin1, Body))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(Body1);
                    long offset = numb + 988L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(CID1);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body 1/2 added";
                }

                Stream fs1 = File.OpenRead(bodypath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetskin1, BodyPart))
                {
                    fs1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BodyPart1);
                    binaryWriter.Close();
                    Settings.Default.RubyEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Body 2/2 added";
                }

                Stream fs2 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin2, Head))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Head1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 1/2 added";
                }

                Stream fs22 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs22, 0, offsetskin2, HeadPart))
                {
                    fs22.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadPart1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 2/2 added";
                }

                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream stream = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(stream, 0, (long)offsetskin1, Body1))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(Body);
                    long offset = numb + 988L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(CID);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body 1/2 removed!";
                }

                Stream fs1 = File.OpenRead(bodypath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetskin1, BodyPart1))
                {
                    fs1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BodyPart);
                    binaryWriter.Close();
                    Settings.Default.RubyEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Body 2/2 removed";
                }

                Stream fs2 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin2, Head1))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Head);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 1/2 removed";
                }

                Stream fs22 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs22, 0, offsetskin2, HeadPart1))
                {
                    fs22.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadPart);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 2/2 removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
