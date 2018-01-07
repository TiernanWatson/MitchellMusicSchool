namespace Timetabling
{
    partial class TutorHome
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
            this.SuspendLayout();
            // 
            // LB_Lessons
            // 
            this.LB_Lessons.FormattingEnabled = true;
            this.LB_Lessons.Location = new System.Drawing.Point(120, 100);
            this.LB_Lessons.Name = "LB_Lessons";
            this.LB_Lessons.Size = new System.Drawing.Size(400, 199);
            this.LB_Lessons.TabIndex = 1;
            // 
            // B_View
            // 
            this.B_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_View.Location = new System.Drawing.Point(120, 335);
            this.B_View.Name = "B_View";
            this.B_View.Size = new System.Drawing.Size(400, 52);
            this.B_View.TabIndex = 2;
            this.B_View.Text = "View";
            this.B_View.UseVisualStyleBackColor = true;
            this.B_View.Click += new System.EventHandler(this.B_View_Click);
            // 
            // TutorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.B_View);
            this.Controls.Add(this.LB_Lessons);
            this.Name = "TutorHome";
            this.Text = "TutorHome";
            this.WindowTitle = "Today\'s Lessons";
            this.Controls.SetChildIndex(this.LB_Lessons, 0);
            this.Controls.SetChildIndex(this.B_View, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Lessons;
        private System.Windows.Forms.Button B_View;
    }
}