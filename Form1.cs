using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrarNative;
//

/// ALPHASHARE
/// Editing the program without permission from mgXzyy is prohibited.
/// version alpha0.01 graphic test

namespace alphashare
{
    public partial class Main : Form
    {
        int CurrentSection = 0;                     // current       \\
        readonly int HomeSection = 0;           // home          \\
        readonly int ExtractorSection = 1;      // extractor    \\
        readonly int CreatorSection = 2;           // creator       \\
        readonly int TorrentSection = 3;             // torrent       \\

        // Start Drag and Shadow
        private bool Drag;
        private int MouseX;
        private int MouseY;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1);
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) => Drag = false;
        // End Drag and Shadow
        public Main() { InitializeComponent(); }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        // Start Controls
        /* Minimize */    private void ControlMinimizeClick(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        /* Close */         private void ControlCloseClick(object sender, EventArgs e) { MainCloseFade.Start(); }
        /* Maximize */   private void ControlMaximizeClick(object sender, EventArgs e) 
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.controlMaximize.Text = "2";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.controlMaximize.Text = "1";
            }
        } /* End Maximize */
        // Start Fade
        private void StartFade(object sender, EventArgs e)
        {
            if ( Opacity == 1 ) { MainStartFade.Stop(); }
            else { Opacity += .1; }
        }
        private void CloseFade(object sender, EventArgs e)
        {
            if ( Opacity == 0 ) { System.Windows.Forms.Application.Exit(); }
            else { Opacity -= .05; }
        }
        // End Fade //


        // Start controlOptions Context Menu
        /*Open*/ private void ControlOptionsClick(object sender, EventArgs e) { controlOptions_Menu.Show( MousePosition.X, MousePosition.Y ) ;}
        /*AboutForm*/private void controlItem_About_Click(object sender, EventArgs e){AboutForm abf = new AboutForm();abf.Show();}
        /*GItRepo*/private void controlItem_GitRepo_Click(object sender, EventArgs e) {System.Diagnostics.Process.Start("https://github.com/mariangamingX/alphashare");}


    }
}
