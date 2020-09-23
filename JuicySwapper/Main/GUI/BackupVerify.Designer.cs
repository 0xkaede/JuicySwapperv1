namespace JuicySwapper.Main.GUI
{
    partial class BackupVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupVerify));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backupButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.verifyButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backupWorker = new System.ComponentModel.BackgroundWorker();
            this.verifyWorker = new System.ComponentModel.BackgroundWorker();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 305);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Backup/Verify";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(493, 18);
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
            // backupButton
            // 
            this.backupButton.Activecolor = System.Drawing.Color.Transparent;
            this.backupButton.BackColor = System.Drawing.Color.Transparent;
            this.backupButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backupButton.BackgroundImage")));
            this.backupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backupButton.BorderRadius = 0;
            this.backupButton.ButtonText = "Backup";
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
            this.backupButton.Size = new System.Drawing.Size(142, 42);
            this.backupButton.TabIndex = 16;
            this.backupButton.Text = "Backup";
            this.backupButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backupButton.Textcolor = System.Drawing.Color.White;
            this.backupButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.Activecolor = System.Drawing.Color.Transparent;
            this.verifyButton.BackColor = System.Drawing.Color.Transparent;
            this.verifyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verifyButton.BackgroundImage")));
            this.verifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verifyButton.BorderRadius = 0;
            this.verifyButton.ButtonText = "Verify";
            this.verifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyButton.DisabledColor = System.Drawing.Color.White;
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Iconcolor = System.Drawing.Color.Transparent;
            this.verifyButton.Iconimage = null;
            this.verifyButton.Iconimage_right = null;
            this.verifyButton.Iconimage_right_Selected = null;
            this.verifyButton.Iconimage_Selected = null;
            this.verifyButton.IconMarginLeft = 0;
            this.verifyButton.IconMarginRight = 0;
            this.verifyButton.IconRightVisible = true;
            this.verifyButton.IconRightZoom = 0D;
            this.verifyButton.IconVisible = true;
            this.verifyButton.IconZoom = 50D;
            this.verifyButton.IsTab = false;
            this.verifyButton.Location = new System.Drawing.Point(82, 97);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Normalcolor = System.Drawing.Color.Transparent;
            this.verifyButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.verifyButton.OnHoverTextColor = System.Drawing.Color.White;
            this.verifyButton.selected = false;
            this.verifyButton.Size = new System.Drawing.Size(142, 42);
            this.verifyButton.TabIndex = 19;
            this.verifyButton.Text = "Verify";
            this.verifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verifyButton.Textcolor = System.Drawing.Color.White;
            this.verifyButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.verifyButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.backupButton;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(230, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 224);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // backupWorker
            // 
            this.backupWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backupWorker_DoWork);
            // 
            // verifyWorker
            // 
            this.verifyWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.verifyWorker_DoWork);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // BackupVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(526, 279);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Verify";
            this.Load += new System.EventHandler(this.AdvancedSettings_Load);
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
        private Bunifu.Framework.UI.BunifuFlatButton verifyButton;
        private Bunifu.Framework.UI.BunifuFlatButton backupButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backupWorker;
        private System.ComponentModel.BackgroundWorker verifyWorker;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}