using JuicyIDSwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicyIDSwapper.IO;
using System.IO;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class StealthReflex : Form
    {
        public StealthReflex()
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

        private void StealthReflex_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StealthReflexEnabled == true)
            {
                convertButton.Text = "Revert";
            }
            else
            {
                convertButton.Text = "Convert";
            }
        }


        string ID = "CID_253_Athena_Commando_M_MilitaryFashion2.CID_253_Athena_Commando_M_MilitaryFashion2";
        string ID1 = "CID_386_Athena_Commando_M_StreetOpsStealth.CID_386_Athena_Commando_M_StreetOpsStealth";


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; int Offset = Settings.Default.offsetlobby;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string Path = Settings.Default.pakPath + Settings.Default.idpathAPI;
            if (convertButton.Text == "Convert")
            {
                richTextBox1.Clear();
                richTextBox1.Text += "[LOG] Starting...";

                bool swap = Engine.Convert(Offset, Path, ID, ID1, 0, 0, false, false);
                if (swap)
                {
                    richTextBox1.Text += "\n[LOG] ID added!";
                    Settings.Default.StealthReflexEnabled = true;
                    Settings.Default.Save();
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
                bool swap = Engine.Revert(Offset, Path, ID, ID1, 0, 0, false);
                if (swap)
                {
                    richTextBox1.Text += "\n[LOG] ID removed!";
                    Settings.Default.StealthReflexEnabled = false;
                    Settings.Default.Save();
                }
                convertButton.Text = "Convert";
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                richTextBox1.AppendText("\n[LOG] Done! Reverted in " + num + " ms.");

            }
        }
    }
}
