using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class RedNosed : Form
    {
        public RedNosed()
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
            if (Properties.Settings.Default.RedNosedEnabled == true)
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
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,66,82,95,82,101,105,110,100,101,101,114,47,77,97,116,101,114,105,97,108,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,52,95,114,101,105,110,100,101,101,114,46,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,52,95,114,101,105,110,100,101,101,114,0,0,0,0,0,0,0,0
        };

        private static byte[] Hair = new byte[] 
        { 
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] Hair1 = new byte[] 
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,101,100,95,72,101,97,100,95,48,49,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] HeadTex = new byte[] 
        { 
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] HeadTex1 = new byte[] 
        { 
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,101,100,95,72,101,97,100,95,48,49,47,77,97,116,101,114,105,97,108,115,47,82,101,105,110,100,101,101,114,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,114,101,105,110,100,101,101,114,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,114,101,105,110,100,101,101,114,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] Hat = new byte[] 
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,71,108,97,115,115,101,115,47,77,101,115,104,101,115,47,70,101,109,97,108,101,95,67,111,109,109,97,110,100,111,95,83,104,97,100,101,115,46,70,101,109,97,108,101,95,67,111,109,109,97,110,100,111,95,83,104,97,100,101,115
        };

        private static byte[] Hat1 = new byte[] 
        { 
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,72,97,116,115,47,77,101,115,104,47,82,101,105,110,100,101,101,114,95,72,97,116,46,82,101,105,110,100,101,101,114,95,72,97,116,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
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
                foreach (long num in Researcher.FindPosition(stream, 0, (long)offsetskin1, Body))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(num, SeekOrigin.Begin);
                    binaryWriter.Write(Body1);
                    long offset = num + 726L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(CID1);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body added!";
                }

                Stream fs2 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin2, Hair))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite)); ;
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Hair1);
                    Settings.Default.RedNosedEnabled = true;
                    Settings.Default.Save();
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Hair added!";
                }

                Stream fs3 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs3, 0, offsetskin2, HeadTex))
                {
                    fs3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadTex1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head added!";
                }


                Stream fs53 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs53, 0, offsetskin2, Hat))
                {
                    fs53.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Hat1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Hat  added!";
                }


                convertButton.Enabled = true;
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
                foreach (long num in Researcher.FindPosition(stream, 0, (long)offsetskin1, Body1))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(num, SeekOrigin.Begin);
                    binaryWriter.Write(Body);
                    long offset = num + 726L;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(CID);
                    binaryWriter.Close();
                    RichTextBox richTextBoxInfo2 = this.RichTextBoxInfo;
                    richTextBoxInfo2.Text += "\n[LOG] Body removed!";
                }

                Stream fs1 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetskin2, Hair1))
                {
                    fs1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Hair);
                    binaryWriter.Close();
                    Settings.Default.RedNosedEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Hair removed!";
                }

                Stream fs2 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetskin2, HeadTex1))
                {
                    fs2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(HeadTex);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Head removed!";
                }

                Stream fs53 = File.OpenRead(headpath);

                foreach (long s in Researcher.FindPosition(fs53, 0, offsetskin2, Hat1))
                {
                    fs53.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Hat);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Hat removed!";
                }


                convertButton.Enabled = true;
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double numb = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + numb + " ms.");

            }
        }
    }
}
