using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Dismal : Form
    {
        public Dismal()
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
            if (Properties.Settings.Default.DismalEnabled == true)
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
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,67,97,112,101,115,47,77,95,77,69,68,95,70,111,114,116,110,105,116,101,95,68,74,47,77,101,115,104,101,115,47,70,95,77,69,68,95,70,111,114,116,110,105,116,101,95,68,74,95,66,97,99,107,112,97,99,107,46,70,95,77,69,68,95,70,111,114,116,110,105,116,101,95,68,74,95,66,97,99,107,112,97,99,107
        };

        private static byte[] Mesh1 = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,67,97,112,101,115,47,77,95,77,69,68,95,80,108,97,103,117,101,95,67,97,112,101,47,77,101,115,104,101,115,47,77,95,77,69,68,95,80,108,97,103,117,101,95,67,97,112,101,95,69,120,112,111,114,116,46,77,95,77,69,68,95,80,108,97,103,117,101,95,67,97,112,101,95,69,120,112,111,114,116,0,0,0,0
        };

        private static byte[] BID = new byte[]
        {
            66,73,68,95,49,50,51,95,70,111,114,116,110,105,116,101,68,74,46,66,73,68,95,49,50,51,95,70,111,114,116,110,105,116,101,68,74
        };

        private static byte[] BID1 = new byte[]
        {
            66,73,68,95,49,50,55,95,80,108,97,103,117,101,77,97,108,101,46,66,73,68,95,49,50,55,95,80,108,97,103,117,101,77,97,108,101
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
                    Settings.Default.BattleShroudEnabled = true;
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
                    Settings.Default.BattleShroudEnabled = false;
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
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Backbling ID removed";
                }

                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
