namespace GSE.Forms.Exams
{
    partial class MarkSheets
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.combo_Semester = new System.Windows.Forms.ComboBox();
            this.combo_Profs = new System.Windows.Forms.ComboBox();
            this.combo_Classes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Show);
            this.panel1.Controls.Add(this.combo_Semester);
            this.panel1.Controls.Add(this.combo_Profs);
            this.panel1.Controls.Add(this.combo_Classes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 29);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "القسم :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "الدورة :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "الأستاذة :";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(4, 21);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(67, 28);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Text = "عرض";
            this.btn_Show.UseVisualStyleBackColor = true;
            // 
            // combo_Semester
            // 
            this.combo_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Semester.FormattingEnabled = true;
            this.combo_Semester.Items.AddRange(new object[] {
            "الدورة الأولى",
            "الدورة الثانية"});
            this.combo_Semester.Location = new System.Drawing.Point(77, 21);
            this.combo_Semester.Name = "combo_Semester";
            this.combo_Semester.Size = new System.Drawing.Size(121, 28);
            this.combo_Semester.TabIndex = 2;
            this.combo_Semester.SelectedIndexChanged += new System.EventHandler(this.combo_Semester_SelectedIndexChanged);
            // 
            // combo_Profs
            // 
            this.combo_Profs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Profs.FormattingEnabled = true;
            this.combo_Profs.Location = new System.Drawing.Point(257, 21);
            this.combo_Profs.Name = "combo_Profs";
            this.combo_Profs.Size = new System.Drawing.Size(140, 28);
            this.combo_Profs.TabIndex = 1;
            this.combo_Profs.SelectedIndexChanged += new System.EventHandler(this.combo_Profs_SelectedIndexChanged);
            // 
            // combo_Classes
            // 
            this.combo_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classes.FormattingEnabled = true;
            this.combo_Classes.Location = new System.Drawing.Point(463, 21);
            this.combo_Classes.Name = "combo_Classes";
            this.combo_Classes.Size = new System.Drawing.Size(194, 28);
            this.combo_Classes.TabIndex = 0;
            this.combo_Classes.SelectedIndexChanged += new System.EventHandler(this.combo_Classes_SelectedIndexChanged);
            // 
            // MarkSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkSheets";
            this.Text = "MarkSheets";
            this.Load += new System.EventHandler(this.MarkSheets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox combo_Semester;
        private System.Windows.Forms.ComboBox combo_Profs;
        private System.Windows.Forms.ComboBox combo_Classes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}