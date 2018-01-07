using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetabling.DBAccess;
using Timetabling.Core;
using Timetabling.Objects;

namespace Timetabling
{
    public partial class LogonScreen : UI.BaseForm
    {
        public LogonScreen()
        {
            InitializeComponent();
        }

        private void B_Logon_Click(object sender, EventArgs e)
        {
            TutorAccessLayer TAL = new TutorAccessLayer(Session.Database);
            if (TAL.Login(TB_Username.Text, TB_Password.Text))
            {
                TutorHome TutorWin = new TutorHome();
                TutorWin.Show();
            }
            else
            {
                MessageBox.Show("Your credientials are invalid.", "Invalid Login");
            }
        }
    }
}
