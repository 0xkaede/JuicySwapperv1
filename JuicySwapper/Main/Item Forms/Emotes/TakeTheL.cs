using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class TakeTheL : Form
    {
        public TakeTheL()
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
            if (Properties.Settings.Default.TakeTheLEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }

		private static byte[] CMF = new byte[]
		{
			47,
			71,
			97,
			109,
			101,
			47,
			65,
			110,
			105,
			109,
			97,
			116,
			105,
			111,
			110,
			47,
			71,
			97,
			109,
			101,
			47,
			77,
			97,
			105,
			110,
			80,
			108,
			97,
			121,
			101,
			114,
			47,
			69,
			109,
			111,
			116,
			101,
			115,
			47,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			47,
			69,
			109,
			111,
			116,
			101,
			95,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			95,
			67,
			77,
			70,
			95,
			77,
			46,
			69,
			109,
			111,
			116,
			101,
			95,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			95,
			67,
			77,
			70,
			95,
			77
		};

		// Token: 0x0400015C RID: 348
		private static byte[] CMF1 = new byte[]
		{
			47,
			71,
			97,
			109,
			101,
			47,
			65,
			110,
			105,
			109,
			97,
			116,
			105,
			111,
			110,
			47,
			71,
			97,
			109,
			101,
			47,
			77,
			97,
			105,
			110,
			80,
			108,
			97,
			121,
			101,
			114,
			47,
			69,
			109,
			111,
			116,
			101,
			115,
			47,
			76,
			111,
			115,
			101,
			114,
			95,
			68,
			97,
			110,
			99,
			101,
			47,
			69,
			109,
			111,
			116,
			101,
			95,
			68,
			97,
			110,
			99,
			101,
			95,
			76,
			111,
			115,
			101,
			114,
			95,
			67,
			77,
			70,
			95,
			77,
			46,
			69,
			109,
			111,
			116,
			101,
			95,
			68,
			97,
			110,
			99,
			101,
			95,
			76,
			111,
			115,
			101,
			114,
			95,
			67,
			77,
			70,
			95,
			77,
			0,
			0,
			0,
			0,
			0,
			0
		};

		// Token: 0x0400015D RID: 349
		private static byte[] CMM = new byte[]
		{
			47,
			71,
			97,
			109,
			101,
			47,
			65,
			110,
			105,
			109,
			97,
			116,
			105,
			111,
			110,
			47,
			71,
			97,
			109,
			101,
			47,
			77,
			97,
			105,
			110,
			80,
			108,
			97,
			121,
			101,
			114,
			47,
			69,
			109,
			111,
			116,
			101,
			115,
			47,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			47,
			69,
			109,
			111,
			116,
			101,
			95,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			95,
			67,
			77,
			77,
			95,
			77,
			46,
			69,
			109,
			111,
			116,
			101,
			95,
			66,
			108,
			111,
			119,
			105,
			110,
			103,
			66,
			117,
			98,
			98,
			108,
			101,
			95,
			67,
			77,
			77,
			95,
			77
		};

		// Token: 0x0400015E RID: 350
		private static byte[] CMM1 = new byte[]
		{
			47,
			71,
			97,
			109,
			101,
			47,
			65,
			110,
			105,
			109,
			97,
			116,
			105,
			111,
			110,
			47,
			71,
			97,
			109,
			101,
			47,
			77,
			97,
			105,
			110,
			80,
			108,
			97,
			121,
			101,
			114,
			47,
			69,
			109,
			111,
			116,
			101,
			115,
			47,
			76,
			111,
			115,
			101,
			114,
			95,
			68,
			97,
			110,
			99,
			101,
			47,
			69,
			109,
			111,
			116,
			101,
			95,
			68,
			97,
			110,
			99,
			101,
			95,
			76,
			111,
			115,
			101,
			114,
			95,
			67,
			77,
			77,
			95,
			77,
			46,
			69,
			109,
			111,
			116,
			101,
			95,
			68,
			97,
			110,
			99,
			101,
			95,
			76,
			111,
			115,
			101,
			114,
			95,
			67,
			77,
			77,
			95,
			77,
			0,
			0,
			0,
			0,
			0,
			0
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
            if (convertButton.Text == "Convert")
            {
                RichTextBoxInfo.Clear();
                convertButton.Enabled = false;
                RichTextBoxInfo.Text = "";
                RichTextBoxInfo.Text += "[LOG] Starting...";


                Stream fs1 = File.OpenRead(emotespath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetemote, CMM))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(emotespath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(CMM1);
                    binaryWrite.Close();
                    Settings.Default.TakeTheLEnabled = true;
                    Settings.Default.Save();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Dance 1/2 added!";
                }

                Stream fs2 = File.OpenRead(emotespath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetemote, CMF))
                {
                    fs2.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(emotespath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(CMF1);
                    binaryWrite.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Dance 2/2 added!";
                }


                convertButton.Enabled = true;
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                RichTextBoxInfo.Clear();
                convertButton.Enabled = false;
                RichTextBoxInfo.Text = "";
                RichTextBoxInfo.Text += "[LOG] Starting...";

                Stream fs1 = File.OpenRead(emotespath);

                foreach (long s in Researcher.FindPosition(fs1, 0, offsetemote, CMM1))
                {
                    fs1.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(emotespath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(CMM);
                    binaryWrite.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Dance 1/2 removed!";
                    Settings.Default.TakeTheLEnabled = false;
                    Settings.Default.Save();
                }

                Stream fs2 = File.OpenRead(emotespath);

                foreach (long s in Researcher.FindPosition(fs2, 0, offsetemote, CMF1))
                {
                    fs2.Close();
                    BinaryWriter binaryWrite = new BinaryWriter((Stream)File.Open(emotespath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWrite.BaseStream.Seek(s + 0L, SeekOrigin.Begin);
                    binaryWrite.Write(CMF);
                    binaryWrite.Close();
                    RichTextBoxInfo.Text = RichTextBoxInfo.Text + "\n[LOG] Dance 2/2 removed!";
                }


                convertButton.Enabled = true;
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
