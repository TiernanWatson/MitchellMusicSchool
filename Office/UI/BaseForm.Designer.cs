namespace Timetabling.UI
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.P_WBorder = new System.Windows.Forms.Panel();
            this.L_WinTitle = new System.Windows.Forms.Label();
            this.P_WButtons = new System.Windows.Forms.Panel();
            this.B_WMin = new System.Windows.Forms.Button();
            this.B_WClose = new System.Windows.Forms.Button();
            this.L_MSM = new System.Windows.Forms.Label();
            this.P_WBorder.SuspendLayout();
            this.P_WButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_WBorder
            // 
            this.P_WBorder.BackColor = System.Drawing.Color.Transparent;
            this.P_WBorder.Controls.Add(this.L_WinTitle);
            this.P_WBorder.Controls.Add(this.P_WButtons);
            this.P_WBorder.Controls.Add(this.L_MSM);
            this.P_WBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_WBorder.Location = new System.Drawing.Point(0, 0);
            this.P_WBorder.Name = "P_WBorder";
            this.P_WBorder.Size = new System.Drawing.Size(640, 31);
            this.P_WBorder.TabIndex = 0;
            this.P_WBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_WBorder_MouseDown);
            // 
            // L_WinTitle
            // 
            this.L_WinTitle.AutoSize = true;
            this.L_WinTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_WinTitle.ForeColor = System.Drawing.Color.DimGray;
            this.L_WinTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.L_WinTitle.Location = new System.Drawing.Point(269, 9);
            this.L_WinTitle.Name = "L_WinTitle";
            this.L_WinTitle.Size = new System.Drawing.Size(75, 15);
            this.L_WinTitle.TabIndex = 4;
            this.L_WinTitle.Text = "Window Title";
            // 
            // P_WButtons
            // 
            this.P_WButtons.Controls.Add(this.B_WMin);
            this.P_WButtons.Controls.Add(this.B_WClose);
            this.P_WButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.P_WButtons.Location = new System.Drawing.Point(590, 0);
            this.P_WButtons.Name = "P_WButtons";
            this.P_WButtons.Size = new System.Drawing.Size(50, 31);
            this.P_WButtons.TabIndex = 2;
            // 
            // B_WMin
            // 
            this.B_WMin.BackColor = System.Drawing.Color.Transparent;
            this.B_WMin.FlatAppearance.BorderSize = 0;
            this.B_WMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_WMin.Location = new System.Drawing.Point(0, 0);
            this.B_WMin.Name = "B_WMin";
            this.B_WMin.Size = new System.Drawing.Size(25, 25);
            this.B_WMin.TabIndex = 2;
            this.B_WMin.Text = "_";
            this.B_WMin.UseVisualStyleBackColor = false;
            this.B_WMin.Click += new System.EventHandler(this.B_WMin_Click);
            // 
            // B_WClose
            // 
            this.B_WClose.BackColor = System.Drawing.Color.Transparent;
            this.B_WClose.FlatAppearance.BorderSize = 0;
            this.B_WClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_WClose.Location = new System.Drawing.Point(25, 0);
            this.B_WClose.Name = "B_WClose";
            this.B_WClose.Size = new System.Drawing.Size(25, 25);
            this.B_WClose.TabIndex = 1;
            this.B_WClose.Text = "x";
            this.B_WClose.UseVisualStyleBackColor = false;
            this.B_WClose.Click += new System.EventHandler(this.B_WClose_Click);
            // 
            // L_MSM
            // 
            this.L_MSM.AutoSize = true;
            this.L_MSM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_MSM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.L_MSM.Location = new System.Drawing.Point(8, 8);
            this.L_MSM.Name = "L_MSM";
            this.L_MSM.Size = new System.Drawing.Size(152, 17);
            this.L_MSM.TabIndex = 0;
            this.L_MSM.Text = "Mitchell School Of Music";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.P_WBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.P_WBorder.ResumeLayout(false);
            this.P_WBorder.PerformLayout();
            this.P_WButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_WBorder;
        private System.Windows.Forms.Label L_MSM;
        private System.Windows.Forms.Panel P_WButtons;
        private System.Windows.Forms.Button B_WClose;
        private System.Windows.Forms.Button B_WMin;
        private System.Windows.Forms.Label L_WinTitle;
    }
}