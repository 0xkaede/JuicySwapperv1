using System;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class ResetComplete : Form
    {
        public ResetComplete()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetComplete_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }
    }
}
