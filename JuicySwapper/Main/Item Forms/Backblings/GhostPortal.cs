using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class GhostPortal : Form
    {
        public GhostPortal()
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
            if (Properties.Settings.Default.GhostPortalEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

        private static byte[] Mesh = new byte[149]
        {
           47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,66,97,99,107,112,97,99,107,95,70,95,77,69,68,95,83,116,114,101,101,116,95,82,97,99,101,114,95,68,114,105,102,116,95,82,101,109,105,120,47,77,101,115,104,47,70,95,77,69,68,95,83,116,114,101,101,116,95,82,97,99,101,114,95,68,114,105,102,116,95,82,101,109,105,120,95,80,97,99,107,46,70,95,77,69,68,95,83,116,114,101,101,116,95,82,97,99,101,114,95,68,114,105,102,116,95,82,101,109,105,120,95,80,97,99,107
        };

        private static byte[] Mesh1 = new byte[149]
        {
           47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,77,95,77,69,68,95,71,104,111,115,116,80,111,114,116,97,108,95,66,97,99,107,112,97,99,107,47,77,101,115,104,101,115,47,66,97,99,107,112,97,99,107,95,77,97,108,101,95,67,111,109,109,97,110,100,111,95,71,104,111,115,116,80,111,114,116,97,108,46,66,97,99,107,112,97,99,107,95,77,97,108,101,95,67,111,109,109,97,110,100,111,95,71,104,111,115,116,80,111,114,116,97,108,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] MeshFX = new byte[151]
        {
           47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,66,97,99,107,112,97,99,107,95,70,95,77,69,68,95,83,116,114,101,101,116,95,82,97,99,101,114,95,68,114,105,102,116,95,82,101,109,105,120,47,70,88,47,67,67,80,77,95,66,97,99,107,112,97,99,107,95,83,116,114,101,101,116,82,97,99,101,114,95,68,114,105,102,116,82,101,109,105,120,46,67,67,80,77,95,66,97,99,107,112,97,99,107,95,83,116,114,101,101,116,82,97,99,101,114,95,68,114,105,102,116,82,101,109,105,120,95,67
        };

        private static byte[] MeshFX1 = new byte[151]
        {
           47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,77,95,77,69,68,95,71,104,111,115,116,80,111,114,116,97,108,95,66,97,99,107,112,97,99,107,47,70,88,47,67,67,80,77,95,77,69,68,95,71,104,111,115,116,80,111,114,116,97,108,95,66,97,99,107,112,97,99,107,95,70,88,46,67,67,80,77,95,77,69,68,95,71,104,111,115,116,80,111,114,116,97,108,95,66,97,99,107,112,97,99,107,95,70,88,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] BID = new byte[]
        {
            66,73,68,95,51,49,57,95,83,116,114,101,101,116,82,97,99,101,114,68,114,105,102,116,82,101,109,105,120,46,66,73,68,95,51,49,57,95,83,116,114,101,101,116,82,97,99,101,114,68,114,105,102,116,82,101,109,105,120
        };

        private static byte[] BID1 = new byte[]
        {
            66,73,68,95,49,48,53,95,71,104,111,115,116,80,111,114,116,97,108,46,66,73,68,95,49,48,53,95,71,104,111,115,116,80,111,114,116,97,108,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
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

                Stream fs = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs, 0, offsetback, Mesh))
                {
                    fs.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Mesh1);
                    binaryWriter.Close();
                    Settings.Default.GhostPortalEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh added";

                }

                Stream fs1 = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetback, MeshFX))
                {
                    fs1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(MeshFX1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh FX added";

                }

                Stream fs3 = File.OpenRead(idpath);

                foreach (long s in Researcher.FindPosition(fs3, 0, offsetlobby, BID))
                {
                    fs3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(idpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BID1);
                    binaryWriter.Close();
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

                Stream fs = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs, 0, offsetback, Mesh1))
                {
                    fs.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(Mesh);
                    binaryWriter.Close();
                    Settings.Default.GhostPortalEnabled = false;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh removed";

                }

                Stream fs1 = File.OpenRead(backblingpath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetback, MeshFX1))
                {
                    fs1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(backblingpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(MeshFX);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Mesh FX removed";

                }

                Stream fs3 = File.OpenRead(idpath);

                foreach (long s in Researcher.FindPosition(fs3, 0, offsetlobby, BID1))
                {
                    fs3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(idpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWriter.Write(BID);
                    binaryWriter.Close();
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
