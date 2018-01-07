using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Timetabling.UI
{
    public partial class BaseForm : Form
    {
        // Allows the window title to be changed in designer of child form
        public string WindowTitle
        {
            get { return L_WinTitle.Text; }
            set { L_WinTitle.Text = value; }
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        // Functionality

        private void B_WClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_WMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            Pen pen = new Pen(new Color());
            pen.Width = 1.00F;
            pen.Color = Color.Gray;

            e.Graphics.DrawRectangle(pen, rect);
            e.Graphics.DrawLine(Pens.LightGray, 5, P_WBorder.Height, P_WBorder.Width - 5, P_WBorder.Height);
        }

        #region WINDOW DRAGGING

        // Windows Message Constants
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Windows functions required
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // When mouse clicks on the top panel
        private void P_WBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}
