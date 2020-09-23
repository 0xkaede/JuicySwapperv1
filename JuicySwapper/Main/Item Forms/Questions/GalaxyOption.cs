using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class GalaxyOption : Form
    {
        public GalaxyOption()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Galaxy().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new DreamGalaxy().ShowDialog();
        }
    }
}
