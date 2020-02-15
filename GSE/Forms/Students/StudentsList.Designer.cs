namespace GSE
{
    partial class StudentsList
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Import_img = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.check_NotSigned = new System.Windows.Forms.CheckBox();
            this.check_Signed = new System.Windows.Forms.CheckBox();
            this.check_Male = new System.Windows.Forms.CheckBox();
            this.Check_Female = new System.Windows.Forms.CheckBox();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classes = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.pnl_Searchtools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Searchtools.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.Location = new System.Drawing.Point(0, 136);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(924, 452);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Statistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 0);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 61);
            this.pnl_Statistics.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pnl_Searchtools);
            this.panel2.Controls.Add(this.pnl_Btns);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 80);
            this.panel2.TabIndex = 2;
            // 
            // btn_Import_img
            // 
            this.btn_Import_img.BackgroundImage = global::GSE.Properties.Resources.microsoft_excel_80px;
            this.btn_Import_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Import_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import_img.FlatAppearance.BorderSize = 0;
            this.btn_Import_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import_img.Location = new System.Drawing.Point(7, 13);
            this.btn_Import_img.Name = "btn_Import_img";
            this.btn_Import_img.Size = new System.Drawing.Size(55, 45);
            this.btn_Import_img.TabIndex = 6;
            this.btn_Import_img.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(7, 13);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(148, 45);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "إسـتـيـراد";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackgroundImage = global::GSE.Properties.Resources.statistics_80px;
            this.btn_Statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Statistics.FlatAppearance.BorderSize = 0;
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistics.Location = new System.Drawing.Point(170, 14);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(58, 45);
            this.btn_Statistics.TabIndex = 6;
            this.btn_Statistics.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.BackgroundImage = global::GSE.Properties.Resources.print_80px;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Location = new System.Drawing.Point(234, 14);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(58, 45);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // check_NotSigned
            // 
            this.check_NotSigned.AutoSize = true;
            this.check_NotSigned.Checked = true;
            this.check_NotSigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_NotSigned.Location = new System.Drawing.Point(50, 40);
            this.check_NotSigned.Name = "check_NotSigned";
            this.check_NotSigned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_NotSigned.Size = new System.Drawing.Size(106, 17);
            this.check_NotSigned.TabIndex = 5;
            this.check_NotSigned.Text = "غـيـر المـسـجـلـون";
            this.check_NotSigned.UseVisualStyleBackColor = true;
            // 
            // check_Signed
            // 
            this.check_Signed.AutoSize = true;
            this.check_Signed.Checked = true;
            this.check_Signed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Signed.Location = new System.Drawing.Point(75, 22);
            this.check_Signed.Name = "check_Signed";
            this.check_Signed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_Signed.Size = new System.Drawing.Size(81, 17);
            this.check_Signed.TabIndex = 5;
            this.check_Signed.Text = "المـسـجـلـون";
            this.check_Signed.UseVisualStyleBackColor = true;
            // 
            // check_Male
            // 
            this.check_Male.AutoSize = true;
            this.check_Male.Checked = true;
            this.check_Male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Male.Location = new System.Drawing.Point(164, 40);
            this.check_Male.Name = "check_Male";
            this.check_Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_Male.Size = new System.Drawing.Size(49, 17);
            this.check_Male.TabIndex = 5;
            this.check_Male.Text = " ذكـر";
            this.check_Male.UseVisualStyleBackColor = true;
            // 
            // Check_Female
            // 
            this.Check_Female.AutoSize = true;
            this.Check_Female.Checked = true;
            this.Check_Female.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Female.Location = new System.Drawing.Point(164, 23);
            this.Check_Female.Name = "Check_Female";
            this.Check_Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Check_Female.Size = new System.Drawing.Size(49, 17);
            this.Check_Female.TabIndex = 5;
            this.Check_Female.Text = "أنثى";
            this.Check_Female.UseVisualStyleBackColor = true;
            this.Check_Female.CheckedChanged += new System.EventHandler(this.Check_Female_CheckedChanged);
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(482, 20);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(132, 39);
            this.combo_Niveaus.TabIndex = 4;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged);
            // 
            // combo_Classes
            // 
            this.combo_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classes.FormattingEnabled = true;
            this.combo_Classes.Location = new System.Drawing.Point(222, 20);
            this.combo_Classes.Name = "combo_Classes";
            this.combo_Classes.Size = new System.Drawing.Size(254, 39);
            this.combo_Classes.TabIndex = 4;
            this.combo_Classes.SelectedIndexChanged += new System.EventHandler(this.combo_Classes_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 10);
            this.panel3.TabIndex = 3;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::GSE.Properties.Resources.synchronize_80px;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(3, 18);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(41, 42);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Statistics);
            this.pnl_Btns.Controls.Add(this.btn_Import_img);
            this.pnl_Btns.Controls.Add(this.btn_Print);
            this.pnl_Btns.Controls.Add(this.btn_Import);
            this.pnl_Btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Btns.Location = new System.Drawing.Point(630, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(294, 70);
            this.pnl_Btns.TabIndex = 8;
            // 
            // pnl_Searchtools
            // 
            this.pnl_Searchtools.Controls.Add(this.combo_Classes);
            this.pnl_Searchtools.Controls.Add(this.combo_Niveaus);
            this.pnl_Searchtools.Controls.Add(this.check_NotSigned);
            this.pnl_Searchtools.Controls.Add(this.btn_Refresh);
            this.pnl_Searchtools.Controls.Add(this.check_Signed);
            this.pnl_Searchtools.Controls.Add(this.Check_Female);
            this.pnl_Searchtools.Controls.Add(this.check_Male);
            this.pnl_Searchtools.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Searchtools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Searchtools.Name = "pnl_Searchtools";
            this.pnl_Searchtools.Size = new System.Drawing.Size(624, 70);
            this.pnl_Searchtools.TabIndex = 9;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Statistics);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsList";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Searchtools.ResumeLayout(false);
            this.pnl_Searchtools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.CheckBox check_Male;
        private System.Windows.Forms.CheckBox Check_Female;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Import_img;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.CheckBox check_NotSigned;
        private System.Windows.Forms.CheckBox check_Signed;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Panel pnl_Searchtools;
    }
}