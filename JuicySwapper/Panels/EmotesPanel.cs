using JuicySwapper.Main.GUI;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Panels
{
    public partial class EmotesPanel : UserControl
    {
        private static EmotesPanel _instance;      
        public static EmotesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmotesPanel();
                return _instance;
            }
        }
        public EmotesPanel()
        {
            InitializeComponent();
            bunifuFlatButton1.Text = "    " + "kaede - Developer";
        }

        private void bunifuFlatButton7_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Floss().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Scenario().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new TakeTheL().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new NeverGonna().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Slick().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new LazerBlast().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new Levitate().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            new Infectious().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            new PonyUp().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            new Glowsticks().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            new Flapper().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            new Daydream().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            new Llamacadabra().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            new Poki().ShowDialog();
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            new TheWorm().ShowDialog();
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            new ToosieSlide().ShowDialog();
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            new Fishin().ShowDialog();
        }

        private void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            new SmoothMoves().ShowDialog();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            new Freestylin().ShowDialog();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            new CheerUp().ShowDialog();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            new Fresh().ShowDialog();
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            new PopLock().ShowDialog();
        }

        private void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            new OrangeJustice().ShowDialog();
        }

        private void bunifuImageButton24_Click(object sender, EventArgs e)
        {
            new TheRenegade().ShowDialog();
        }

        private void bunifuImageButton25_Click(object sender, EventArgs e)
        {
            new BhangraBoogie().ShowDialog();
        }

        private void bunifuImageButton26_Click(object sender, EventArgs e)
        {
            new OutWest().ShowDialog();
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            new BuckleUp().ShowDialog();
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            new ButterflyKnife().ShowDialog();
        }
    }
}
