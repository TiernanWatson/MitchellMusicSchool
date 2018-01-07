namespace Timetabling
{
    partial class F_TutorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TutorLogin));
            this.L_Username = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.B_Logon = new System.Windows.Forms.Button();
            this.L_Password = new System.Windows.Forms.Label();
            this.PB_UserIco = new System.Windows.Forms.PictureBox();
            this.PB_KeyIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_KeyIco)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Username
            // 
            this.L_Username.AutoSize = true;
            this.L_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.ForeColor = System.Drawing.Color.Gray;
            this.L_Username.Location = new System.Drawing.Point(126, 104);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(76, 17);
            this.L_Username.TabIndex = 1;
            this.L_Username.Text = "USERNAME";
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(129, 124);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(168, 22);
            this.TB_Username.TabIndex = 2;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(129, 196);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(168, 22);
            this.TB_Password.TabIndex = 4;
            this.TB_Password.UseSystemPasswordChar = true;
            // 
            // B_Logon
            // 
            this.B_Logon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Logon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Logon.Location = new System.Drawing.Point(70, 241);
            this.B_Logon.Name = "B_Logon";
            this.B_Logon.Size = new System.Drawing.Size(227, 37);
            this.B_Logon.TabIndex = 5;
            this.B_Logon.Text = "LOGIN";
            this.B_Logon.UseVisualStyleBackColor = true;
            this.B_Logon.Click += new System.EventHandler(this.B_Logon_Click);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.Color.Gray;
            this.L_Password.Location = new System.Drawing.Point(126, 176);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(75, 17);
            this.L_Password.TabIndex = 6;
            this.L_Password.Text = "PASSWORD";
            // 
            // PB_UserIco
            // 
            this.PB_UserIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_UserIco.BackgroundImage")));
            this.PB_UserIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_UserIco.Location = new System.Drawing.Point(70, 96);
            this.PB_UserIco.Name = "PB_UserIco";
            this.PB_UserIco.Size = new System.Drawing.Size(53, 50);
            this.PB_UserIco.TabIndex = 7;
            this.PB_UserIco.TabStop = false;
            // 
            // PB_KeyIco
            // 
            this.PB_KeyIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_KeyIco.BackgroundImage")));
            this.PB_KeyIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_KeyIco.Location = new System.Drawing.Point(70, 168);
            this.PB_KeyIco.Name = "PB_KeyIco";
            this.PB_KeyIco.Size = new System.Drawing.Size(53, 50);
            this.PB_KeyIco.TabIndex = 8;
            this.PB_KeyIco.TabStop = false;
            // 
            // F_TutorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 358);
            this.Controls.Add(this.PB_KeyIco);
            this.Controls.Add(this.PB_UserIco);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.B_Logon);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.L_Username);
            this.Name = "F_TutorLogin";
            this.Text = "LogonScreen";
            this.WindowTitle = "Tutor Home";
            this.Controls.SetChildIndex(this.L_Username, 0);
            this.Controls.SetChildIndex(this.TB_Username, 0);
            this.Controls.SetChildIndex(this.TB_Password, 0);
            this.Controls.SetChildIndex(this.B_Logon, 0);
            this.Controls.SetChildIndex(this.L_Password, 0);
            this.Controls.SetChildIndex(this.PB_UserIco, 0);
            this.Controls.SetChildIndex(this.PB_KeyIco, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_KeyIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button B_Logon;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.PictureBox PB_UserIco;
        private System.Windows.Forms.PictureBox PB_KeyIco;
    }
}