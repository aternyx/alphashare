
namespace alphashare
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.controlClose = new System.Windows.Forms.Button();
            this.controlMaximize = new System.Windows.Forms.Button();
            this.controlMinimize = new System.Windows.Forms.Button();
            this.controlOptions = new System.Windows.Forms.Button();
            this.MainStartFade = new System.Windows.Forms.Timer(this.components);
            this.MainCloseFade = new System.Windows.Forms.Timer(this.components);
            this.controlOptions_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.controlItem_GitRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.controlItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.SidebarLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarInfobar = new System.Windows.Forms.Panel();
            this.SidebarInfobarVersion = new System.Windows.Forms.Label();
            this.AlphaLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarSection_Home_Panel = new System.Windows.Forms.Panel();
            this.sidebarSection_Home_Label = new System.Windows.Forms.Label();
            this.sidebarSection_Home_Icon = new System.Windows.Forms.PictureBox();
            this.sidebarSection_Extractor_Panel = new System.Windows.Forms.Panel();
            this.sidebarSection_Extractor_Label = new System.Windows.Forms.Label();
            this.sidebarSection_Extractor_Icon = new System.Windows.Forms.PictureBox();
            this.sidebarSection_Torrent_Panel = new System.Windows.Forms.Panel();
            this.sidebarSection_Torrent_Label = new System.Windows.Forms.Label();
            this.sidebarSection_Torrent_Icon = new System.Windows.Forms.PictureBox();
            this.sidebarSection_Creator_Panel = new System.Windows.Forms.Panel();
            this.sidebarSection_Creator_Label = new System.Windows.Forms.Label();
            this.sidebarSection_Creator_Icon = new System.Windows.Forms.PictureBox();
            this.SidebarExpandTimer = new System.Windows.Forms.Timer(this.components);
            this.Section_Home = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolbarTitle = new System.Windows.Forms.Label();
            this.TitleSync = new System.Windows.Forms.Timer(this.components);
            this.SidebarCollapseTimer = new System.Windows.Forms.Timer(this.components);
            this.controlOptions_Menu.SuspendLayout();
            this.SidebarLayout.SuspendLayout();
            this.SidebarInfobar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaLogo)).BeginInit();
            this.sidebarSection_Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Home_Icon)).BeginInit();
            this.sidebarSection_Extractor_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Extractor_Icon)).BeginInit();
            this.sidebarSection_Torrent_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Torrent_Icon)).BeginInit();
            this.sidebarSection_Creator_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Creator_Icon)).BeginInit();
            this.Section_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlClose
            // 
            resources.ApplyResources(this.controlClose, "controlClose");
            this.controlClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.controlClose.Cursor = System.Windows.Forms.Cursors.Cross;
            this.controlClose.ForeColor = System.Drawing.Color.Red;
            this.controlClose.Name = "controlClose";
            this.controlClose.UseVisualStyleBackColor = false;
            this.controlClose.Click += new System.EventHandler(this.ControlCloseClick);
            // 
            // controlMaximize
            // 
            resources.ApplyResources(this.controlMaximize, "controlMaximize");
            this.controlMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.controlMaximize.Cursor = System.Windows.Forms.Cursors.Cross;
            this.controlMaximize.ForeColor = System.Drawing.Color.Yellow;
            this.controlMaximize.Name = "controlMaximize";
            this.controlMaximize.UseVisualStyleBackColor = false;
            this.controlMaximize.Click += new System.EventHandler(this.ControlMaximizeClick);
            // 
            // controlMinimize
            // 
            resources.ApplyResources(this.controlMinimize, "controlMinimize");
            this.controlMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.controlMinimize.Cursor = System.Windows.Forms.Cursors.Cross;
            this.controlMinimize.ForeColor = System.Drawing.Color.Lime;
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.UseVisualStyleBackColor = false;
            this.controlMinimize.Click += new System.EventHandler(this.ControlMinimizeClick);
            // 
            // controlOptions
            // 
            resources.ApplyResources(this.controlOptions, "controlOptions");
            this.controlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.controlOptions.Cursor = System.Windows.Forms.Cursors.Cross;
            this.controlOptions.ForeColor = System.Drawing.Color.Blue;
            this.controlOptions.Name = "controlOptions";
            this.controlOptions.UseVisualStyleBackColor = false;
            this.controlOptions.Click += new System.EventHandler(this.ControlOptionsClick);
            // 
            // MainStartFade
            // 
            this.MainStartFade.Enabled = true;
            this.MainStartFade.Interval = 5;
            this.MainStartFade.Tick += new System.EventHandler(this.StartFade);
            // 
            // MainCloseFade
            // 
            this.MainCloseFade.Interval = 20;
            this.MainCloseFade.Tick += new System.EventHandler(this.CloseFade);
            // 
            // controlOptions_Menu
            // 
            this.controlOptions_Menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.controlOptions_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlItem_GitRepo,
            this.controlItem_About});
            this.controlOptions_Menu.Name = "controlOptions_Menu";
            this.controlOptions_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            resources.ApplyResources(this.controlOptions_Menu, "controlOptions_Menu");
            // 
            // controlItem_GitRepo
            // 
            resources.ApplyResources(this.controlItem_GitRepo, "controlItem_GitRepo");
            this.controlItem_GitRepo.Name = "controlItem_GitRepo";
            this.controlItem_GitRepo.Click += new System.EventHandler(this.controlItem_GitRepo_Click);
            // 
            // controlItem_About
            // 
            resources.ApplyResources(this.controlItem_About, "controlItem_About");
            this.controlItem_About.Name = "controlItem_About";
            this.controlItem_About.Click += new System.EventHandler(this.controlItem_About_Click);
            // 
            // SidebarLayout
            // 
            this.SidebarLayout.BackColor = System.Drawing.Color.Black;
            this.SidebarLayout.BackgroundImage = global::alphashare.Properties.Resources.theme_bluewave;
            resources.ApplyResources(this.SidebarLayout, "SidebarLayout");
            this.SidebarLayout.Controls.Add(this.SidebarInfobar);
            this.SidebarLayout.Controls.Add(this.panel1);
            this.SidebarLayout.Controls.Add(this.sidebarSection_Home_Panel);
            this.SidebarLayout.Controls.Add(this.sidebarSection_Extractor_Panel);
            this.SidebarLayout.Controls.Add(this.sidebarSection_Torrent_Panel);
            this.SidebarLayout.Controls.Add(this.sidebarSection_Creator_Panel);
            this.SidebarLayout.Name = "SidebarLayout";
            // 
            // SidebarInfobar
            // 
            this.SidebarInfobar.BackColor = System.Drawing.Color.Transparent;
            this.SidebarInfobar.Controls.Add(this.SidebarInfobarVersion);
            this.SidebarInfobar.Controls.Add(this.AlphaLogo);
            resources.ApplyResources(this.SidebarInfobar, "SidebarInfobar");
            this.SidebarInfobar.Name = "SidebarInfobar";
            // 
            // SidebarInfobarVersion
            // 
            resources.ApplyResources(this.SidebarInfobarVersion, "SidebarInfobarVersion");
            this.SidebarInfobarVersion.ForeColor = System.Drawing.Color.White;
            this.SidebarInfobarVersion.Name = "SidebarInfobarVersion";
            // 
            // AlphaLogo
            // 
            resources.ApplyResources(this.AlphaLogo, "AlphaLogo");
            this.AlphaLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlphaLogo.Image = global::alphashare.Properties.Resources.alpha;
            this.AlphaLogo.Name = "AlphaLogo";
            this.AlphaLogo.TabStop = false;
            this.AlphaLogo.Click += new System.EventHandler(this.Sidebar01);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // sidebarSection_Home_Panel
            // 
            this.sidebarSection_Home_Panel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarSection_Home_Panel.Controls.Add(this.sidebarSection_Home_Label);
            this.sidebarSection_Home_Panel.Controls.Add(this.sidebarSection_Home_Icon);
            resources.ApplyResources(this.sidebarSection_Home_Panel, "sidebarSection_Home_Panel");
            this.sidebarSection_Home_Panel.Name = "sidebarSection_Home_Panel";
            // 
            // sidebarSection_Home_Label
            // 
            resources.ApplyResources(this.sidebarSection_Home_Label, "sidebarSection_Home_Label");
            this.sidebarSection_Home_Label.ForeColor = System.Drawing.Color.White;
            this.sidebarSection_Home_Label.Name = "sidebarSection_Home_Label";
            // 
            // sidebarSection_Home_Icon
            // 
            resources.ApplyResources(this.sidebarSection_Home_Icon, "sidebarSection_Home_Icon");
            this.sidebarSection_Home_Icon.Image = global::alphashare.Properties.Resources.icon_home;
            this.sidebarSection_Home_Icon.Name = "sidebarSection_Home_Icon";
            this.sidebarSection_Home_Icon.TabStop = false;
            // 
            // sidebarSection_Extractor_Panel
            // 
            this.sidebarSection_Extractor_Panel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarSection_Extractor_Panel.Controls.Add(this.sidebarSection_Extractor_Label);
            this.sidebarSection_Extractor_Panel.Controls.Add(this.sidebarSection_Extractor_Icon);
            resources.ApplyResources(this.sidebarSection_Extractor_Panel, "sidebarSection_Extractor_Panel");
            this.sidebarSection_Extractor_Panel.Name = "sidebarSection_Extractor_Panel";
            // 
            // sidebarSection_Extractor_Label
            // 
            resources.ApplyResources(this.sidebarSection_Extractor_Label, "sidebarSection_Extractor_Label");
            this.sidebarSection_Extractor_Label.ForeColor = System.Drawing.Color.White;
            this.sidebarSection_Extractor_Label.Name = "sidebarSection_Extractor_Label";
            // 
            // sidebarSection_Extractor_Icon
            // 
            resources.ApplyResources(this.sidebarSection_Extractor_Icon, "sidebarSection_Extractor_Icon");
            this.sidebarSection_Extractor_Icon.Image = global::alphashare.Properties.Resources.icon_extract;
            this.sidebarSection_Extractor_Icon.Name = "sidebarSection_Extractor_Icon";
            this.sidebarSection_Extractor_Icon.TabStop = false;
            // 
            // sidebarSection_Torrent_Panel
            // 
            this.sidebarSection_Torrent_Panel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarSection_Torrent_Panel.Controls.Add(this.sidebarSection_Torrent_Label);
            this.sidebarSection_Torrent_Panel.Controls.Add(this.sidebarSection_Torrent_Icon);
            resources.ApplyResources(this.sidebarSection_Torrent_Panel, "sidebarSection_Torrent_Panel");
            this.sidebarSection_Torrent_Panel.Name = "sidebarSection_Torrent_Panel";
            // 
            // sidebarSection_Torrent_Label
            // 
            resources.ApplyResources(this.sidebarSection_Torrent_Label, "sidebarSection_Torrent_Label");
            this.sidebarSection_Torrent_Label.ForeColor = System.Drawing.Color.White;
            this.sidebarSection_Torrent_Label.Name = "sidebarSection_Torrent_Label";
            // 
            // sidebarSection_Torrent_Icon
            // 
            resources.ApplyResources(this.sidebarSection_Torrent_Icon, "sidebarSection_Torrent_Icon");
            this.sidebarSection_Torrent_Icon.Image = global::alphashare.Properties.Resources.icon_torrent;
            this.sidebarSection_Torrent_Icon.Name = "sidebarSection_Torrent_Icon";
            this.sidebarSection_Torrent_Icon.TabStop = false;
            // 
            // sidebarSection_Creator_Panel
            // 
            this.sidebarSection_Creator_Panel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarSection_Creator_Panel.Controls.Add(this.sidebarSection_Creator_Label);
            this.sidebarSection_Creator_Panel.Controls.Add(this.sidebarSection_Creator_Icon);
            resources.ApplyResources(this.sidebarSection_Creator_Panel, "sidebarSection_Creator_Panel");
            this.sidebarSection_Creator_Panel.Name = "sidebarSection_Creator_Panel";
            // 
            // sidebarSection_Creator_Label
            // 
            resources.ApplyResources(this.sidebarSection_Creator_Label, "sidebarSection_Creator_Label");
            this.sidebarSection_Creator_Label.ForeColor = System.Drawing.Color.White;
            this.sidebarSection_Creator_Label.Name = "sidebarSection_Creator_Label";
            // 
            // sidebarSection_Creator_Icon
            // 
            resources.ApplyResources(this.sidebarSection_Creator_Icon, "sidebarSection_Creator_Icon");
            this.sidebarSection_Creator_Icon.Image = global::alphashare.Properties.Resources.icon_create;
            this.sidebarSection_Creator_Icon.Name = "sidebarSection_Creator_Icon";
            this.sidebarSection_Creator_Icon.TabStop = false;
            // 
            // SidebarExpandTimer
            // 
            this.SidebarExpandTimer.Interval = 1;
            this.SidebarExpandTimer.Tick += new System.EventHandler(this.SidebarExpandTimerTick);
            // 
            // Section_Home
            // 
            resources.ApplyResources(this.Section_Home, "Section_Home");
            this.Section_Home.Controls.Add(this.pictureBox2);
            this.Section_Home.Controls.Add(this.label1);
            this.Section_Home.Controls.Add(this.pictureBox1);
            this.Section_Home.Name = "Section_Home";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::alphashare.Properties.Resources.alpha;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::alphashare.Properties.Resources.icon_setting1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // toolbarTitle
            // 
            resources.ApplyResources(this.toolbarTitle, "toolbarTitle");
            this.toolbarTitle.ForeColor = System.Drawing.Color.White;
            this.toolbarTitle.Name = "toolbarTitle";
            // 
            // TitleSync
            // 
            this.TitleSync.Enabled = true;
            this.TitleSync.Interval = 121;
            this.TitleSync.Tick += new System.EventHandler(this.TitleSync_Tick);
            // 
            // SidebarCollapseTimer
            // 
            this.SidebarCollapseTimer.Interval = 1;
            this.SidebarCollapseTimer.Tick += new System.EventHandler(this.SidebarCollapseTimerTick);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.controlClose);
            this.Controls.Add(this.controlMaximize);
            this.Controls.Add(this.controlMinimize);
            this.Controls.Add(this.controlOptions);
            this.Controls.Add(this.SidebarLayout);
            this.Controls.Add(this.toolbarTitle);
            this.Controls.Add(this.Section_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Main_Load);
            this.controlOptions_Menu.ResumeLayout(false);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarInfobar.ResumeLayout(false);
            this.SidebarInfobar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaLogo)).EndInit();
            this.sidebarSection_Home_Panel.ResumeLayout(false);
            this.sidebarSection_Home_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Home_Icon)).EndInit();
            this.sidebarSection_Extractor_Panel.ResumeLayout(false);
            this.sidebarSection_Extractor_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Extractor_Icon)).EndInit();
            this.sidebarSection_Torrent_Panel.ResumeLayout(false);
            this.sidebarSection_Torrent_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Torrent_Icon)).EndInit();
            this.sidebarSection_Creator_Panel.ResumeLayout(false);
            this.sidebarSection_Creator_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSection_Creator_Icon)).EndInit();
            this.Section_Home.ResumeLayout(false);
            this.Section_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button controlClose;
        private System.Windows.Forms.FlowLayoutPanel SidebarLayout;
        private System.Windows.Forms.Button controlMaximize;
        private System.Windows.Forms.Button controlMinimize;
        private System.Windows.Forms.Button controlOptions;
        private System.Windows.Forms.Panel SidebarInfobar;
        private System.Windows.Forms.PictureBox AlphaLogo;
        private System.Windows.Forms.Label SidebarInfobarVersion;
        private System.Windows.Forms.Timer MainStartFade;
        private System.Windows.Forms.Timer MainCloseFade;
        private System.Windows.Forms.ContextMenuStrip controlOptions_Menu;
        private System.Windows.Forms.ToolStripMenuItem controlItem_GitRepo;
        private System.Windows.Forms.ToolStripMenuItem controlItem_About;
        private System.Windows.Forms.Panel sidebarSection_Home_Panel;
        private System.Windows.Forms.PictureBox sidebarSection_Home_Icon;
        private System.Windows.Forms.Label sidebarSection_Home_Label;
        private System.Windows.Forms.Panel sidebarSection_Extractor_Panel;
        private System.Windows.Forms.Label sidebarSection_Extractor_Label;
        private System.Windows.Forms.PictureBox sidebarSection_Extractor_Icon;
        private System.Windows.Forms.Panel sidebarSection_Torrent_Panel;
        private System.Windows.Forms.Label sidebarSection_Torrent_Label;
        private System.Windows.Forms.PictureBox sidebarSection_Torrent_Icon;
        private System.Windows.Forms.Panel sidebarSection_Creator_Panel;
        private System.Windows.Forms.Label sidebarSection_Creator_Label;
        private System.Windows.Forms.PictureBox sidebarSection_Creator_Icon;
        private System.Windows.Forms.Timer SidebarExpandTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Section_Home;
        private System.Windows.Forms.Label toolbarTitle;
        private System.Windows.Forms.Timer TitleSync;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer SidebarCollapseTimer;
    }
}

