using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    
    public partial class GalacticDisc : Form
    {
        public GalacticDisc()
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
            if (Properties.Settings.Default.GalacticDiscEnabled == true)
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
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,66,97,99,107,112,97,99,107,95,71,97,108,105,108,101,111,95,72,111,108,111,115,47,70,88,47,67,67,80,77,95,71,97,108,105,108,101,111,83,112,101,101,100,98,111,97,116,95,66,97,99,107,112,97,99,107,46,67,67,80,77,95,71,97,108,105,108,101,111,83,112,101,101,100,98,111,97,116,95,66,97,99,107,112,97,99,107,95,67
        };

        private static byte[] Mesh1 = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,70,79,82,84,95,66,97,99,107,112,97,99,107,115,47,77,95,77,69,68,95,67,101,108,101,115,116,105,97,108,95,66,97,99,107,112,97,99,107,47,66,80,95,66,97,99,107,112,97,99,107,95,67,101,108,101,115,116,105,97,108,46,66,80,95,66,97,99,107,112,97,99,107,95,67,101,108,101,115,116,105,97,108,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] BID = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,73,116,101,109,115,47,67,111,115,109,101,116,105,99,115,47,66,97,99,107,112,97,99,107,115,47,66,73,68,95,52,51,48,95,71,97,108,105,108,101,111,83,112,101,101,100,66,111,97,116,95,57,82,88,69,51,46,66,73,68,95,52,51,48,95,71,97,108,105,108,101,111,83,112,101,101,100,66,111,97,116,95,57,82,88,69,51
        };

        private static byte[] BID1 = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,73,116,101,109,115,47,67,111,115,109,101,116,105,99,115,47,66,97,99,107,112,97,99,107,115,47,98,105,100,95,49,51,56,95,99,101,108,101,115,116,105,97,108,46,98,105,100,95,49,51,56,95,99,101,108,101,115,116,105,97,108,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
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
                    Settings.Default.GalacticDiscEnabled = true;
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
                    Settings.Default.GalacticDiscEnabled = false;
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
