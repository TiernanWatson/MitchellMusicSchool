using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetabling.Core;
using Timetabling.DBAccess;
using Timetabling.Objects;

namespace Timetabling
{
    public partial class WelcomeScreen : UI.BaseForm
    {
        DataTable _dt;
        List<Student> _searchResults; // Placed here to avoid unnecessary SQL later on

        public WelcomeScreen()
        {
            InitializeComponent();
            _dt = new DataTable();
            _dt.Columns.Add("Id");
            _dt.Columns.Add("Forename");
            _dt.Columns.Add("Surname");
            _dt.Columns.Add("Address 1");
            _dt.Columns.Add("Address 2");
            _dt.Columns.Add("Town");
            _dt.Columns.Add("Post Code");
            _dt.Columns.Add("Telephone");
            _dt.Columns.Add("Date of Birth");
            _dt.Columns.Add("In School?");
            DGV_Students.DataSource = _dt;
        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            // Method that initiates the search for students
            StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
            _searchResults = new List<Student>();
            switch (CB_SearchBy.SelectedIndex)
            {
                case 1:
                    _searchResults = SAL.GetStudentByForename(TB_StudentSearch.Text);
                    break;
                case 2:
                    _searchResults = SAL.GetStudentBySurname(TB_StudentSearch.Text);
                    break;
                default:
                    _searchResults.Add(SAL.GetStudentById(Convert.ToInt32(TB_StudentSearch.Text)));
                    break;
            }
            PopulateDT(_searchResults); 
        }

        private void PopulateDT(List<Student> students)
        {
            _dt.Rows.Clear();
            // Populates DataTable
            foreach (Student s in students)
            {
                if (s != null)
                    _dt.Rows.Add(s.Id, s.Forename, s.Surname, s.Address1, s.Address2, s.Town, s.PostCode, s.Telephone, s.Dob, s.InSchool);
            }
        }

        // Buttons

        private void B_EnrolStudent_Click(object sender, EventArgs e)
        {
            // Makes sure that only one student is selected
            if (DGV_Students.SelectedRows.Count == 1)
            {
                StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
                EnrolStudent ES = new EnrolStudent(SAL.GetStudentById(Convert.ToInt32(DGV_Students.SelectedRows[0].Cells[0].Value.ToString())));
                ES.Show();  // Opening enrolment form
            }
            else
            {
                MessageBox.Show("You have selected more than 1 or not students.");
            }
        }

        private void B_EditStudent_Click(object sender, EventArgs e)
        {
            if (DGV_Students.SelectedRows.Count == 1)
            {
                StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
                RegisterStudent RS = new RegisterStudent(SAL.GetStudentById(Convert.ToInt32(DGV_Students.SelectedRows[0].Cells[0].Value.ToString())));
                RS.Show();  // Register form doubles up as edit form
            }
            else
            {
                MessageBox.Show("You have selected more than 1 or 0 students.");
            }
        }

        private void B_DeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
                if (SAL.DeleteStudent(SAL.GetStudentById(Convert.ToInt32(DGV_Students.SelectedRows[0].Cells[0].Value.ToString()))))
                {
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _dt.Rows.Clear();
                }
                else
                { 
                    MessageBox.Show("Could not delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
