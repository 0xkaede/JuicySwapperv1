namespace JuicyLauncher.Main.GUI
{
    partial class Uninstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uninstall));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.yesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.noButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 218);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uninstall Confirmation";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "Are you sure you want to uninstall\r\nJuicy Swapper? Pressing \'Yes\' will open\r\nthe " +
    "uninstaller, and you can cancel at\r\nany point throughout the uninstallation.";
            // 
            // yesButton
            // 
            this.yesButton.Activecolor = System.Drawing.Color.Transparent;
            this.yesButton.BackColor = System.Drawing.Color.Transparent;
            this.yesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesButton.BackgroundImage")));
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yesButton.BorderRadius = 0;
            this.yesButton.ButtonText = "Yes";
            this.yesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesButton.DisabledColor = System.Drawing.Color.White;
            this.yesButton.ForeColor = System.Drawing.Color.White;
            this.yesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.yesButton.Iconimage = null;
            this.yesButton.Iconimage_right = null;
            this.yesButton.Iconimage_right_Selected = null;
            this.yesButton.Iconimage_Selected = null;
            this.yesButton.IconMarginLeft = 0;
            this.yesButton.IconMarginRight = 0;
            this.yesButton.IconRightVisible = true;
            this.yesButton.IconRightZoom = 0D;
            this.yesButton.IconVisible = true;
            this.yesButton.IconZoom = 50D;
            this.yesButton.IsTab = false;
            this.yesButton.Location = new System.Drawing.Point(359, 154);
            this.yesButton.Name = "yesButton";
            this.yesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.yesButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.yesButton.OnHoverTextColor = System.Drawing.Color.White;
            this.yesButton.selected = false;
            this.yesButton.Size = new System.Drawing.Size(97, 26);
            this.yesButton.TabIndex = 20;
            this.yesButton.Text = "Yes";
            this.yesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesButton.Textcolor = System.Drawing.Color.White;
            this.yesButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.yesButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(435, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 22;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // noButton
            // 
            this.noButton.Activecolor = System.Drawing.Color.Transparent;
            this.noButton.BackColor = System.Drawing.Color.Transparent;
            this.noButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noButton.BackgroundImage")));
            this.noButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noButton.BorderRadius = 0;
            this.noButton.ButtonText = "No";
            this.noButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noButton.DisabledColor = System.Drawing.Color.White;
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.Iconcolor = System.Drawing.Color.Transparent;
            this.noButton.Iconimage = null;
            this.noButton.Iconimage_right = null;
            this.noButton.Iconimage_right_Selected = null;
            this.noButton.Iconimage_Selected = null;
            this.noButton.IconMarginLeft = 0;
            this.noButton.IconMarginRight = 0;
            this.noButton.IconRightVisible = true;
            this.noButton.IconRightZoom = 0D;
            this.noButton.IconVisible = true;
            this.noButton.IconZoom = 50D;
            this.noButton.IsTab = false;
            this.noButton.Location = new System.Drawing.Point(256, 154);
            this.noButton.Name = "noButton";
            this.noButton.Normalcolor = System.Drawing.Color.Transparent;
            this.noButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.noButton.OnHoverTextColor = System.Drawing.Color.White;
            this.noButton.selected = false;
            this.noButton.Size = new System.Drawing.Size(97, 26);
            this.noButton.TabIndex = 20;
            this.noButton.Text = "No";
            this.noButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noButton.Textcolor = System.Drawing.Color.White;
            this.noButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.noButton;
            // 
            // Uninstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(468, 192);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uninstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Developer Mode";
            this.Load += new System.EventHandler(this.DevMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton yesButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuFlatButton noButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}