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
    public partial class AdminReport : UI.BaseForm
    {
        public AdminReport()
        {
            InitializeComponent();
        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDS.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.reportDS.Student);

            this.reportViewer1.RefreshReport();
        }
    }
}
