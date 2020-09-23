namespace JuicySwapper.Main.GUI
{
    partial class AdvancedSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSettings));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.checkPakButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openPakButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.restartButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.launchFNButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.Sidebar.Size = new System.Drawing.Size(70, 178);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Advanced Settings";
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
            // checkPakButton
            // 
            this.checkPakButton.Activecolor = System.Drawing.Color.Transparent;
            this.checkPakButton.BackColor = System.Drawing.Color.Transparent;
            this.checkPakButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPakButton.BackgroundImage")));
            this.checkPakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPakButton.BorderRadius = 0;
            this.checkPakButton.ButtonText = "Check Pak Directory";
            this.checkPakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPakButton.DisabledColor = System.Drawing.Color.White;
            this.checkPakButton.ForeColor = System.Drawing.Color.White;
            this.checkPakButton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkPakButton.Iconimage = null;
            this.checkPakButton.Iconimage_right = null;
            this.checkPakButton.Iconimage_right_Selected = null;
            this.checkPakButton.Iconimage_Selected = null;
            this.checkPakButton.IconMarginLeft = 0;
            this.checkPakButton.IconMarginRight = 0;
            this.checkPakButton.IconRightVisible = true;
            this.checkPakButton.IconRightZoom = 0D;
            this.checkPakButton.IconVisible = true;
            this.checkPakButton.IconZoom = 50D;
            this.checkPakButton.IsTab = false;
            this.checkPakButton.Location = new System.Drawing.Point(240, 75);
            this.checkPakButton.Name = "checkPakButton";
            this.checkPakButton.Normalcolor = System.Drawing.Color.Transparent;
            this.checkPakButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.checkPakButton.OnHoverTextColor = System.Drawing.Color.White;
            this.checkPakButton.selected = false;
            this.checkPakButton.Size = new System.Drawing.Size(144, 26);
            this.checkPakButton.TabIndex = 9;
            this.checkPakButton.Text = "Check Pak Directory";
            this.checkPakButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPakButton.Textcolor = System.Drawing.Color.White;
            this.checkPakButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPakButton.Click += new System.EventHandler(this.checkPakButton_Click);
            // 
            // openPakButton
            // 
            this.openPakButton.Activecolor = System.Drawing.Color.Transparent;
            this.openPakButton.BackColor = System.Drawing.Color.Transparent;
            this.openPakButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openPakButton.BackgroundImage")));
            this.openPakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openPakButton.BorderRadius = 0;
            this.openPakButton.ButtonText = "Open Pak Directory";
            this.openPakButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPakButton.DisabledColor = System.Drawing.Color.White;
            this.openPakButton.ForeColor = System.Drawing.Color.White;
            this.openPakButton.Iconcolor = System.Drawing.Color.Transparent;
            this.openPakButton.Iconimage = null;
            this.openPakButton.Iconimage_right = null;
            this.openPakButton.Iconimage_right_Selected = null;
            this.openPakButton.Iconimage_Selected = null;
            this.openPakButton.IconMarginLeft = 0;
            this.openPakButton.IconMarginRight = 0;
            this.openPakButton.IconRightVisible = true;
            this.openPakButton.IconRightZoom = 0D;
            this.openPakButton.IconVisible = true;
            this.openPakButton.IconZoom = 50D;
            this.openPakButton.IsTab = false;
            this.openPakButton.Location = new System.Drawing.Point(82, 75);
            this.openPakButton.Name = "openPakButton";
            this.openPakButton.Normalcolor = System.Drawing.Color.Transparent;
            this.openPakButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.openPakButton.OnHoverTextColor = System.Drawing.Color.White;
            this.openPakButton.selected = false;
            this.openPakButton.Size = new System.Drawing.Size(144, 26);
            this.openPakButton.TabIndex = 16;
            this.openPakButton.Text = "Open Pak Directory";
            this.openPakButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openPakButton.Textcolor = System.Drawing.Color.White;
            this.openPakButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPakButton.Click += new System.EventHandler(this.openPakButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Activecolor = System.Drawing.Color.Transparent;
            this.backupButton.BackColor = System.Drawing.Color.Transparent;
            this.backupButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backupButton.BackgroundImage")));
            this.backupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backupButton.BorderRadius = 0;
            this.backupButton.ButtonText = "Backup/Verify";
            this.backupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupButton.DisabledColor = System.Drawing.Color.White;
            this.backupButton.ForeColor = System.Drawing.Color.White;
            this.backupButton.Iconcolor = System.Drawing.Color.Transparent;
            this.backupButton.Iconimage = null;
            this.backupButton.Iconimage_right = null;
            this.backupButton.Iconimage_right_Selected = null;
            this.backupButton.Iconimage_Selected = null;
            this.backupButton.IconMarginLeft = 0;
            this.backupButton.IconMarginRight = 0;
            this.backupButton.IconRightVisible = true;
            this.backupButton.IconRightZoom = 0D;
            this.backupButton.IconVisible = true;
            this.backupButton.IconZoom = 50D;
            this.backupButton.IsTab = false;
            this.backupButton.Location = new System.Drawing.Point(82, 43);
            this.backupButton.Name = "backupButton";
            this.backupButton.Normalcolor = System.Drawing.Color.Transparent;
            this.backupButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.backupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.backupButton.selected = false;
            this.backupButton.Size = new System.Drawing.Size(144, 26);
            this.backupButton.TabIndex = 17;
            this.backupButton.Text = "Backup/Verify";
            this.backupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupButton.Textcolor = System.Drawing.Color.White;
            this.backupButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Activecolor = System.Drawing.Color.Transparent;
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartButton.BorderRadius = 0;
            this.restartButton.ButtonText = "Restart Swapper";
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.DisabledColor = System.Drawing.Color.White;
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Iconcolor = System.Drawing.Color.Transparent;
            this.restartButton.Iconimage = null;
            this.restartButton.Iconimage_right = null;
            this.restartButton.Iconimage_right_Selected = null;
            this.restartButton.Iconimage_Selected = null;
            this.restartButton.IconMarginLeft = 0;
            this.restartButton.IconMarginRight = 0;
            this.restartButton.IconRightVisible = true;
            this.restartButton.IconRightZoom = 0D;
            this.restartButton.IconVisible = true;
            this.restartButton.IconZoom = 50D;
            this.restartButton.IsTab = false;
            this.restartButton.Location = new System.Drawing.Point(240, 43);
            this.restartButton.Name = "restartButton";
            this.restartButton.Normalcolor = System.Drawing.Color.Transparent;
            this.restartButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.restartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.restartButton.selected = false;
            this.restartButton.Size = new System.Drawing.Size(144, 26);
            this.restartButton.TabIndex = 18;
            this.restartButton.Text = "Restart Swapper";
            this.restartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartButton.Textcolor = System.Drawing.Color.White;
            this.restartButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // launchFNButton
            // 
            this.launchFNButton.Activecolor = System.Drawing.Color.Transparent;
            this.launchFNButton.BackColor = System.Drawing.Color.Transparent;
            this.launchFNButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launchFNButton.BackgroundImage")));
            this.launchFNButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.launchFNButton.BorderRadius = 0;
            this.launchFNButton.ButtonText = "Launch Fortnite";
            this.launchFNButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchFNButton.DisabledColor = System.Drawing.Color.White;
            this.launchFNButton.ForeColor = System.Drawing.Color.White;
            this.launchFNButton.Iconcolor = System.Drawing.Color.Transparent;
            this.launchFNButton.Iconimage = null;
            this.launchFNButton.Iconimage_right = null;
            this.launchFNButton.Iconimage_right_Selected = null;
            this.launchFNButton.Iconimage_Selected = null;
            this.launchFNButton.IconMarginLeft = 0;
            this.launchFNButton.IconMarginRight = 0;
            this.launchFNButton.IconRightVisible = true;
            this.launchFNButton.IconRightZoom = 0D;
            this.launchFNButton.IconVisible = true;
            this.launchFNButton.IconZoom = 50D;
            this.launchFNButton.IsTab = false;
            this.launchFNButton.Location = new System.Drawing.Point(82, 107);
            this.launchFNButton.Name = "launchFNButton";
            this.launchFNButton.Normalcolor = System.Drawing.Color.Transparent;
            this.launchFNButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.launchFNButton.OnHoverTextColor = System.Drawing.Color.White;
            this.launchFNButton.selected = false;
            this.launchFNButton.Size = new System.Drawing.Size(302, 26);
            this.launchFNButton.TabIndex = 19;
            this.launchFNButton.Text = "Launch Fortnite";
            this.launchFNButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.launchFNButton.Textcolor = System.Drawing.Color.White;
            this.launchFNButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchFNButton.Click += new System.EventHandler(this.fortniteButton_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.launchFNButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.checkPakButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.openPakButton;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this.restartButton;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this.backupButton;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // AdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(400, 152);
            this.Controls.Add(this.launchFNButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.openPakButton);
            this.Controls.Add(this.checkPakButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Settings";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton checkPakButton;
        private Bunifu.Framework.UI.BunifuFlatButton launchFNButton;
        private Bunifu.Framework.UI.BunifuFlatButton restartButton;
        private Bunifu.Framework.UI.BunifuFlatButton backupButton;
        private Bunifu.Framework.UI.BunifuFlatButton openPakButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}