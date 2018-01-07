namespace Timetabling.Controls
{
    partial class StudentSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Instruction = new System.Windows.Forms.Label();
            this.DGV_Students = new System.Windows.Forms.DataGridView();
            this.B_Search = new System.Windows.Forms.Button();
            this.CB_SearchBy = new System.Windows.Forms.ComboBox();
            this.TB_StudentSearch = new System.Windows.Forms.TextBox();
            this.L_StudentSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Instruction
            // 
            this.L_Instruction.AutoSize = true;
            this.L_Instruction.ForeColor = System.Drawing.Color.DimGray;
            this.L_Instruction.Location = new System.Drawing.Point(3, 214);
            this.L_Instruction.Name = "L_Instruction";
            this.L_Instruction.Size = new System.Drawing.Size(176, 13);
            this.L_Instruction.TabIndex = 16;
            this.L_Instruction.Text = "You cannot edit a student from here";
            // 
            // DGV_Students
            // 
            this.DGV_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Students.Location = new System.Drawing.Point(3, 57);
            this.DGV_Students.Name = "DGV_Students";
            this.DGV_Students.Size = new System.Drawing.Size(483, 150);
            this.DGV_Students.TabIndex = 15;
            // 
            // B_Search
            // 
            this.B_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Search.Location = new System.Drawing.Point(400, 26);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(86, 26);
            this.B_Search.TabIndex = 14;
            this.B_Search.Text = "Search";
            this.B_Search.UseVisualStyleBackColor = true;
            // 
            // CB_SearchBy
            // 
            this.CB_SearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SearchBy.FormattingEnabled = true;
            this.CB_SearchBy.Items.AddRange(new object[] {
            "Student ID",
            "Forename",
            "Surname"});
            this.CB_SearchBy.Location = new System.Drawing.Point(276, 25);
            this.CB_SearchBy.Name = "CB_SearchBy";
            this.CB_SearchBy.Size = new System.Drawing.Size(118, 26);
            this.CB_SearchBy.TabIndex = 13;
            // 
            // TB_StudentSearch
            // 
            this.TB_StudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_StudentSearch.Location = new System.Drawing.Point(3, 25);
            this.TB_StudentSearch.Name = "TB_StudentSearch";
            this.TB_StudentSearch.Size = new System.Drawing.Size(267, 26);
            this.TB_StudentSearch.TabIndex = 12;
            // 
            // L_StudentSearch
            // 
            this.L_StudentSearch.AutoSize = true;
            this.L_StudentSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_StudentSearch.Location = new System.Drawing.Point(-1, 1);
            this.L_StudentSearch.Name = "L_StudentSearch";
            this.L_StudentSearch.Size = new System.Drawing.Size(169, 20);
            this.L_StudentSearch.TabIndex = 11;
            this.L_StudentSearch.Text = "Student Detail Look-Up";
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.L_Instruction);
            this.Controls.Add(this.DGV_Students);
            this.Controls.Add(this.B_Search);
            this.Controls.Add(this.CB_SearchBy);
            this.Controls.Add(this.TB_StudentSearch);
            this.Controls.Add(this.L_StudentSearch);
            this.Name = "StudentSearch";
            this.Size = new System.Drawing.Size(489, 235);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Instruction;
        private System.Windows.Forms.DataGridView DGV_Students;
        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.ComboBox CB_SearchBy;
        private System.Windows.Forms.TextBox TB_StudentSearch;
        private System.Windows.Forms.Label L_StudentSearch;
    }
}
