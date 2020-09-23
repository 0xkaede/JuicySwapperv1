using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class FortniteLaunch : Form
    {
        public FortniteLaunch()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FortniteLaunch_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
