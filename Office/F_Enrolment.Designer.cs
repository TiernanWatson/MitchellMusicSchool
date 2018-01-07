namespace Timetabling
{
    partial class F_Enrolment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Enrolment));
            this.L_EnrollingStu = new System.Windows.Forms.Label();
            this.CB_Instrument = new System.Windows.Forms.ComboBox();
            this.L_Instrument = new System.Windows.Forms.Label();
            this.L_AvailTimes = new System.Windows.Forms.Label();
            this.CB_AvailTimes = new System.Windows.Forms.ComboBox();
            this.L_AvailTutors = new System.Windows.Forms.Label();
            this.CB_AvailTutors = new System.Windows.Forms.ComboBox();
            this.B_Enrol = new System.Windows.Forms.Button();
            this.B_Reset = new System.Windows.Forms.Button();
            this.L_StuDetail = new System.Windows.Forms.Label();
            this.LB_Terms = new System.Windows.Forms.ListBox();
            this.LB_Day = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Rooms = new System.Windows.Forms.ComboBox();
            this.TC_StartDate = new System.Windows.Forms.TabControl();
            this.TP_FullTerm = new System.Windows.Forms.TabPage();
            this.TP_CustomDate = new System.Windows.Forms.TabPage();
            this.L_Info1 = new System.Windows.Forms.Label();
            this.L_StartDate = new System.Windows.Forms.Label();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_StudentInfo = new System.Windows.Forms.Panel();
            this.TC_StartDate.SuspendLayout();
            this.TP_FullTerm.SuspendLayout();
            this.TP_CustomDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.P_StudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_EnrollingStu
            // 
            this.L_EnrollingStu.AutoSize = true;
            this.L_EnrollingStu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EnrollingStu.Location = new System.Drawing.Point(50, 3);
            this.L_EnrollingStu.Name = "L_EnrollingStu";
            this.L_EnrollingStu.Size = new System.Drawing.Size(123, 20);
            this.L_EnrollingStu.TabIndex = 1;
            this.L_EnrollingStu.Text = "Enrolling Student";
            this.L_EnrollingStu.Click += new System.EventHandler(this.L_EnrollingStu_Click);
            // 
            // CB_Instrument
            // 
            this.CB_Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Instrument.FormattingEnabled = true;
            this.CB_Instrument.Location = new System.Drawing.Point(13, 123);
            this.CB_Instrument.Name = "CB_Instrument";
            this.CB_Instrument.Size = new System.Drawing.Size(198, 26);
            this.CB_Instrument.TabIndex = 7;
            // 
            // L_Instrument
            // 
            this.L_Instrument.AutoSize = true;
            this.L_Instrument.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Instrument.Location = new System.Drawing.Point(12, 100);
            this.L_Instrument.Name = "L_Instrument";
            this.L_Instrument.Size = new System.Drawing.Size(79, 20);
            this.L_Instrument.TabIndex = 8;
            this.L_Instrument.Text = "Instrument";
            // 
            // L_AvailTimes
            // 
            this.L_AvailTimes.AutoSize = true;
            this.L_AvailTimes.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.L_AvailTimes.Location = new System.Drawing.Point(232, 100);
            this.L_AvailTimes.Name = "L_AvailTimes";
            this.L_AvailTimes.Size = new System.Drawing.Size(123, 20);
            this.L_AvailTimes.TabIndex = 11;
            this.L_AvailTimes.Text = "Available Periods";
            // 
            // CB_AvailTimes
            // 
            this.CB_AvailTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AvailTimes.FormattingEnabled = true;
            this.CB_AvailTimes.Location = new System.Drawing.Point(233, 123);
            this.CB_AvailTimes.Name = "CB_AvailTimes";
            this.CB_AvailTimes.Size = new System.Drawing.Size(341, 26);
            this.CB_AvailTimes.TabIndex = 10;
            this.CB_AvailTimes.SelectedIndexChanged += new System.EventHandler(this.CB_AvailTimes_SelectedIndexChanged);
            // 
            // L_AvailTutors
            // 
            this.L_AvailTutors.AutoSize = true;
            this.L_AvailTutors.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.L_AvailTutors.Location = new System.Drawing.Point(232, 156);
            this.L_AvailTutors.Name = "L_AvailTutors";
            this.L_AvailTutors.Size = new System.Drawing.Size(116, 20);
            this.L_AvailTutors.TabIndex = 13;
            this.L_AvailTutors.Text = "Available Tutors";
            // 
            // CB_AvailTutors
            // 
            this.CB_AvailTutors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AvailTutors.FormattingEnabled = true;
            this.CB_AvailTutors.Location = new System.Drawing.Point(233, 179);
            this.CB_AvailTutors.Name = "CB_AvailTutors";
            this.CB_AvailTutors.Size = new System.Drawing.Size(341, 26);
            this.CB_AvailTutors.TabIndex = 12;
            this.CB_AvailTutors.SelectedIndexChanged += new System.EventHandler(this.CB_AvailTutors_SelectedIndexChanged);
            // 
            // B_Enrol
            // 
            this.B_Enrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Enrol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Enrol.Location = new System.Drawing.Point(364, 279);
            this.B_Enrol.Name = "B_Enrol";
            this.B_Enrol.Size = new System.Drawing.Size(210, 34);
            this.B_Enrol.TabIndex = 14;
            this.B_Enrol.Text = "Enrol";
            this.B_Enrol.UseVisualStyleBackColor = true;
            this.B_Enrol.Click += new System.EventHandler(this.B_Enrol_Click);
            // 
            // B_Reset
            // 
            this.B_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reset.Location = new System.Drawing.Point(233, 279);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(125, 34);
            this.B_Reset.TabIndex = 15;
            this.B_Reset.Text = "Reset";
            this.B_Reset.UseVisualStyleBackColor = true;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // L_StuDetail
            // 
            this.L_StuDetail.AutoSize = true;
            this.L_StuDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_StuDetail.Location = new System.Drawing.Point(50, 23);
            this.L_StuDetail.Name = "L_StuDetail";
            this.L_StuDetail.Size = new System.Drawing.Size(137, 17);
            this.L_StuDetail.TabIndex = 16;
            this.L_StuDetail.Text = "45 Firstname Surname";
            this.L_StuDetail.Click += new System.EventHandler(this.L_StuDetail_Click);
            // 
            // LB_Terms
            // 
            this.LB_Terms.FormattingEnabled = true;
            this.LB_Terms.Location = new System.Drawing.Point(13, 156);
            this.LB_Terms.Name = "LB_Terms";
            this.LB_Terms.Size = new System.Drawing.Size(198, 56);
            this.LB_Terms.TabIndex = 17;
            this.LB_Terms.SelectedIndexChanged += new System.EventHandler(this.LB_Terms_SelectedIndexChanged);
            // 
            // LB_Day
            // 
            this.LB_Day.FormattingEnabled = true;
            this.LB_Day.Location = new System.Drawing.Point(6, 2);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(180, 69);
            this.LB_Day.TabIndex = 18;
            this.LB_Day.SelectedIndexChanged += new System.EventHandler(this.LB_Day_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(232, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Available Rooms";
            // 
            // CB_Rooms
            // 
            this.CB_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Rooms.FormattingEnabled = true;
            this.CB_Rooms.Location = new System.Drawing.Point(233, 238);
            this.CB_Rooms.Name = "CB_Rooms";
            this.CB_Rooms.Size = new System.Drawing.Size(341, 26);
            this.CB_Rooms.TabIndex = 19;
            this.CB_Rooms.SelectedIndexChanged += new System.EventHandler(this.CB_Rooms_SelectedIndexChanged);
            // 
            // TC_StartDate
            // 
            this.TC_StartDate.Controls.Add(this.TP_FullTerm);
            this.TC_StartDate.Controls.Add(this.TP_CustomDate);
            this.TC_StartDate.Location = new System.Drawing.Point(12, 219);
            this.TC_StartDate.Name = "TC_StartDate";
            this.TC_StartDate.SelectedIndex = 0;
            this.TC_StartDate.Size = new System.Drawing.Size(200, 100);
            this.TC_StartDate.TabIndex = 21;
            // 
            // TP_FullTerm
            // 
            this.TP_FullTerm.Controls.Add(this.LB_Day);
            this.TP_FullTerm.Location = new System.Drawing.Point(4, 22);
            this.TP_FullTerm.Name = "TP_FullTerm";
            this.TP_FullTerm.Padding = new System.Windows.Forms.Padding(3);
            this.TP_FullTerm.Size = new System.Drawing.Size(192, 74);
            this.TP_FullTerm.TabIndex = 0;
            this.TP_FullTerm.Text = "Full Term";
            this.TP_FullTerm.UseVisualStyleBackColor = true;
            // 
            // TP_CustomDate
            // 
            this.TP_CustomDate.Controls.Add(this.L_Info1);
            this.TP_CustomDate.Controls.Add(this.L_StartDate);
            this.TP_CustomDate.Controls.Add(this.DTP_StartDate);
            this.TP_CustomDate.Location = new System.Drawing.Point(4, 22);
            this.TP_CustomDate.Name = "TP_CustomDate";
            this.TP_CustomDate.Padding = new System.Windows.Forms.Padding(3);
            this.TP_CustomDate.Size = new System.Drawing.Size(192, 74);
            this.TP_CustomDate.TabIndex = 1;
            this.TP_CustomDate.Text = "Custom Dates";
            this.TP_CustomDate.UseVisualStyleBackColor = true;
            // 
            // L_Info1
            // 
            this.L_Info1.AutoSize = true;
            this.L_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Info1.Location = new System.Drawing.Point(3, 51);
            this.L_Info1.Name = "L_Info1";
            this.L_Info1.Size = new System.Drawing.Size(138, 13);
            this.L_Info1.TabIndex = 2;
            this.L_Info1.Text = "Will run until the end of term";
            // 
            // L_StartDate
            // 
            this.L_StartDate.AutoSize = true;
            this.L_StartDate.Location = new System.Drawing.Point(4, 9);
            this.L_StartDate.Name = "L_StartDate";
            this.L_StartDate.Size = new System.Drawing.Size(55, 13);
            this.L_StartDate.TabIndex = 1;
            this.L_StartDate.Text = "Start Date";
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.Location = new System.Drawing.Point(6, 26);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(179, 20);
            this.DTP_StartDate.TabIndex = 0;
            this.DTP_StartDate.ValueChanged += new System.EventHandler(this.DTP_StartDate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // P_StudentInfo
            // 
            this.P_StudentInfo.Controls.Add(this.pictureBox1);
            this.P_StudentInfo.Controls.Add(this.L_EnrollingStu);
            this.P_StudentInfo.Controls.Add(this.L_StuDetail);
            this.P_StudentInfo.Location = new System.Drawing.Point(16, 38);
            this.P_StudentInfo.Name = "P_StudentInfo";
            this.P_StudentInfo.Size = new System.Drawing.Size(563, 47);
            this.P_StudentInfo.TabIndex = 23;
            // 
            // F_Enrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 330);
            this.Controls.Add(this.P_StudentInfo);
            this.Controls.Add(this.TC_StartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Rooms);
            this.Controls.Add(this.LB_Terms);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.B_Enrol);
            this.Controls.Add(this.L_AvailTutors);
            this.Controls.Add(this.CB_AvailTutors);
            this.Controls.Add(this.L_AvailTimes);
            this.Controls.Add(this.CB_AvailTimes);
            this.Controls.Add(this.L_Instrument);
            this.Controls.Add(this.CB_Instrument);
            this.Name = "F_Enrolment";
            this.Text = "EnrolStudent";
            this.WindowTitle = "Enrol Student";
            this.Controls.SetChildIndex(this.CB_Instrument, 0);
            this.Controls.SetChildIndex(this.L_Instrument, 0);
            this.Controls.SetChildIndex(this.CB_AvailTimes, 0);
            this.Controls.SetChildIndex(this.L_AvailTimes, 0);
            this.Controls.SetChildIndex(this.CB_AvailTutors, 0);
            this.Controls.SetChildIndex(this.L_AvailTutors, 0);
            this.Controls.SetChildIndex(this.B_Enrol, 0);
            this.Controls.SetChildIndex(this.B_Reset, 0);
            this.Controls.SetChildIndex(this.LB_Terms, 0);
            this.Controls.SetChildIndex(this.CB_Rooms, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TC_StartDate, 0);
            this.Controls.SetChildIndex(this.P_StudentInfo, 0);
            this.TC_StartDate.ResumeLayout(false);
            this.TP_FullTerm.ResumeLayout(false);
            this.TP_CustomDate.ResumeLayout(false);
            this.TP_CustomDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.P_StudentInfo.ResumeLayout(false);
            this.P_StudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_EnrollingStu;
        private System.Windows.Forms.ComboBox CB_Instrument;
        private System.Windows.Forms.Label L_Instrument;
        private System.Windows.Forms.Label L_AvailTimes;
        private System.Windows.Forms.ComboBox CB_AvailTimes;
        private System.Windows.Forms.Label L_AvailTutors;
        private System.Windows.Forms.ComboBox CB_AvailTutors;
        private System.Windows.Forms.Button B_Enrol;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Label L_StuDetail;
        private System.Windows.Forms.ListBox LB_Terms;
        private System.Windows.Forms.ListBox LB_Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Rooms;
        private System.Windows.Forms.TabControl TC_StartDate;
        private System.Windows.Forms.TabPage TP_FullTerm;
        private System.Windows.Forms.TabPage TP_CustomDate;
        private System.Windows.Forms.Label L_Info1;
        private System.Windows.Forms.Label L_StartDate;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel P_StudentInfo;
    }
}