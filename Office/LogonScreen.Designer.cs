namespace Timetabling
{
    partial class LogonScreen
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
            this.L_Username = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.L_Password = new System.Windows.Forms.Label();
            this.B_Logon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Username
            // 
            this.L_Username.AutoSize = true;
            this.L_Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.Location = new System.Drawing.Point(131, 106);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(97, 25);
            this.L_Username.TabIndex = 1;
            this.L_Username.Text = "Username";
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(98, 133);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(168, 22);
            this.TB_Username.TabIndex = 2;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(98, 205);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(168, 22);
            this.TB_Password.TabIndex = 4;
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.Location = new System.Drawing.Point(131, 178);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(91, 25);
            this.L_Password.TabIndex = 3;
            this.L_Password.Text = "Password";
            // 
            // B_Logon
            // 
            this.B_Logon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Logon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Logon.Location = new System.Drawing.Point(98, 260);
            this.B_Logon.Name = "B_Logon";
            this.B_Logon.Size = new System.Drawing.Size(168, 37);
            this.B_Logon.TabIndex = 5;
            this.B_Logon.Text = "Login";
            this.B_Logon.UseVisualStyleBackColor = true;
            this.B_Logon.Click += new System.EventHandler(this.B_Logon_Click);
            // 
            // LogonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 364);
            this.Controls.Add(this.B_Logon);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.L_Username);
            this.Name = "LogonScreen";
            this.Text = "LogonScreen";
            this.WindowTitle = "Tutor Home";
            this.Controls.SetChildIndex(this.L_Username, 0);
            this.Controls.SetChildIndex(this.TB_Username, 0);
            this.Controls.SetChildIndex(this.L_Password, 0);
            this.Controls.SetChildIndex(this.TB_Password, 0);
            this.Controls.SetChildIndex(this.B_Logon, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button B_Logon;
    }
}