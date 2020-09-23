namespace JuicyIDSwapper
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.displayItemShop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.displaySettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayCustomID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayEmotesPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayBackblingPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displaySkinsPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayDashPanel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 522);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.displayItemShop);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.bunifuImageButton2);
            this.Sidebar.Controls.Add(this.displaySettings);
            this.Sidebar.Controls.Add(this.displayCustomID);
            this.Sidebar.Controls.Add(this.displayEmotesPanel);
            this.Sidebar.Controls.Add(this.displayBackblingPanel);
            this.Sidebar.Controls.Add(this.displaySkinsPanel);
            this.Sidebar.Controls.Add(this.displayDashPanel);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Magenta;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 19);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 486);
            this.Sidebar.TabIndex = 0;
            // 
            // displayItemShop
            // 
            this.displayItemShop.Activecolor = System.Drawing.Color.Transparent;
            this.displayItemShop.BackColor = System.Drawing.Color.Transparent;
            this.displayItemShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayItemShop.BorderRadius = 0;
            this.displayItemShop.ButtonText = "      ITEM SHOP";
            this.displayItemShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displayItemShop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displayItemShop, BunifuAnimatorNS.DecorationType.None);
            this.displayItemShop.DisabledColor = System.Drawing.Color.Gray;
            this.displayItemShop.Iconcolor = System.Drawing.Color.Transparent;
            this.displayItemShop.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayItemShop.Iconimage")));
            this.displayItemShop.Iconimage_right = null;
            this.displayItemShop.Iconimage_right_Selected = null;
            this.displayItemShop.Iconimage_Selected = null;
            this.displayItemShop.IconMarginLeft = 0;
            this.displayItemShop.IconMarginRight = 0;
            this.displayItemShop.IconRightVisible = true;
            this.displayItemShop.IconRightZoom = 0D;
            this.displayItemShop.IconVisible = true;
            this.displayItemShop.IconZoom = 50D;
            this.displayItemShop.IsTab = false;
            this.displayItemShop.Location = new System.Drawing.Point(9, 309);
            this.displayItemShop.Name = "displayItemShop";
            this.displayItemShop.Normalcolor = System.Drawing.Color.Transparent;
            this.displayItemShop.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayItemShop.OnHoverTextColor = System.Drawing.Color.White;
            this.displayItemShop.selected = false;
            this.displayItemShop.Size = new System.Drawing.Size(252, 51);
            this.displayItemShop.TabIndex = 16;
            this.displayItemShop.Text = "      ITEM SHOP";
            this.displayItemShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayItemShop.Textcolor = System.Drawing.Color.White;
            this.displayItemShop.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayItemShop.Click += new System.EventHandler(this.displayItemShop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome, ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(13, 13);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // displaySettings
            // 
            this.displaySettings.Activecolor = System.Drawing.Color.Transparent;
            this.displaySettings.BackColor = System.Drawing.Color.Transparent;
            this.displaySettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displaySettings.BorderRadius = 0;
            this.displaySettings.ButtonText = "      SETTINGS";
            this.displaySettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displaySettings, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displaySettings, BunifuAnimatorNS.DecorationType.None);
            this.displaySettings.DisabledColor = System.Drawing.Color.Gray;
            this.displaySettings.Iconcolor = System.Drawing.Color.Transparent;
            this.displaySettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("displaySettings.Iconimage")));
            this.displaySettings.Iconimage_right = null;
            this.displaySettings.Iconimage_right_Selected = null;
            this.displaySettings.Iconimage_Selected = null;
            this.displaySettings.IconMarginLeft = 0;
            this.displaySettings.IconMarginRight = 0;
            this.displaySettings.IconRightVisible = true;
            this.displaySettings.IconRightZoom = 0D;
            this.displaySettings.IconVisible = true;
            this.displaySettings.IconZoom = 50D;
            this.displaySettings.IsTab = false;
            this.displaySettings.Location = new System.Drawing.Point(9, 423);
            this.displaySettings.Name = "displaySettings";
            this.displaySettings.Normalcolor = System.Drawing.Color.Transparent;
            this.displaySettings.OnHovercolor = System.Drawing.Color.Transparent;
            this.displaySettings.OnHoverTextColor = System.Drawing.Color.White;
            this.displaySettings.selected = false;
            this.displaySettings.Size = new System.Drawing.Size(252, 51);
            this.displaySettings.TabIndex = 14;
            this.displaySettings.Text = "      SETTINGS";
            this.displaySettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displaySettings.Textcolor = System.Drawing.Color.White;
            this.displaySettings.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySettings.Click += new System.EventHandler(this.displaySettings_Click);
            // 
            // displayCustomID
            // 
            this.displayCustomID.Activecolor = System.Drawing.Color.Transparent;
            this.displayCustomID.BackColor = System.Drawing.Color.Transparent;
            this.displayCustomID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayCustomID.BorderRadius = 0;
            this.displayCustomID.ButtonText = "      CUSTOM ID SWAPPER";
            this.displayCustomID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displayCustomID, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displayCustomID, BunifuAnimatorNS.DecorationType.None);
            this.displayCustomID.DisabledColor = System.Drawing.Color.Gray;
            this.displayCustomID.Iconcolor = System.Drawing.Color.Transparent;
            this.displayCustomID.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayCustomID.Iconimage")));
            this.displayCustomID.Iconimage_right = null;
            this.displayCustomID.Iconimage_right_Selected = null;
            this.displayCustomID.Iconimage_Selected = null;
            this.displayCustomID.IconMarginLeft = 0;
            this.displayCustomID.IconMarginRight = 0;
            this.displayCustomID.IconRightVisible = true;
            this.displayCustomID.IconRightZoom = 0D;
            this.displayCustomID.IconVisible = true;
            this.displayCustomID.IconZoom = 50D;
            this.displayCustomID.IsTab = false;
            this.displayCustomID.Location = new System.Drawing.Point(9, 366);
            this.displayCustomID.Name = "displayCustomID";
            this.displayCustomID.Normalcolor = System.Drawing.Color.Transparent;
            this.displayCustomID.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayCustomID.OnHoverTextColor = System.Drawing.Color.White;
            this.displayCustomID.selected = false;
            this.displayCustomID.Size = new System.Drawing.Size(252, 51);
            this.displayCustomID.TabIndex = 14;
            this.displayCustomID.Text = "      CUSTOM ID SWAPPER";
            this.displayCustomID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayCustomID.Textcolor = System.Drawing.Color.White;
            this.displayCustomID.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCustomID.Click += new System.EventHandler(this.displayCustomID_Click);
            // 
            // displayEmotesPanel
            // 
            this.displayEmotesPanel.Activecolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanel.BackColor = System.Drawing.Color.Transparent;
            this.displayEmotesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayEmotesPanel.BorderRadius = 0;
            this.displayEmotesPanel.ButtonText = "      EMOTES";
            this.displayEmotesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displayEmotesPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displayEmotesPanel, BunifuAnimatorNS.DecorationType.None);
            this.displayEmotesPanel.DisabledColor = System.Drawing.Color.Gray;
            this.displayEmotesPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayEmotesPanel.Iconimage")));
            this.displayEmotesPanel.Iconimage_right = null;
            this.displayEmotesPanel.Iconimage_right_Selected = null;
            this.displayEmotesPanel.Iconimage_Selected = null;
            this.displayEmotesPanel.IconMarginLeft = 0;
            this.displayEmotesPanel.IconMarginRight = 0;
            this.displayEmotesPanel.IconRightVisible = true;
            this.displayEmotesPanel.IconRightZoom = 0D;
            this.displayEmotesPanel.IconVisible = true;
            this.displayEmotesPanel.IconZoom = 50D;
            this.displayEmotesPanel.IsTab = false;
            this.displayEmotesPanel.Location = new System.Drawing.Point(9, 252);
            this.displayEmotesPanel.Name = "displayEmotesPanel";
            this.displayEmotesPanel.Normalcolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanel.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.displayEmotesPanel.selected = false;
            this.displayEmotesPanel.Size = new System.Drawing.Size(252, 51);
            this.displayEmotesPanel.TabIndex = 12;
            this.displayEmotesPanel.Text = "      EMOTES";
            this.displayEmotesPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayEmotesPanel.Textcolor = System.Drawing.Color.White;
            this.displayEmotesPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmotesPanel.Click += new System.EventHandler(this.displayEmotesPanel_Click);
            // 
            // displayBackblingPanel
            // 
            this.displayBackblingPanel.Activecolor = System.Drawing.Color.Transparent;
            this.displayBackblingPanel.BackColor = System.Drawing.Color.Transparent;
            this.displayBackblingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayBackblingPanel.BorderRadius = 0;
            this.displayBackblingPanel.ButtonText = "      BACKBLINGS";
            this.displayBackblingPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displayBackblingPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displayBackblingPanel, BunifuAnimatorNS.DecorationType.None);
            this.displayBackblingPanel.DisabledColor = System.Drawing.Color.Gray;
            this.displayBackblingPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.displayBackblingPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayBackblingPanel.Iconimage")));
            this.displayBackblingPanel.Iconimage_right = null;
            this.displayBackblingPanel.Iconimage_right_Selected = null;
            this.displayBackblingPanel.Iconimage_Selected = null;
            this.displayBackblingPanel.IconMarginLeft = 0;
            this.displayBackblingPanel.IconMarginRight = 0;
            this.displayBackblingPanel.IconRightVisible = true;
            this.displayBackblingPanel.IconRightZoom = 0D;
            this.displayBackblingPanel.IconVisible = true;
            this.displayBackblingPanel.IconZoom = 50D;
            this.displayBackblingPanel.IsTab = false;
            this.displayBackblingPanel.Location = new System.Drawing.Point(9, 195);
            this.displayBackblingPanel.Name = "displayBackblingPanel";
            this.displayBackblingPanel.Normalcolor = System.Drawing.Color.Transparent;
            this.displayBackblingPanel.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayBackblingPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.displayBackblingPanel.selected = false;
            this.displayBackblingPanel.Size = new System.Drawing.Size(252, 51);
            this.displayBackblingPanel.TabIndex = 10;
            this.displayBackblingPanel.Text = "      BACKBLINGS";
            this.displayBackblingPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayBackblingPanel.Textcolor = System.Drawing.Color.White;
            this.displayBackblingPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBackblingPanel.Click += new System.EventHandler(this.displayBackblingPanel_Click);
            // 
            // displaySkinsPanel
            // 
            this.displaySkinsPanel.Activecolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanel.BackColor = System.Drawing.Color.Transparent;
            this.displaySkinsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displaySkinsPanel.BorderRadius = 0;
            this.displaySkinsPanel.ButtonText = "      SKINS";
            this.displaySkinsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displaySkinsPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displaySkinsPanel, BunifuAnimatorNS.DecorationType.None);
            this.displaySkinsPanel.DisabledColor = System.Drawing.Color.Gray;
            this.displaySkinsPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("displaySkinsPanel.Iconimage")));
            this.displaySkinsPanel.Iconimage_right = null;
            this.displaySkinsPanel.Iconimage_right_Selected = null;
            this.displaySkinsPanel.Iconimage_Selected = null;
            this.displaySkinsPanel.IconMarginLeft = 0;
            this.displaySkinsPanel.IconMarginRight = 0;
            this.displaySkinsPanel.IconRightVisible = true;
            this.displaySkinsPanel.IconRightZoom = 0D;
            this.displaySkinsPanel.IconVisible = true;
            this.displaySkinsPanel.IconZoom = 50D;
            this.displaySkinsPanel.IsTab = false;
            this.displaySkinsPanel.Location = new System.Drawing.Point(9, 138);
            this.displaySkinsPanel.Name = "displaySkinsPanel";
            this.displaySkinsPanel.Normalcolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanel.OnHovercolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.displaySkinsPanel.selected = false;
            this.displaySkinsPanel.Size = new System.Drawing.Size(252, 51);
            this.displaySkinsPanel.TabIndex = 9;
            this.displaySkinsPanel.Text = "      SKINS";
            this.displaySkinsPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displaySkinsPanel.Textcolor = System.Drawing.Color.White;
            this.displaySkinsPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySkinsPanel.Click += new System.EventHandler(this.displaySkinsPanel_Click);
            // 
            // displayDashPanel
            // 
            this.displayDashPanel.Activecolor = System.Drawing.Color.Transparent;
            this.displayDashPanel.BackColor = System.Drawing.Color.Transparent;
            this.displayDashPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayDashPanel.BorderRadius = 0;
            this.displayDashPanel.ButtonText = "      DASHBOARD";
            this.displayDashPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.displayDashPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.displayDashPanel, BunifuAnimatorNS.DecorationType.None);
            this.displayDashPanel.DisabledColor = System.Drawing.Color.Gray;
            this.displayDashPanel.Iconcolor = System.Drawing.Color.Transparent;
            this.displayDashPanel.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayDashPanel.Iconimage")));
            this.displayDashPanel.Iconimage_right = null;
            this.displayDashPanel.Iconimage_right_Selected = null;
            this.displayDashPanel.Iconimage_Selected = null;
            this.displayDashPanel.IconMarginLeft = 0;
            this.displayDashPanel.IconMarginRight = 0;
            this.displayDashPanel.IconRightVisible = true;
            this.displayDashPanel.IconRightZoom = 0D;
            this.displayDashPanel.IconVisible = true;
            this.displayDashPanel.IconZoom = 50D;
            this.displayDashPanel.IsTab = false;
            this.displayDashPanel.Location = new System.Drawing.Point(9, 81);
            this.displayDashPanel.Name = "displayDashPanel";
            this.displayDashPanel.Normalcolor = System.Drawing.Color.Transparent;
            this.displayDashPanel.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayDashPanel.OnHoverTextColor = System.Drawing.Color.White;
            this.displayDashPanel.selected = false;
            this.displayDashPanel.Size = new System.Drawing.Size(252, 51);
            this.displayDashPanel.TabIndex = 8;
            this.displayDashPanel.Text = "      DASHBOARD";
            this.displayDashPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayDashPanel.Textcolor = System.Drawing.Color.White;
            this.displayDashPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDashPanel.Click += new System.EventHandler(this.displayDashPanel_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Juicy ID Swapper";
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(721, 522);
            this.Wrapper.TabIndex = 2;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Sidebar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1021, 522);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy ID Swapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton displayEmotesPanel;
        private Bunifu.Framework.UI.BunifuFlatButton displayBackblingPanel;
        private Bunifu.Framework.UI.BunifuFlatButton displaySkinsPanel;
        private Bunifu.Framework.UI.BunifuFlatButton displayDashPanel;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuFlatButton displayCustomID;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton displayItemShop;
        private Bunifu.Framework.UI.BunifuFlatButton displaySettings;
    }
}

