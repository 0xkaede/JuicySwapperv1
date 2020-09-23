using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class SkullTrooperOption : Form
    {
        public SkullTrooperOption()
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
            new SkullTrooper().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //new SkullTrooperPak().ShowDialog();
        }
    }
}
