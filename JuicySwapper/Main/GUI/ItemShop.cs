using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class ItemShop : Form
    {
        public ItemShop()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void FortniteLaunch_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://api.nitestats.com/v1/shop/image?header=JUICY%20SWAPPER&footer=twitter.com/juicyindustries&textcolor=ffa500&background=19162A");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image original = Bitmap.FromStream(stream);
                Image resized = new Bitmap(original, new Size(original.Width / 2, original.Height / 2));
                pictureBox1.Image = new Bitmap(resized);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
