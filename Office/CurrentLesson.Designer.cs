namespace Timetabling
{
    partial class CurrentLesson
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
            this.L_LastWeek = new System.Windows.Forms.Label();
            this.RTB_LastWeek = new System.Windows.Forms.RichTextBox();
            this.RTB_Today = new System.Windows.Forms.RichTextBox();
            this.L_TComments = new System.Windows.Forms.Label();
            this.CB_Attended = new System.Windows.Forms.CheckBox();
            this.B_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_LastWeek
            // 
            this.L_LastWeek.AutoSize = true;
            this.L_LastWeek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_LastWeek.Location = new System.Drawing.Point(12, 62);
            this.L_LastWeek.Name = "L_LastWeek";
            this.L_LastWeek.Size = new System.Drawing.Size(185, 21);
            this.L_LastWeek.TabIndex = 1;
            this.L_LastWeek.Text = "Last Week\'s Comments";
            // 
            // RTB_LastWeek
            // 
            this.RTB_LastWeek.Location = new System.Drawing.Point(16, 87);
            this.RTB_LastWeek.Name = "RTB_LastWeek";
            this.RTB_LastWeek.Size = new System.Drawing.Size(340, 96);
            this.RTB_LastWeek.TabIndex = 2;
            this.RTB_LastWeek.Text = "";
            // 
            // RTB_Today
            // 
            this.RTB_Today.Location = new System.Drawing.Point(16, 217);
            this.RTB_Today.Name = "RTB_Today";
            this.RTB_Today.Size = new System.Drawing.Size(340, 96);
            this.RTB_Today.TabIndex = 4;
            this.RTB_Today.Text = "";
            // 
            // L_TComments
            // 
            this.L_TComments.AutoSize = true;
            this.L_TComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TComments.Location = new System.Drawing.Point(12, 192);
            this.L_TComments.Name = "L_TComments";
            this.L_TComments.Size = new System.Drawing.Size(155, 21);
            this.L_TComments.TabIndex = 3;
            this.L_TComments.Text = "Today\'s Comments";
            // 
            // CB_Attended
            // 
            this.CB_Attended.AutoSize = true;
            this.CB_Attended.Location = new System.Drawing.Point(142, 328);
            this.CB_Attended.Name = "CB_Attended";
            this.CB_Attended.Size = new System.Drawing.Size(69, 17);
            this.CB_Attended.TabIndex = 5;
            this.CB_Attended.Text = "Attended";
            this.CB_Attended.UseVisualStyleBackColor = true;
            // 
            // B_Submit
            // 
            this.B_Submit.Location = new System.Drawing.Point(16, 361);
            this.B_Submit.Name = "B_Submit";
            this.B_Submit.Size = new System.Drawing.Size(340, 40);
            this.B_Submit.TabIndex = 6;
            this.B_Submit.Text = "Submit";
            this.B_Submit.UseVisualStyleBackColor = true;
            this.B_Submit.Click += new System.EventHandler(this.B_Submit_Click);
            // 
            // CurrentLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 420);
            this.Controls.Add(this.B_Submit);
            this.Controls.Add(this.CB_Attended);
            this.Controls.Add(this.RTB_Today);
            this.Controls.Add(this.L_TComments);
            this.Controls.Add(this.RTB_LastWeek);
            this.Controls.Add(this.L_LastWeek);
            this.Name = "CurrentLesson";
            this.Text = "CurrentLesson";
            this.WindowTitle = "Current Lesson";
            this.Controls.SetChildIndex(this.L_LastWeek, 0);
            this.Controls.SetChildIndex(this.RTB_LastWeek, 0);
            this.Controls.SetChildIndex(this.L_TComments, 0);
            this.Controls.SetChildIndex(this.RTB_Today, 0);
            this.Controls.SetChildIndex(this.CB_Attended, 0);
            this.Controls.SetChildIndex(this.B_Submit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_LastWeek;
        private System.Windows.Forms.RichTextBox RTB_LastWeek;
        private System.Windows.Forms.RichTextBox RTB_Today;
        private System.Windows.Forms.Label L_TComments;
        private System.Windows.Forms.CheckBox CB_Attended;
        private System.Windows.Forms.Button B_Submit;
    }
}