namespace Timetabling
{
    partial class HomeScreen
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
            this.B_Manager = new System.Windows.Forms.Button();
            this.B_Tutor = new System.Windows.Forms.Button();
            this.B_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Manager
            // 
            this.B_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Manager.Location = new System.Drawing.Point(69, 78);
            this.B_Manager.Name = "B_Manager";
            this.B_Manager.Size = new System.Drawing.Size(152, 41);
            this.B_Manager.TabIndex = 2;
            this.B_Manager.Text = "Manage Records";
            this.B_Manager.UseVisualStyleBackColor = true;
            this.B_Manager.Click += new System.EventHandler(this.B_Manager_Click);
            // 
            // B_Tutor
            // 
            this.B_Tutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Tutor.Location = new System.Drawing.Point(69, 125);
            this.B_Tutor.Name = "B_Tutor";
            this.B_Tutor.Size = new System.Drawing.Size(152, 41);
            this.B_Tutor.TabIndex = 3;
            this.B_Tutor.Text = "Tutor Login";
            this.B_Tutor.UseVisualStyleBackColor = true;
            this.B_Tutor.Click += new System.EventHandler(this.B_Tutor_Click);
            // 
            // B_Report
            // 
            this.B_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Report.Location = new System.Drawing.Point(69, 172);
            this.B_Report.Name = "B_Report";
            this.B_Report.Size = new System.Drawing.Size(152, 41);
            this.B_Report.TabIndex = 4;
            this.B_Report.Text = "Statistics/Report";
            this.B_Report.UseVisualStyleBackColor = true;
            this.B_Report.Click += new System.EventHandler(this.B_Report_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 240);
            this.Controls.Add(this.B_Report);
            this.Controls.Add(this.B_Tutor);
            this.Controls.Add(this.B_Manager);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.WindowTitle = "";
            this.Controls.SetChildIndex(this.B_Manager, 0);
            this.Controls.SetChildIndex(this.B_Tutor, 0);
            this.Controls.SetChildIndex(this.B_Report, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Manager;
        private System.Windows.Forms.Button B_Tutor;
        private System.Windows.Forms.Button B_Report;
    }
}