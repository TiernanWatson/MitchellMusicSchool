using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetabling
{
    public partial class HomeScreen : UI.BaseForm
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void B_Manager_Click(object sender, EventArgs e)
        {
            WelcomeScreen welcomeScrn = new WelcomeScreen();
            welcomeScrn.Show();
        }

        private void B_Tutor_Click(object sender, EventArgs e)
        {
            LogonScreen logonScrn = new LogonScreen();
            logonScrn.Show();
        }

        private void B_Report_Click(object sender, EventArgs e)
        {
            AdminReport reportScrn = new AdminReport();
            reportScrn.Show();
        }
    }
}
