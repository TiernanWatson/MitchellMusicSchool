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
    public partial class F_TutorLogin : UI.BaseForm
    {
        public F_TutorLogin()
        {
            InitializeComponent();
        }

        private void B_Logon_Click(object sender, EventArgs e)
        {
            TutorAccessLayer TAL = new TutorAccessLayer(Session.Database);
            if (TAL.Login(TB_Username.Text, TB_Password.Text))
            {
                F_TutorHome TutorWin = new F_TutorHome();
                TutorWin.Show();
            }
            else
            {
                MessageBox.Show("Your credientials are invalid.", "Invalid Login");
            }
        }
    }
}
