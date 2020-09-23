using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class LoveWings : Form
    {
        public LoveWings()
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
            if (Properties.Settings.Default.LoveWingsEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        private static byte[] Mesh = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,101,100,95,67,111,109,109,97,110,100,111,95,67,117,112,105,100,47,83,107,105,110,115,47,73,99,101,47,77,97,116,101,114,105,97,108,115,47,77,95,77,101,100,95,83,111,108,100,105,101,114,95,67,117,112,105,100,95,87,105,110,103,115,46,77,95,77,101,100,95,83,111,108,100,105,101,114,95,67,117,112,105,100,95,87,105,110,103,115
        };

        private static byte[] Mesh1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,101,100,95,67,111,109,109,97,110,100,111,95,67,117,112,105,100,47,77,97,116,101,114,105,97,108,115,47,77,95,77,101,100,95,83,111,108,100,105,101,114,95,67,117,112,105,100,95,87,105,110,103,115,46,77,95,77,101,100,95,83,111,108,100,105,101,114,95,67,117,112,105,100,95,87,105,110,103,115,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] BID = new byte[]
        {
            66,73,68,95,49,54,56,95,67,117,112,105,100,87,105,110,116,101,114,77,97,108,101,46,66,73,68,95,49,54,56,95,67,117,112,105,100,87,105,110,116,101,114,77,97,108,101
        };

        private static byte[] BID1 = new byte[]
        {
            66,73,68,95,48,50,50,95,67,117,112,105,100,46,66,73,68,95,48,50,50,95,67,117,112,105,100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int Offset_Skin_Body = Settings.Default.offsetskin1;
            int offsetpick = Settings.Default.offsetpick;
            int offsetback = Settings.Default.offsetback;
            int Offset_Skin_Head = Settings.Default.offsetskin2;
            int offsetemote = Settings.Default.offsetemote;
            int offsetlobby = Settings.Default.offsetlobby;
            int offsetpickmesh = Settings.Default.offsetpickmesh;
            //int offsetid = 525000000;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string bodypath = Settings.Default.pakPath + Settings.Default.bodypathAPI;
            string headpath = Settings.Default.pakPath + Settings.Default.headpathAPI;
            string pickaxepath = Settings.Default.pakPath + Settings.Default.pickaxepathAPI;
            string pickaxesoundpath = Settings.Default.pakPath + Settings.Default.pickaxesoundpathAPI;
            string backblingpath = Settings.Default.pakPath + Settings.Default.backblingpathAPI;
            string emotespath = Settings.Default.pakPath + Settings.Default.emotespathAPI;
            string idpath = Settings.Default.pakPath + Settings.Default.idpathAPI;
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                RichTextBoxInfo.Text += "[LOG] Starting...";


                Stream fs1 = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetback, Mesh))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(Mesh1);
                    binaryWrite.Close();
                    Settings.Default.LoveWingsEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh added";
                }

                Stream fs2 = File.OpenRead(idpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetlobby, BID))
                {
                    fs2.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(idpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(BID1);
                    binaryWrite.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Backbling ID added";
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

                Stream fs1 = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetback, Mesh1))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(Mesh);
                    binaryWrite.Close();
                    Settings.Default.LoveWingsEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh removed";
                }

                Stream fs2 = File.OpenRead(idpath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetlobby, BID1))
                {
                    fs2.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(idpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(BID);
                    binaryWrite.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Backbling ID  removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
