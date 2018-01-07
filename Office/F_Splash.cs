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
    public partial class F_Splash : UI.BaseForm
    {
        public F_Splash()
        {
            InitializeComponent();
        }

        private void B_Manager_Click(object sender, EventArgs e)
        {
            F_ManageRecords welcomeScrn = new F_ManageRecords();
            welcomeScrn.Show();
        }

        private void B_Tutor_Click(object sender, EventArgs e)
        {
            F_TutorLogin logonScrn = new F_TutorLogin();
            logonScrn.Show();
        }

        private void B_Report_Click(object sender, EventArgs e)
        {
            F_ReportView reportScrn = new F_ReportView();
            reportScrn.Show();
        }
    }
}
