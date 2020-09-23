using JuicyIDSwapper.Properties;
using System;
using System.Windows.Forms;
using WMPLib;

namespace JuicyIDSwapper.Main.GUI
{
    public partial class MediaPlayerMenu : Form
    {
        public MediaPlayerMenu()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            Close();
        }

        private void musicSelectButton_Click(object sender, EventArgs e)
        {
            new MediaPlayer().ShowDialog();
        }

        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void playButton_Click(object sender, EventArgs e)
        {
            wplayer.URL = Settings.Default.musicPath;
            wplayer.controls.play();
            label2.Text = "Playing: " + Settings.Default.musicName;
            Settings.Default.Save();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            label2.Text = "Playing: Waiting...";
            Settings.Default.Save();
        }

        private void MediaPlayerMenu_Load(object sender, EventArgs e)
        {
            label2.Text = "Playing: " + Settings.Default.musicName;
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = bunifuSlider1.Value;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
