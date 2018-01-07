namespace Timetabling
{
    partial class F_TutorHome
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
            this.LB_Lessons = new System.Windows.Forms.ListBox();
            this.B_View = new System.Windows.Forms.Button();
            this.L_LessonsList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Submit = new System.Windows.Forms.Button();
            this.RTB_TodaysComments = new System.Windows.Forms.RichTextBox();
            this.L_TodaysComments = new System.Windows.Forms.Label();
            this.RTB_LastWeek = new System.Windows.Forms.RichTextBox();
            this.CB_Attended = new System.Windows.Forms.CheckBox();
            this.L_LastWeek = new System.Windows.Forms.Label();
            this.L_SelectedLesson = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Lessons
            // 
            this.LB_Lessons.FormattingEnabled = true;
            this.LB_Lessons.Location = new System.Drawing.Point(15, 83);
            this.LB_Lessons.Name = "LB_Lessons";
            this.LB_Lessons.Size = new System.Drawing.Size(201, 329);
            this.LB_Lessons.TabIndex = 1;
            // 
            // B_View
            // 
            this.B_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_View.Location = new System.Drawing.Point(15, 416);
            this.B_View.Name = "B_View";
            this.B_View.Size = new System.Drawing.Size(201, 52);
            this.B_View.TabIndex = 2;
            this.B_View.Text = "View";
            this.B_View.UseVisualStyleBackColor = true;
            this.B_View.Click += new System.EventHandler(this.B_View_Click);
            // 
            // L_LessonsList
            // 
            this.L_LessonsList.AutoSize = true;
            this.L_LessonsList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LessonsList.Location = new System.Drawing.Point(12, 63);
            this.L_LessonsList.Name = "L_LessonsList";
            this.L_LessonsList.Size = new System.Drawing.Size(73, 17);
            this.L_LessonsList.TabIndex = 3;
            this.L_LessonsList.Text = "Lesson List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.B_Submit);
            this.panel1.Controls.Add(this.RTB_TodaysComments);
            this.panel1.Controls.Add(this.L_TodaysComments);
            this.panel1.Controls.Add(this.RTB_LastWeek);
            this.panel1.Controls.Add(this.CB_Attended);
            this.panel1.Controls.Add(this.L_LastWeek);
            this.panel1.Location = new System.Drawing.Point(228, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 385);
            this.panel1.TabIndex = 4;
            // 
            // B_Submit
            // 
            this.B_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Submit.Location = new System.Drawing.Point(15, 306);
            this.B_Submit.Name = "B_Submit";
            this.B_Submit.Size = new System.Drawing.Size(372, 61);
            this.B_Submit.TabIndex = 6;
            this.B_Submit.Text = "Submit";
            this.B_Submit.UseVisualStyleBackColor = true;
            this.B_Submit.Click += new System.EventHandler(this.B_Submit_Click);
            // 
            // RTB_TodaysComments
            // 
            this.RTB_TodaysComments.Location = new System.Drawing.Point(15, 159);
            this.RTB_TodaysComments.Name = "RTB_TodaysComments";
            this.RTB_TodaysComments.Size = new System.Drawing.Size(374, 96);
            this.RTB_TodaysComments.TabIndex = 14;
            this.RTB_TodaysComments.Text = "";
            // 
            // L_TodaysComments
            // 
            this.L_TodaysComments.AutoSize = true;
            this.L_TodaysComments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TodaysComments.Location = new System.Drawing.Point(12, 139);
            this.L_TodaysComments.Name = "L_TodaysComments";
            this.L_TodaysComments.Size = new System.Drawing.Size(118, 17);
            this.L_TodaysComments.TabIndex = 13;
            this.L_TodaysComments.Text = "Today\'s Comments";
            // 
            // RTB_LastWeek
            // 
            this.RTB_LastWeek.Enabled = false;
            this.RTB_LastWeek.Location = new System.Drawing.Point(15, 31);
            this.RTB_LastWeek.Name = "RTB_LastWeek";
            this.RTB_LastWeek.Size = new System.Drawing.Size(372, 96);
            this.RTB_LastWeek.TabIndex = 8;
            this.RTB_LastWeek.Text = "";
            // 
            // CB_Attended
            // 
            this.CB_Attended.AutoSize = true;
            this.CB_Attended.Location = new System.Drawing.Point(142, 274);
            this.CB_Attended.Name = "CB_Attended";
            this.CB_Attended.Size = new System.Drawing.Size(109, 17);
            this.CB_Attended.TabIndex = 11;
            this.CB_Attended.Text = "Student Attended";
            this.CB_Attended.UseVisualStyleBackColor = true;
            // 
            // L_LastWeek
            // 
            this.L_LastWeek.AutoSize = true;
            this.L_LastWeek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LastWeek.Location = new System.Drawing.Point(10, 11);
            this.L_LastWeek.Name = "L_LastWeek";
            this.L_LastWeek.Size = new System.Drawing.Size(141, 17);
            this.L_LastWeek.TabIndex = 7;
            this.L_LastWeek.Text = "Last Week\'s Comments";
            // 
            // L_SelectedLesson
            // 
            this.L_SelectedLesson.AutoSize = true;
            this.L_SelectedLesson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SelectedLesson.Location = new System.Drawing.Point(225, 63);
            this.L_SelectedLesson.Name = "L_SelectedLesson";
            this.L_SelectedLesson.Size = new System.Drawing.Size(103, 17);
            this.L_SelectedLesson.TabIndex = 5;
            this.L_SelectedLesson.Text = "Selected Lesson";
            // 
            // TutorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.L_SelectedLesson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.L_LessonsList);
            this.Controls.Add(this.B_View);
            this.Controls.Add(this.LB_Lessons);
            this.Name = "TutorHome";
            this.Text = "TutorHome";
            this.WindowTitle = "Today\'s Lessons";
            this.Controls.SetChildIndex(this.LB_Lessons, 0);
            this.Controls.SetChildIndex(this.B_View, 0);
            this.Controls.SetChildIndex(this.L_LessonsList, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.L_SelectedLesson, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Lessons;
        private System.Windows.Forms.Button B_View;
        private System.Windows.Forms.Label L_LessonsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_SelectedLesson;
        private System.Windows.Forms.Button B_Submit;
        private System.Windows.Forms.RichTextBox RTB_TodaysComments;
        private System.Windows.Forms.Label L_TodaysComments;
        private System.Windows.Forms.RichTextBox RTB_LastWeek;
        private System.Windows.Forms.CheckBox CB_Attended;
        private System.Windows.Forms.Label L_LastWeek;
    }
}