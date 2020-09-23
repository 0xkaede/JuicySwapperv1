using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class PakError : Form
    {
        public PakError()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PakError_Load(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }
    }
}
