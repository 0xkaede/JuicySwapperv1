using JuicyIDSwapper.IO;
using JuicyIDSwapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class CustomID : Form
    {
        public CustomID()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "e.g. CID_346_Athena_Commando_M_DragonNinja")
            {
                textBox1.Text = "";
            }
            else
            {

            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "e.g. CID_029_Athena_Commando_F_Halloween")
            {
                textBox2.Text = "";
            }
            else
            {

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://nitestats.com/ids/");
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("ID_"))
            {
                MessageBox.Show("The ID entered is not valid! Please look at the ID list for examples.");
            }
            else if (!textBox2.Text.Contains("ID_"))
            {
                MessageBox.Show("The ID entered is not valid! Please look at the ID list for examples.");
            }
            else if (textBox1.TextLength < textBox2.TextLength)
            {
                MessageBox.Show("The ID you are trying to swap to is too long! Please choose a different item to use for the swap, or choose a different item to swap to.");
            }
            else
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
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("ID_"))
            {
                MessageBox.Show("The ID entered is not valid! Please look at the ID list for examples.");
            }
            else if (!textBox2.Text.Contains("ID_"))
            {
                MessageBox.Show("The ID entered is not valid! Please look at the ID list for examples.");
            }
            else if (textBox1.TextLength < textBox2.TextLength)
            {
                MessageBox.Show("The ID you are trying to swap to is too long! Please choose a different item to use for the swap, or choose a different item to swap to.");
            }
            else
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
                    backgroundWorker2.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; int Offset = Settings.Default.offsetlobby;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string Path = Settings.Default.pakPath + Settings.Default.idpathAPI;
            string ID = textBox1.Text + "." + textBox1.Text;
            string ID1 = textBox2.Text + "." + textBox2.Text;
            bool swap = Engine.Convert(Offset, Path, ID, ID1, 0, 0, false, false);
            if (swap)
            {
                Settings.Default.Save();
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                MessageBox.Show("[LOG] Done! Converted in " + num + " ms.");
            }
            else
            {
                MessageBox.Show("Error! Could not find ID. A common issue is that your ID starts with a blank character.\nPlease follow the example or look at the ID list.\nIf you continue to have issues, create a ticket in our Discord.");
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; int Offset = Settings.Default.offsetlobby;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string Path = Settings.Default.pakPath + Settings.Default.idpathAPI;
            string ID = textBox1.Text + "." + textBox1.Text;
            string ID1 = textBox2.Text + "." + textBox2.Text;
            bool swap = Engine.Revert(Offset, Path, ID, ID1, 0, 0, false, false);
            if (swap)
            {
                Settings.Default.Save();
                stopwatch.Stop();
                double num = (double)stopwatch.Elapsed.Milliseconds;
                MessageBox.Show("[LOG] Done! Reverted in " + num + " ms.");
            }
            else
            {
                MessageBox.Show("Error! Could not find ID. A common issue is that your ID starts with a blank character.\nPlease follow the example or look at the ID list.\nIf you continue to have issues, create a ticket in our Discord.");
            }
        }
    }
}
