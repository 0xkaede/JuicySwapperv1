using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Punchy : Form
    {
        public Punchy()
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
            string filePath9 = Settings.Default.pakPath + "\\pakchunk10_s9-WindowsClient.pak";

            if (!File.Exists(filePath9))
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
            if (Properties.Settings.Default.PunchyEnabled == true)
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
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,101,115,104,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,46,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,82,101,100,82,105,100,105,110,103,72,111,111,100,95,80,114,111,116,111,95,77,69,83,72
        };

        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,47,77,101,115,104,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,46,70,95,77,69,68,95,80,117,110,99,104,121,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] BodyAnim = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,101,115,104,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,82,101,100,82,105,100,105,110,103,72,111,111,100,95,80,114,111,116,111,95,77,69,83,72,95,83,107,101,108,101,116,111,110,95,65,66,80,46,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,82,101,100,82,105,100,105,110,103,72,111,111,100,95,80,114,111,116,111,95,77,69,83,72,95,83,107,101,108,101,116,111,110,95,65,66,80,95,67
        };

        private static byte[] BodyAnim1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,47,77,101,115,104,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,95,65,110,105,109,66,112,46,70,95,77,69,68,95,80,117,110,99,104,121,95,65,110,105,109,66,112,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadNull = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,97,116,101,114,105,97,108,115,47,77,73,95,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,72,101,97,100,46,77,73,95,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,72,101,97,100
        };

        private static byte[] HeadNull1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,97,116,101,114,105,97,108,115,47,77,73,95,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,72,101,97,100,46,77,73,95,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,95,72,101,97,49
        };

        private static byte[] HeadMesh = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,47,77,101,115,104,101,115,47,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,46,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49
        };

        private static byte[] HeadMesh1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,69,68,95,67,65,85,95,74,97,110,101,95,72,101,97,100,95,48,49,47,77,101,115,104,101,115,47,70,95,77,69,68,95,67,65,85,95,74,97,110,101,95,72,101,97,100,95,48,49,46,70,95,77,69,68,95,67,65,85,95,74,97,110,101,95,72,101,97,100,95,48,49,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadMat = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,82,101,100,82,105,100,105,110,103,46,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,82,101,100,82,105,100,105,110,103
        };

        private static byte[] HeadMat1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,69,68,95,65,83,78,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,47,83,107,105,110,47,70,95,77,69,68,95,80,117,110,99,104,121,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,80,117,110,99,104,121,95,72,101,97,100,46,70,95,77,69,68,95,80,117,110,99,104,121,95,72,101,97,100,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadEye = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,101,115,104,47,70,101,109,97,108,101,95,77,101,100,105,117,109,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,69,121,101,108,97,115,104,101,115,95,69,120,112,111,114,116,46,70,101,109,97,108,101,95,77,101,100,105,117,109,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,69,121,101,108,97,115,104,101,115,95,69,120,112,111,114,116,95,69,89,69,76,65,83,72,69,83,95,77,69,83,72
        };

        private static byte[] HeadEye1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,80,117,110,99,104,121,95,70,97,99,101,65,99,99,46,70,95,77,69,68,95,80,117,110,99,104,121,95,70,97,99,101,65,99,99,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,00,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadAnim = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,82,101,100,82,105,100,105,110,103,47,77,101,115,104,47,70,101,109,97,108,101,95,77,101,100,105,117,109,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,108,97,115,104,101,95,83,107,101,108,101,116,111,110,95,65,66,80,46,70,101,109,97,108,101,95,77,101,100,105,117,109,95,83,116,97,114,102,105,115,104,95,72,101,97,100,95,48,49,95,108,97,115,104,101,95,83,107,101,108,101,116,111,110,95,65,66,80,95,67
        };

        private static byte[] HeadAnim1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,80,117,110,99,104,121,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,80,117,110,99,104,121,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,46,70,95,77,69,68,95,80,117,110,99,104,121,95,70,97,99,101,65,99,99,95,65,110,105,109,66,112,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] offsetr = new byte[]
        {
            194,59,3,38,0,0,0,0,54,7,0,0,61,8,0,0,0,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,58,7,0,0,67
        };

        private static byte[] Gender = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,101
        };

        private static byte[] Gender1 = new byte[]
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
                    long offset = numb + 976L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender1);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body 1/2 added";

                }

                Stream fs2 = File.OpenRead(bodypath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin1, BodyAnim))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Body 2/2 added";
                }

                Stream fs4 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs4, 0, offsetskin2, HeadNull))
                {
                    fs4.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long HeadMeshset = s + 240;
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadNull1);
                    binaryWriter.BaseStream.Seek(HeadMeshset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadMesh1);
                    binaryWriter.Close();
                    Settings.Default.PunchyEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 1/3 added";
                }

                Stream fs5 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs5, 0, offsetskin2, HeadMat))
                {
                    fs5.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadMat1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 2/3 added";
                }

                Stream fs6 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs6, 0, offsetskin2, offsetr))
                {
                    fs6.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long eyeset = s + 237;
                    long animset = s + 546;
                    binaryWriter.BaseStream.Seek(eyeset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadEye1);
                    binaryWriter.BaseStream.Seek(animset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadAnim1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 3/3 added";
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
                    long offset = numb + 976L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body 1/2 removed";

                }

                Stream fs2 = File.OpenRead(bodypath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin1, BodyAnim1))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim);
                    binaryWriter.Close();
                    Settings.Default.PunchyEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Body 2/2 removed";
                }

                Stream fs4 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs4, 0, offsetskin2, HeadNull1))
                {
                    fs4.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long HeadMeshset = s + 240;
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadNull);
                    binaryWriter.BaseStream.Seek(HeadMeshset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadMesh);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 1/3 removed";
                }

                Stream fs5 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs5, 0, offsetskin2, HeadMat1))
                {
                    fs5.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadMat);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 2/3 removed";
                }

                Stream fs6 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs6, 0, offsetskin2, offsetr))
                {
                    fs6.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    long eyeset = s + 237;
                    long animset = s + 546;
                    binaryWriter.BaseStream.Seek(eyeset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadEye);
                    binaryWriter.BaseStream.Seek(animset + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadAnim);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head 3/3 removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
