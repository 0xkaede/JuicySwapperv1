namespace JuicyIDSwapper.Main.GUI
{
    partial class MediaPlayerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.stopButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.playButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.musicSelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Magenta;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.Location = new System.Drawing.Point(-3, -7);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(70, 208);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Media Player";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(365, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // stopButton
            // 
            this.stopButton.Activecolor = System.Drawing.Color.Transparent;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.BorderRadius = 0;
            this.stopButton.ButtonText = "Stop";
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.DisabledColor = System.Drawing.Color.White;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Iconcolor = System.Drawing.Color.Transparent;
            this.stopButton.Iconimage = null;
            this.stopButton.Iconimage_right = null;
            this.stopButton.Iconimage_right_Selected = null;
            this.stopButton.Iconimage_Selected = null;
            this.stopButton.IconMarginLeft = 0;
            this.stopButton.IconMarginRight = 0;
            this.stopButton.IconRightVisible = true;
            this.stopButton.IconRightZoom = 0D;
            this.stopButton.IconVisible = true;
            this.stopButton.IconZoom = 50D;
            this.stopButton.IsTab = false;
            this.stopButton.Location = new System.Drawing.Point(240, 75);
            this.stopButton.Name = "stopButton";
            this.stopButton.Normalcolor = System.Drawing.Color.Transparent;
            this.stopButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.stopButton.OnHoverTextColor = System.Drawing.Color.White;
            this.stopButton.selected = false;
            this.stopButton.Size = new System.Drawing.Size(144, 26);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopButton.Textcolor = System.Drawing.Color.White;
            this.stopButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Activecolor = System.Drawing.Color.Transparent;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.BorderRadius = 0;
            this.playButton.ButtonText = "Play";
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.DisabledColor = System.Drawing.Color.White;
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Iconcolor = System.Drawing.Color.Transparent;
            this.playButton.Iconimage = null;
            this.playButton.Iconimage_right = null;
            this.playButton.Iconimage_right_Selected = null;
            this.playButton.Iconimage_Selected = null;
            this.playButton.IconMarginLeft = 0;
            this.playButton.IconMarginRight = 0;
            this.playButton.IconRightVisible = true;
            this.playButton.IconRightZoom = 0D;
            this.playButton.IconVisible = true;
            this.playButton.IconZoom = 50D;
            this.playButton.IsTab = false;
            this.playButton.Location = new System.Drawing.Point(82, 75);
            this.playButton.Name = "playButton";
            this.playButton.Normalcolor = System.Drawing.Color.Transparent;
            this.playButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.playButton.OnHoverTextColor = System.Drawing.Color.White;
            this.playButton.selected = false;
            this.playButton.Size = new System.Drawing.Size(144, 26);
            this.playButton.TabIndex = 16;
            this.playButton.Text = "Play";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.Textcolor = System.Drawing.Color.White;
            this.playButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // musicSelectButton
            // 
            this.musicSelectButton.Activecolor = System.Drawing.Color.Transparent;
            this.musicSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.musicSelectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicSelectButton.BackgroundImage")));
            this.musicSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicSelectButton.BorderRadius = 0;
            this.musicSelectButton.ButtonText = "Select Music File";
            this.musicSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicSelectButton.DisabledColor = System.Drawing.Color.White;
            this.musicSelectButton.ForeColor = System.Drawing.Color.White;
            this.musicSelectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.musicSelectButton.Iconimage = null;
            this.musicSelectButton.Iconimage_right = null;
            this.musicSelectButton.Iconimage_right_Selected = null;
            this.musicSelectButton.Iconimage_Selected = null;
            this.musicSelectButton.IconMarginLeft = 0;
            this.musicSelectButton.IconMarginRight = 0;
            this.musicSelectButton.IconRightVisible = true;
            this.musicSelectButton.IconRightZoom = 0D;
            this.musicSelectButton.IconVisible = true;
            this.musicSelectButton.IconZoom = 50D;
            this.musicSelectButton.IsTab = false;
            this.musicSelectButton.Location = new System.Drawing.Point(82, 107);
            this.musicSelectButton.Name = "musicSelectButton";
            this.musicSelectButton.Normalcolor = System.Drawing.Color.Transparent;
            this.musicSelectButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.musicSelectButton.OnHoverTextColor = System.Drawing.Color.White;
            this.musicSelectButton.selected = false;
            this.musicSelectButton.Size = new System.Drawing.Size(302, 26);
            this.musicSelectButton.TabIndex = 19;
            this.musicSelectButton.Text = "Select Music File";
            this.musicSelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicSelectButton.Textcolor = System.Drawing.Color.White;
            this.musicSelectButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicSelectButton.Click += new System.EventHandler(this.musicSelectButton_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.musicSelectButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.stopButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.playButton;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Playing: Waiting...";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(82, 143);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(302, 30);
            this.bunifuSlider1.TabIndex = 21;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(338, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 14);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.label2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // MediaPlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musicSelectButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPlayerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.MediaPlayerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton stopButton;
        private Bunifu.Framework.UI.BunifuFlatButton musicSelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton playButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}