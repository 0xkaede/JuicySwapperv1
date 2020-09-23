using JuicyIDSwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicyIDSwapper.IO;
using System.IO;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class SkullTrooper : Form
    {
        public SkullTrooper()
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
            string filePath = Settings.Default.pakPath + "\\pakchunk0-WindowsClient.pak";

            if (!File.Exists(filePath))
            {
                PakError a = new PakError(); a.ShowDialog();
                return;
            }

            else
            {
                CheckForIllegalCrossThreadCalls = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void SkullTrooper_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SkullTrooperEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string ID = "CID_030_Athena_Commando_M_Halloween";
        string ID1 = "CID_237_Athena_Commando_F_Cowgirl";
        string Invalid = "CID_237_Athena_Commando_F_Cowgirl";
        string Invalid1 = "CID_237_Athena_Commando_F_Cow0000";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; int Offset = 475000000;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string Path = Settings.Default.pakPath + Settings.Default.idpathAPI;
            if (convertButton.Text == "Convert")
            {
                richTextBox1.Clear();
                richTextBox1.Text += "[LOG] Starting...";

                bool swap1 = Engine.Convert(Offset, Path, Invalid, Invalid1, 0, 0, false, false);
                if (swap1)
                {
                    richTextBox1.Text += "\n[LOG] ID 1/2 added";
                    Settings.Default.SkullTrooperEnabled = true;
                    Settings.Default.Save();
                }
                bool swap2 = Engine.Convert(Offset, Path, ID, ID1, 0, 0, false, false);
                if (swap2)
                {
                    richTextBox1.Text += "\n[LOG] ID 2/2 added";
                }
                convertButton.Text = "Revert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                richTextBox1.AppendText("\n[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.Text += "[LOG] Starting...";
                bool swap1 = Engine.Revert(Offset, Path, Invalid, Invalid1, 0, 0, false);
                if (swap1)
                {
                    richTextBox1.Text += "\n[LOG] ID 1/2 removed";
                    Settings.Default.SkullTrooperEnabled = false;
                    Settings.Default.Save();
                }
                bool swap2 = Engine.Revert(Offset, Path, ID, ID1, 0, 0, false);
                if (swap2)
                {
                    richTextBox1.Text += "\n[LOG] ID 2/2 removed";
                }
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                richTextBox1.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
