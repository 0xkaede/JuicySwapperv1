using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class MogulMasterKOR : Form
    {
        public MogulMasterKOR()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private static byte[] Body = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,72,101,114,111,101,115,47,77,101,115,104,101,115,47,66,111,100,105,101,115,47,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65,46,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65
        };

        private static byte[] Body1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,67,104,97,114,97,99,116,101,114,80,97,114,116,115,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,66,82,52,50,95,75,79,82,46,70,95,77,101,100,95,83,111,108,100,105,101,114,95,66,82,52,50,95,75,79,82,0,0,0,0,0
        };

        private static byte[] Head = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,67,104,97,114,97,99,116,101,114,80,97,114,116,115,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,72,101,97,100,115,47,67,80,95,72,101,97,100,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65,46,67,80,95,72,101,97,100,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65
        };

        private static byte[] Head1 = new byte[]
        {
            47,71,97,109,101,47,65,116,104,101,110,97,47,72,101,114,111,101,115,47,77,101,115,104,101,115,47,72,101,97,100,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,83,107,105,77,97,115,107,95,48,49,95,65,84,72,95,75,79,82,46,70,95,77,101,100,95,83,111,108,100,105,101,114,95,83,107,105,77,97,115,107,95,48,49,95,65,84,72,95,75,79,82,0,0,0,0,0
        };

        private static byte[] CPM = new byte[]
        {
            0,0,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,82,101,98,105,114,116,104,83,111,108,100,105,101,114
        };

        private static byte[] CPM1 = new byte[]
        {
            0,0,67,80,95,65,116,104,101,110,97,95,66,111,100,121,95,77,95,82,101,98,105,114,116,104,83,111,108,100,48,48,48
        };

        private static byte[] CPF = new byte[]
        {
            0,0,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,108,116,65
        };

        private static byte[] CPF1 = new byte[]
        {
            0,0,67,80,95,66,111,100,121,95,67,111,109,109,97,110,100,111,95,70,95,82,101,98,105,114,116,104,68,101,102,97,117,48,48,48
        };

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string PakFolder = Settings.Default.pakPath;

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath10 = PakFolder + Settings.Default.cppackAPI;
            string filePath8 = PakFolder + Settings.Default.cppackAPI2; 
            if (!File.Exists(filePath8))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }
            else
            {
                if (convertButton.Text == "Convert")
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    richTextBox1.Clear();
                    richTextBox1.AppendText("[LOG] Starting...\n");
                    ReplaceBytes(filePath10, Settings.Default.defaulthead, Head);
                    ReplaceBytes(filePath10, Settings.Default.defaulthead, Head1);
                    richTextBox1.AppendText("[LOG] Head added\n");
                    ReplaceBytes(filePath10, Settings.Default.defaultbody, Body);
                    ReplaceBytes(filePath10, Settings.Default.defaultbody, Body1);
                    richTextBox1.AppendText("[LOG] Body added\n");
                    ReplaceBytes(filePath8, Settings.Default.invalidm, CPM);
                    ReplaceBytes(filePath8, Settings.Default.invalidm, CPM1);
                    ReplaceBytes(filePath10, Settings.Default.invalidf, CPF);
                    ReplaceBytes(filePath10, Settings.Default.invalidf, CPF1);
                    richTextBox1.AppendText("[LOG] Character Part added\n");
                    convertButton.Text = "Revert";
                    Properties.Settings.Default.MogulKOREnabled = true;
                    Properties.Settings.Default.Save();
                    stopwatch.Stop();
                    double num = (double)stopwatch.Elapsed.Milliseconds;
                    richTextBox1.AppendText("[LOG] Done! Converted in " + num + " ms.");
                }
                else
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    richTextBox1.Clear();
                    richTextBox1.AppendText("[LOG] Starting...\n");
                    ReplaceBytes(filePath10, Settings.Default.defaulthead, Head1);
                    ReplaceBytes(filePath10, Settings.Default.defaulthead, Head);
                    richTextBox1.AppendText("[LOG] Head removed\n");
                    ReplaceBytes(filePath10, Settings.Default.defaultbody, Body1);
                    ReplaceBytes(filePath10, Settings.Default.defaultbody, Body);
                    richTextBox1.AppendText("[LOG] Body removed\n");
                    ReplaceBytes(filePath8, Settings.Default.invalidm, CPM1);
                    ReplaceBytes(filePath8, Settings.Default.invalidm, CPM);
                    ReplaceBytes(filePath10, Settings.Default.invalidf, CPF1);
                    ReplaceBytes(filePath10, Settings.Default.invalidf, CPF);
                    richTextBox1.AppendText("[LOG] Character Part removed\n");
                    convertButton.Text = "Convert";
                    Properties.Settings.Default.MogulKOREnabled = false;
                    Properties.Settings.Default.Save();
                    stopwatch.Stop();
                    double num = (double)stopwatch.Elapsed.Milliseconds;
                    richTextBox1.AppendText("[LOG] Done! Reverted in " + num + " ms.");

                }
            }
        }

        private void BlackKnight_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MogulKOREnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }
    }
}
