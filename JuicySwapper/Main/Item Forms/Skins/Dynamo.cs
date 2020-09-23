using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;

namespace JuicySwapper.Main.GUI
{
    public partial class Dynamo : Form
    {
        public Dynamo()
        {
            InitializeComponent();
            MessageBox.Show("Please ensure that you select Winter Onesie before swapping!");
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
            if (Properties.Settings.Default.DynamoEnabled == true)
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
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,79,110,101,115,105,101,47,77,101,115,104,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,46,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101
        };

        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,47,77,101,115,104,101,115,47,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,46,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,0,0,0,0,0
        };

        private static byte[] BodyAnim = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,79,110,101,115,105,101,47,77,101,115,104,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,46,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,95,67
        };

        private static byte[] BodyAnim1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,47,77,101,115,104,101,115,47,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,95,65,110,105,109,66,80,46,70,95,77,69,68,95,76,117,99,104,97,100,111,114,95,48,49,95,65,110,105,109,66,80,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] FaceAcc = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,79,110,101,115,105,101,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,70,97,99,101,65,99,99,46,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,70,97,99,101,65,99,99
        };

        private static byte[] FaceAcc1 = new byte[]
        {
            47,71,97,109,101,47,65,99,99,101,115,115,111,114,105,101,115,47,72,97,116,115,47,70,95,77,69,68,95,76,117,99,104,97,100,111,114,97,47,77,101,115,104,101,115,47,70,95,77,69,68,95,76,117,99,104,97,95,77,97,115,107,95,48,49,46,70,95,77,69,68,95,76,117,99,104,97,95,77,97,115,107,95,48,49,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] FaceAccAnim = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,69,68,95,87,105,110,116,101,114,79,110,101,115,105,101,47,77,101,115,104,101,115,47,80,97,114,116,115,47,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,70,97,99,101,65,99,99,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,46,70,95,77,69,68,95,87,105,110,116,101,114,95,111,110,101,115,105,101,95,70,97,99,101,65,99,99,95,83,107,101,108,101,116,111,110,95,65,110,105,109,66,108,117,101,112,114,105,110,116,95,67
        };

        private static byte[] FaceAccAnim1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,70,95,77,69,68,95,72,73,83,95,82,97,109,105,114,101,122,95,72,101,97,100,95,48,49,47,77,101,115,104,47,70,95,77,69,68,95,72,73,83,95,82,97,109,105,114,101,122,95,72,101,97,100,95,48,49,95,65,110,105,109,66,80,95,67,104,105,108,100,46,70,95,77,69,68,95,72,73,83,95,82,97,109,105,114,101,122,95,72,101,97,100,95,48,49,95,65,110,105,109,66,80,95,67,104,105,108,100,95,67,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] Gender = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,101
        };

        private static byte[] Gender1 = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,48,48,48
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

                Stream swap1 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap1, 0, (long)offsetskin1, Body))
                {
                    swap1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(Body1);
                    long offset = numb + 879;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender1);
                    binaryWriter.Close();
                    Settings.Default.DynamoEnabled = true;
                    RichTextBoxInfo.Text += "\n[LOG] Body added";
                }

                Stream swap4 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap4, 0, (long)offsetskin1, BodyAnim))
                {
                    swap4.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body Animation added";
                }

                Stream swap2 = File.OpenRead(headpath);
                foreach (long numb in Researcher.FindPosition(swap2, 0, (long)offsetskin2, FaceAcc))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(FaceAcc1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Face Accessory added";
                }

                Stream swap3 = File.OpenRead(headpath);
                foreach (long numb in Researcher.FindPosition(swap3, 0, (long)offsetskin2, FaceAccAnim))
                {
                    swap3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(FaceAccAnim1);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Face Accessory Animation added";
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

                Stream swap1 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap1, 0, (long)offsetskin1, Body1))
                {
                    swap1.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(Body);
                    long offset = numb + 879;
                    binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    binaryWriter.Write(Gender);
                    binaryWriter.Close();
                    Settings.Default.DynamoEnabled = false;
                    RichTextBoxInfo.Text += "\n[LOG] Body removed";
                }

                Stream swap4 = File.OpenRead(bodypath);
                foreach (long numb in Researcher.FindPosition(swap4, 0, (long)offsetskin1, BodyAnim1))
                {
                    swap4.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(bodypath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(BodyAnim);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Body Animation removed";
                }

                Stream swap2 = File.OpenRead(headpath);
                foreach (long numb in Researcher.FindPosition(swap2, 0, (long)offsetskin2, FaceAcc1))
                {
                    swap2.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(FaceAcc);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Face Accessory removed";
                }

                Stream swap3 = File.OpenRead(headpath);
                foreach (long numb in Researcher.FindPosition(swap3, 0, (long)offsetskin2, FaceAccAnim1))
                {
                    swap3.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(headpath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.BaseStream.Seek(numb, SeekOrigin.Begin);
                    binaryWriter.Write(FaceAccAnim);
                    binaryWriter.Close();
                    RichTextBoxInfo.Text += "\n[LOG] Face Accessory Animation removed";
                }
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                RichTextBoxInfo.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
