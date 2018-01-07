namespace Timetabling
{
    partial class WelcomeScreen
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
            this.P_ViewStudent = new System.Windows.Forms.Panel();
            this.L_Instruction = new System.Windows.Forms.Label();
            this.DGV_Students = new System.Windows.Forms.DataGridView();
            this.B_Search = new System.Windows.Forms.Button();
            this.CB_SearchBy = new System.Windows.Forms.ComboBox();
            this.TB_StudentSearch = new System.Windows.Forms.TextBox();
            this.L_StudentSearch = new System.Windows.Forms.Label();
            this.B_RegisterStudent = new System.Windows.Forms.Button();
            this.B_EnrolStudent = new System.Windows.Forms.Button();
            this.B_EditStudent = new System.Windows.Forms.Button();
            this.B_DeleteStudent = new System.Windows.Forms.Button();
            this.P_ViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // P_ViewStudent
            // 
            this.P_ViewStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.P_ViewStudent.Controls.Add(this.L_Instruction);
            this.P_ViewStudent.Controls.Add(this.DGV_Students);
            this.P_ViewStudent.Controls.Add(this.B_Search);
            this.P_ViewStudent.Controls.Add(this.CB_SearchBy);
            this.P_ViewStudent.Controls.Add(this.TB_StudentSearch);
            this.P_ViewStudent.Controls.Add(this.L_StudentSearch);
            this.P_ViewStudent.Location = new System.Drawing.Point(7, 56);
            this.P_ViewStudent.Name = "P_ViewStudent";
            this.P_ViewStudent.Size = new System.Drawing.Size(500, 242);
            this.P_ViewStudent.TabIndex = 1;
            // 
            // L_Instruction
            // 
            this.L_Instruction.AutoSize = true;
            this.L_Instruction.ForeColor = System.Drawing.Color.DimGray;
            this.L_Instruction.Location = new System.Drawing.Point(7, 217);
            this.L_Instruction.Name = "L_Instruction";
            this.L_Instruction.Size = new System.Drawing.Size(192, 13);
            this.L_Instruction.TabIndex = 22;
            this.L_Instruction.Text = "You cannot edit a student from here";
            // 
            // DGV_Students
            // 
            this.DGV_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Students.Location = new System.Drawing.Point(7, 60);
            this.DGV_Students.Name = "DGV_Students";
            this.DGV_Students.Size = new System.Drawing.Size(483, 150);
            this.DGV_Students.TabIndex = 21;
            // 
            // B_Search
            // 
            this.B_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Search.Location = new System.Drawing.Point(404, 29);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(86, 26);
            this.B_Search.TabIndex = 20;
            this.B_Search.Text = "Search";
            this.B_Search.UseVisualStyleBackColor = true;
            this.B_Search.Click += new System.EventHandler(this.B_Search_Click);
            // 
            // CB_SearchBy
            // 
            this.CB_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SearchBy.FormattingEnabled = true;
            this.CB_SearchBy.Items.AddRange(new object[] {
            "Student ID",
            "Forename",
            "Surname"});
            this.CB_SearchBy.Location = new System.Drawing.Point(280, 28);
            this.CB_SearchBy.Name = "CB_SearchBy";
            this.CB_SearchBy.Size = new System.Drawing.Size(118, 26);
            this.CB_SearchBy.TabIndex = 19;
            // 
            // TB_StudentSearch
            // 
            this.TB_StudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_StudentSearch.Location = new System.Drawing.Point(7, 28);
            this.TB_StudentSearch.Name = "TB_StudentSearch";
            this.TB_StudentSearch.Size = new System.Drawing.Size(267, 26);
            this.TB_StudentSearch.TabIndex = 18;
            // 
            // L_StudentSearch
            // 
            this.L_StudentSearch.AutoSize = true;
            this.L_StudentSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_StudentSearch.Location = new System.Drawing.Point(3, 4);
            this.L_StudentSearch.Name = "L_StudentSearch";
            this.L_StudentSearch.Size = new System.Drawing.Size(168, 20);
            this.L_StudentSearch.TabIndex = 17;
            this.L_StudentSearch.Text = "Student Detail Look-Up";
            // 
            // B_RegisterStudent
            // 
            this.B_RegisterStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RegisterStudent.Location = new System.Drawing.Point(7, 304);
            this.B_RegisterStudent.Name = "B_RegisterStudent";
            this.B_RegisterStudent.Size = new System.Drawing.Size(171, 77);
            this.B_RegisterStudent.TabIndex = 11;
            this.B_RegisterStudent.Text = "Register Student";
            this.B_RegisterStudent.UseVisualStyleBackColor = true;
            // 
            // B_EnrolStudent
            // 
            this.B_EnrolStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_EnrolStudent.Location = new System.Drawing.Point(186, 304);
            this.B_EnrolStudent.Name = "B_EnrolStudent";
            this.B_EnrolStudent.Size = new System.Drawing.Size(148, 77);
            this.B_EnrolStudent.TabIndex = 12;
            this.B_EnrolStudent.Text = "Enrol Student";
            this.B_EnrolStudent.UseVisualStyleBackColor = true;
            this.B_EnrolStudent.Click += new System.EventHandler(this.B_EnrolStudent_Click);
            // 
            // B_EditStudent
            // 
            this.B_EditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_EditStudent.Location = new System.Drawing.Point(340, 304);
            this.B_EditStudent.Name = "B_EditStudent";
            this.B_EditStudent.Size = new System.Drawing.Size(167, 36);
            this.B_EditStudent.TabIndex = 13;
            this.B_EditStudent.Text = "Edit Student";
            this.B_EditStudent.UseVisualStyleBackColor = true;
            this.B_EditStudent.Click += new System.EventHandler(this.B_EditStudent_Click);
            // 
            // B_DeleteStudent
            // 
            this.B_DeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DeleteStudent.Location = new System.Drawing.Point(340, 345);
            this.B_DeleteStudent.Name = "B_DeleteStudent";
            this.B_DeleteStudent.Size = new System.Drawing.Size(167, 36);
            this.B_DeleteStudent.TabIndex = 14;
            this.B_DeleteStudent.Text = "Delete Student";
            this.B_DeleteStudent.UseVisualStyleBackColor = true;
            this.B_DeleteStudent.Click += new System.EventHandler(this.B_DeleteStudent_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 393);
            this.Controls.Add(this.B_DeleteStudent);
            this.Controls.Add(this.B_EditStudent);
            this.Controls.Add(this.B_EnrolStudent);
            this.Controls.Add(this.B_RegisterStudent);
            this.Controls.Add(this.P_ViewStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.WindowTitle = "Home";
            this.Controls.SetChildIndex(this.P_ViewStudent, 0);
            this.Controls.SetChildIndex(this.B_RegisterStudent, 0);
            this.Controls.SetChildIndex(this.B_EnrolStudent, 0);
            this.Controls.SetChildIndex(this.B_EditStudent, 0);
            this.Controls.SetChildIndex(this.B_DeleteStudent, 0);
            this.P_ViewStudent.ResumeLayout(false);
            this.P_ViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_ViewStudent;
        private System.Windows.Forms.Button B_RegisterStudent;
        private System.Windows.Forms.Button B_EnrolStudent;
        private System.Windows.Forms.Button B_EditStudent;
        private System.Windows.Forms.Label L_Instruction;
        private System.Windows.Forms.DataGridView DGV_Students;
        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.ComboBox CB_SearchBy;
        private System.Windows.Forms.TextBox TB_StudentSearch;
        private System.Windows.Forms.Label L_StudentSearch;
        private System.Windows.Forms.Button B_DeleteStudent;


    }
}