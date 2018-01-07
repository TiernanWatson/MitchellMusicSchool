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
using Timetabling.Objects;
using Timetabling.DBAccess;

namespace Timetabling
{
    public partial class RegisterStudent : UI.BaseForm
    {
        // Used if updating a student record
        Student _existingStudent;

        // Constructor used to make a new student record
        public RegisterStudent()
        {
            InitializeComponent();
            _existingStudent = null;
        }

        // Constructor to be called when updating an existing record
        public RegisterStudent(Student existingStudent)
        {
            InitializeComponent();
            _existingStudent = existingStudent;
            WindowTitle = "Edit Student";
            PopulateForm();
        }

        private void PopulateForm()
        {
            // Fills out data for existing student
            TB_FName.Text = _existingStudent.Forename;
            TB_SName.Text = _existingStudent.Surname;
            TB_Add1.Text = _existingStudent.Address1;
            TB_Add2.Text = _existingStudent.Address2;
            TB_Town.Text = _existingStudent.Town;
            TB_PostCode.Text = _existingStudent.PostCode;
            TB_Telephone.Text = _existingStudent.Telephone;
            DTP_DOB.Value = _existingStudent.Dob;
            CB_AtSchool.Checked = _existingStudent.InSchool;
        }

        // Functionality

        private void B_Register_Click(object sender, EventArgs e)
        {
            StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
            Student result = MakeStudent();
            try
            {
                if (_existingStudent == null) // If not editing a student
                {
                    SAL.InsertStudent(result);
                }
                else // Updates student ID so existing record is updated
                {
                    result.Id = _existingStudent.Id;
                    SAL.UpdateStudent(result);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Student not added/updated.  There was an SQL issue: \n" + ex.Message, "SQL ERROR");
            }
            this.Close();
        }

        private void B_Enrol_Click(object sender, EventArgs e)
        {
            StudentAccessLayer SAL = new StudentAccessLayer(Session.Database);
            Student result = MakeStudent();
            try
            {
                if (_existingStudent == null) // If not editing a student
                {
                    result.Id = SAL.InsertStudent(result);
                }
                else // Updates student ID so existing record is updated
                {
                    result.Id = _existingStudent.Id;
                    SAL.UpdateStudent(result);
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Student not added/updated.  There was an SQL issue: \n" + ex.Message, "SQL ERROR");
                return;
            }
            EnrolStudent ES = new EnrolStudent(result);
            ES.Show();
        }

        // Collects data from form components and makes a student object
        private Student MakeStudent()
        {
            Student result = new Student();
            try
            {
                result.Forename = TB_FName.Text;
                result.Surname = TB_SName.Text;
                result.Address1 = TB_Add1.Text;
                result.Address2 = TB_Add2.Text;
                result.Town = TB_Town.Text;
                result.Telephone = TB_Telephone.Text;
                result.Dob = DTP_DOB.Value;
                result.PostCode = TB_PostCode.Text;
            }
            catch (ValidationException ve)
            {
                MessageBox.Show("There was an error in your data entry: " + ve.Message, "Formatting error");
            }
            return result;
        }
    }
}
