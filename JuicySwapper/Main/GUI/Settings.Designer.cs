namespace JuicySwapper.Main.GUI
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectPakPathButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.discordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateCheckButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.resetConfigButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.convertedItemsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.advancedButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pakPathTextbox = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 205);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to paks folder:";
            // 
            // selectPakPathButton
            // 
            this.selectPakPathButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPakPathButton.Image = ((System.Drawing.Image)(resources.GetObject("selectPakPathButton.Image")));
            this.selectPakPathButton.ImageActive = null;
            this.selectPakPathButton.Location = new System.Drawing.Point(447, 35);
            this.selectPakPathButton.Name = "selectPakPathButton";
            this.selectPakPathButton.Size = new System.Drawing.Size(40, 34);
            this.selectPakPathButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectPakPathButton.TabIndex = 4;
            this.selectPakPathButton.TabStop = false;
            this.selectPakPathButton.Zoom = 0;
            this.selectPakPathButton.Click += new System.EventHandler(this.selectPakPathButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(467, 12);
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
            // discordButton
            // 
            this.discordButton.Activecolor = System.Drawing.Color.Transparent;
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discordButton.BackgroundImage")));
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discordButton.BorderRadius = 0;
            this.discordButton.ButtonText = "Join Discord";
            this.discordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordButton.DisabledColor = System.Drawing.Color.White;
            this.discordButton.ForeColor = System.Drawing.Color.White;
            this.discordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.discordButton.Iconimage = null;
            this.discordButton.Iconimage_right = null;
            this.discordButton.Iconimage_right_Selected = null;
            this.discordButton.Iconimage_Selected = null;
            this.discordButton.IconMarginLeft = 0;
            this.discordButton.IconMarginRight = 0;
            this.discordButton.IconRightVisible = true;
            this.discordButton.IconRightZoom = 0D;
            this.discordButton.IconVisible = true;
            this.discordButton.IconZoom = 50D;
            this.discordButton.IsTab = false;
            this.discordButton.Location = new System.Drawing.Point(240, 108);
            this.discordButton.Name = "discordButton";
            this.discordButton.Normalcolor = System.Drawing.Color.Transparent;
            this.discordButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.discordButton.OnHoverTextColor = System.Drawing.Color.White;
            this.discordButton.selected = false;
            this.discordButton.Size = new System.Drawing.Size(144, 26);
            this.discordButton.TabIndex = 9;
            this.discordButton.Text = "Join Discord";
            this.discordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discordButton.Textcolor = System.Drawing.Color.White;
            this.discordButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // updateCheckButton
            // 
            this.updateCheckButton.Activecolor = System.Drawing.Color.Transparent;
            this.updateCheckButton.BackColor = System.Drawing.Color.Transparent;
            this.updateCheckButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCheckButton.BackgroundImage")));
            this.updateCheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateCheckButton.BorderRadius = 0;
            this.updateCheckButton.ButtonText = "Check For Updates";
            this.updateCheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCheckButton.DisabledColor = System.Drawing.Color.White;
            this.updateCheckButton.ForeColor = System.Drawing.Color.White;
            this.updateCheckButton.Iconcolor = System.Drawing.Color.Transparent;
            this.updateCheckButton.Iconimage = null;
            this.updateCheckButton.Iconimage_right = null;
            this.updateCheckButton.Iconimage_right_Selected = null;
            this.updateCheckButton.Iconimage_Selected = null;
            this.updateCheckButton.IconMarginLeft = 0;
            this.updateCheckButton.IconMarginRight = 0;
            this.updateCheckButton.IconRightVisible = true;
            this.updateCheckButton.IconRightZoom = 0D;
            this.updateCheckButton.IconVisible = true;
            this.updateCheckButton.IconZoom = 50D;
            this.updateCheckButton.IsTab = false;
            this.updateCheckButton.Location = new System.Drawing.Point(82, 108);
            this.updateCheckButton.Name = "updateCheckButton";
            this.updateCheckButton.Normalcolor = System.Drawing.Color.Transparent;
            this.updateCheckButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.updateCheckButton.OnHoverTextColor = System.Drawing.Color.White;
            this.updateCheckButton.selected = false;
            this.updateCheckButton.Size = new System.Drawing.Size(144, 26);
            this.updateCheckButton.TabIndex = 16;
            this.updateCheckButton.Text = "Check For Updates";
            this.updateCheckButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateCheckButton.Textcolor = System.Drawing.Color.White;
            this.updateCheckButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCheckButton.Click += new System.EventHandler(this.updateCheckButton_Click);
            // 
            // resetConfigButton
            // 
            this.resetConfigButton.Activecolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.BackColor = System.Drawing.Color.Transparent;
            this.resetConfigButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetConfigButton.BackgroundImage")));
            this.resetConfigButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetConfigButton.BorderRadius = 0;
            this.resetConfigButton.ButtonText = "Reset Config";
            this.resetConfigButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetConfigButton.DisabledColor = System.Drawing.Color.White;
            this.resetConfigButton.ForeColor = System.Drawing.Color.White;
            this.resetConfigButton.Iconcolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.Iconimage = null;
            this.resetConfigButton.Iconimage_right = null;
            this.resetConfigButton.Iconimage_right_Selected = null;
            this.resetConfigButton.Iconimage_Selected = null;
            this.resetConfigButton.IconMarginLeft = 0;
            this.resetConfigButton.IconMarginRight = 0;
            this.resetConfigButton.IconRightVisible = true;
            this.resetConfigButton.IconRightZoom = 0D;
            this.resetConfigButton.IconVisible = true;
            this.resetConfigButton.IconZoom = 50D;
            this.resetConfigButton.IsTab = false;
            this.resetConfigButton.Location = new System.Drawing.Point(82, 76);
            this.resetConfigButton.Name = "resetConfigButton";
            this.resetConfigButton.Normalcolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.resetConfigButton.OnHoverTextColor = System.Drawing.Color.White;
            this.resetConfigButton.selected = false;
            this.resetConfigButton.Size = new System.Drawing.Size(144, 26);
            this.resetConfigButton.TabIndex = 17;
            this.resetConfigButton.Text = "Reset Config";
            this.resetConfigButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetConfigButton.Textcolor = System.Drawing.Color.White;
            this.resetConfigButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetConfigButton.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // convertedItemsButton
            // 
            this.convertedItemsButton.Activecolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.BackColor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convertedItemsButton.BackgroundImage")));
            this.convertedItemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertedItemsButton.BorderRadius = 0;
            this.convertedItemsButton.ButtonText = "Converted Items List";
            this.convertedItemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertedItemsButton.DisabledColor = System.Drawing.Color.White;
            this.convertedItemsButton.ForeColor = System.Drawing.Color.White;
            this.convertedItemsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.Iconimage = null;
            this.convertedItemsButton.Iconimage_right = null;
            this.convertedItemsButton.Iconimage_right_Selected = null;
            this.convertedItemsButton.Iconimage_Selected = null;
            this.convertedItemsButton.IconMarginLeft = 0;
            this.convertedItemsButton.IconMarginRight = 0;
            this.convertedItemsButton.IconRightVisible = true;
            this.convertedItemsButton.IconRightZoom = 0D;
            this.convertedItemsButton.IconVisible = true;
            this.convertedItemsButton.IconZoom = 50D;
            this.convertedItemsButton.IsTab = false;
            this.convertedItemsButton.Location = new System.Drawing.Point(240, 76);
            this.convertedItemsButton.Name = "convertedItemsButton";
            this.convertedItemsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.convertedItemsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.convertedItemsButton.selected = false;
            this.convertedItemsButton.Size = new System.Drawing.Size(144, 26);
            this.convertedItemsButton.TabIndex = 18;
            this.convertedItemsButton.Text = "Converted Items List";
            this.convertedItemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convertedItemsButton.Textcolor = System.Drawing.Color.White;
            this.convertedItemsButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedItemsButton.Click += new System.EventHandler(this.convertedItemsButton_Click);
            // 
            // advancedButton
            // 
            this.advancedButton.Activecolor = System.Drawing.Color.Transparent;
            this.advancedButton.BackColor = System.Drawing.Color.Transparent;
            this.advancedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advancedButton.BackgroundImage")));
            this.advancedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.advancedButton.BorderRadius = 0;
            this.advancedButton.ButtonText = "Advanced Settings";
            this.advancedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.advancedButton.DisabledColor = System.Drawing.Color.White;
            this.advancedButton.ForeColor = System.Drawing.Color.White;
            this.advancedButton.Iconcolor = System.Drawing.Color.Transparent;
            this.advancedButton.Iconimage = null;
            this.advancedButton.Iconimage_right = null;
            this.advancedButton.Iconimage_right_Selected = null;
            this.advancedButton.Iconimage_Selected = null;
            this.advancedButton.IconMarginLeft = 0;
            this.advancedButton.IconMarginRight = 0;
            this.advancedButton.IconRightVisible = true;
            this.advancedButton.IconRightZoom = 0D;
            this.advancedButton.IconVisible = true;
            this.advancedButton.IconZoom = 50D;
            this.advancedButton.IsTab = false;
            this.advancedButton.Location = new System.Drawing.Point(82, 140);
            this.advancedButton.Name = "advancedButton";
            this.advancedButton.Normalcolor = System.Drawing.Color.Transparent;
            this.advancedButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.advancedButton.OnHoverTextColor = System.Drawing.Color.White;
            this.advancedButton.selected = false;
            this.advancedButton.Size = new System.Drawing.Size(302, 26);
            this.advancedButton.TabIndex = 19;
            this.advancedButton.Text = "Advanced Settings";
            this.advancedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advancedButton.Textcolor = System.Drawing.Color.White;
            this.advancedButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedButton.Click += new System.EventHandler(this.advancedButton_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(82, 61);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(364, 10);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pakPathTextbox
            // 
            this.pakPathTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.pakPathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pakPathTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pakPathTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakPathTextbox.ForeColor = System.Drawing.Color.White;
            this.pakPathTextbox.Location = new System.Drawing.Point(82, 44);
            this.pakPathTextbox.Name = "pakPathTextbox";
            this.pakPathTextbox.ReadOnly = true;
            this.pakPathTextbox.Size = new System.Drawing.Size(364, 16);
            this.pakPathTextbox.TabIndex = 21;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.advancedButton;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.discordButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.updateCheckButton;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this.convertedItemsButton;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this.resetConfigButton;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 5;
            this.bunifuElipse7.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(498, 179);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pakPathTextbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.advancedButton);
            this.Controls.Add(this.convertedItemsButton);
            this.Controls.Add(this.resetConfigButton);
            this.Controls.Add(this.updateCheckButton);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectPakPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton selectPakPathButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton discordButton;
        private Bunifu.Framework.UI.BunifuFlatButton advancedButton;
        private Bunifu.Framework.UI.BunifuFlatButton convertedItemsButton;
        private Bunifu.Framework.UI.BunifuFlatButton resetConfigButton;
        private Bunifu.Framework.UI.BunifuFlatButton updateCheckButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox pakPathTextbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}