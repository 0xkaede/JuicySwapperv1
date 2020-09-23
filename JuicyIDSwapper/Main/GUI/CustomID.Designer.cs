namespace JuicyIDSwapper.Main.GUI
{
    partial class CustomID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomID));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.revertButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.convertButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idListButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 372);
            this.Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom ID Swapper";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(634, 12);
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
            // revertButton
            // 
            this.revertButton.Activecolor = System.Drawing.Color.Transparent;
            this.revertButton.BackColor = System.Drawing.Color.Transparent;
            this.revertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("revertButton.BackgroundImage")));
            this.revertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.revertButton.BorderRadius = 0;
            this.revertButton.ButtonText = "Revert";
            this.revertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.revertButton.DisabledColor = System.Drawing.Color.White;
            this.revertButton.ForeColor = System.Drawing.Color.White;
            this.revertButton.Iconcolor = System.Drawing.Color.Transparent;
            this.revertButton.Iconimage = null;
            this.revertButton.Iconimage_right = null;
            this.revertButton.Iconimage_right_Selected = null;
            this.revertButton.Iconimage_Selected = null;
            this.revertButton.IconMarginLeft = 0;
            this.revertButton.IconMarginRight = 0;
            this.revertButton.IconRightVisible = true;
            this.revertButton.IconRightZoom = 0D;
            this.revertButton.IconVisible = true;
            this.revertButton.IconZoom = 50D;
            this.revertButton.IsTab = false;
            this.revertButton.Location = new System.Drawing.Point(567, 308);
            this.revertButton.Name = "revertButton";
            this.revertButton.Normalcolor = System.Drawing.Color.Transparent;
            this.revertButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.revertButton.OnHoverTextColor = System.Drawing.Color.White;
            this.revertButton.selected = false;
            this.revertButton.Size = new System.Drawing.Size(88, 28);
            this.revertButton.TabIndex = 16;
            this.revertButton.Text = "Revert";
            this.revertButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revertButton.Textcolor = System.Drawing.Color.White;
            this.revertButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Activecolor = System.Drawing.Color.Transparent;
            this.convertButton.BackColor = System.Drawing.Color.Transparent;
            this.convertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convertButton.BackgroundImage")));
            this.convertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertButton.BorderRadius = 0;
            this.convertButton.ButtonText = "Convert";
            this.convertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertButton.DisabledColor = System.Drawing.Color.White;
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Iconcolor = System.Drawing.Color.Transparent;
            this.convertButton.Iconimage = null;
            this.convertButton.Iconimage_right = null;
            this.convertButton.Iconimage_right_Selected = null;
            this.convertButton.Iconimage_Selected = null;
            this.convertButton.IconMarginLeft = 0;
            this.convertButton.IconMarginRight = 0;
            this.convertButton.IconRightVisible = true;
            this.convertButton.IconRightZoom = 0D;
            this.convertButton.IconVisible = true;
            this.convertButton.IconZoom = 50D;
            this.convertButton.IsTab = false;
            this.convertButton.Location = new System.Drawing.Point(473, 308);
            this.convertButton.Name = "convertButton";
            this.convertButton.Normalcolor = System.Drawing.Color.Transparent;
            this.convertButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.convertButton.OnHoverTextColor = System.Drawing.Color.White;
            this.convertButton.selected = false;
            this.convertButton.Size = new System.Drawing.Size(88, 28);
            this.convertButton.TabIndex = 19;
            this.convertButton.Text = "Convert";
            this.convertButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convertButton.Textcolor = System.Drawing.Color.White;
            this.convertButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.convertButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.revertButton;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 62);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "e.g. CID_346_Athena_Commando_M_DragonNinja";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(82, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 62);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "e.g. CID_029_Athena_Commando_F_Halloween";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "What item ID would you like to use for the swap?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "What item ID would you like to swap to?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 63);
            this.label4.TabIndex = 23;
            this.label4.Text = "To revert, simply type the same ID\'s\r\nused in the same boxes when you \r\nswapped, " +
    "and then press revert\r\n";
            // 
            // idListButton
            // 
            this.idListButton.Activecolor = System.Drawing.Color.Transparent;
            this.idListButton.BackColor = System.Drawing.Color.Transparent;
            this.idListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("idListButton.BackgroundImage")));
            this.idListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.idListButton.BorderRadius = 0;
            this.idListButton.ButtonText = "List of ID\'s";
            this.idListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idListButton.DisabledColor = System.Drawing.Color.White;
            this.idListButton.ForeColor = System.Drawing.Color.White;
            this.idListButton.Iconcolor = System.Drawing.Color.Transparent;
            this.idListButton.Iconimage = null;
            this.idListButton.Iconimage_right = null;
            this.idListButton.Iconimage_right_Selected = null;
            this.idListButton.Iconimage_Selected = null;
            this.idListButton.IconMarginLeft = 0;
            this.idListButton.IconMarginRight = 0;
            this.idListButton.IconRightVisible = true;
            this.idListButton.IconRightZoom = 0D;
            this.idListButton.IconVisible = true;
            this.idListButton.IconZoom = 50D;
            this.idListButton.IsTab = false;
            this.idListButton.Location = new System.Drawing.Point(473, 274);
            this.idListButton.Name = "idListButton";
            this.idListButton.Normalcolor = System.Drawing.Color.Transparent;
            this.idListButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.idListButton.OnHoverTextColor = System.Drawing.Color.White;
            this.idListButton.selected = false;
            this.idListButton.Size = new System.Drawing.Size(182, 28);
            this.idListButton.TabIndex = 24;
            this.idListButton.Text = "List of ID\'s";
            this.idListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idListButton.Textcolor = System.Drawing.Color.White;
            this.idListButton.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idListButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.idListButton;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(469, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 63);
            this.label5.TabIndex = 25;
            this.label5.Text = "If you require assistance,\r\nplease join the Discord \r\nand create a ticket.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // CustomID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(667, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idListButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom ID Swapper";
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
        private Bunifu.Framework.UI.BunifuFlatButton convertButton;
        private Bunifu.Framework.UI.BunifuFlatButton revertButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton idListButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}