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
            this.pnl_Searchtools = new System.Windows.Forms.Panel();
            this.combo_Classes = new System.Windows.Forms.ComboBox();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Import_img = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalFemales = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_TotalMales = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_NumAvg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Statistics.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Searchtools.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(924, 447);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Statistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Statistics.Controls.Add(this.panel6);
            this.pnl_Statistics.Controls.Add(this.panel5);
            this.pnl_Statistics.Controls.Add(this.panel4);
            this.pnl_Statistics.Controls.Add(this.panel1);
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
            // pnl_Searchtools
            // 
            this.pnl_Searchtools.Controls.Add(this.combo_Classes);
            this.pnl_Searchtools.Controls.Add(this.combo_Niveaus);
            this.pnl_Searchtools.Controls.Add(this.btn_Refresh);
            this.pnl_Searchtools.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Searchtools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Searchtools.Name = "pnl_Searchtools";
            this.pnl_Searchtools.Size = new System.Drawing.Size(624, 70);
            this.pnl_Searchtools.TabIndex = 9;
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
            // btn_Import
            // 
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(7, 13);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(148, 45);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "إستيراد";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
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
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 141);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(924, 447);
            this.pnl_Container.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(715, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 57);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Total.Location = new System.Drawing.Point(87, 23);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(36, 37);
            this.lbl_Total.TabIndex = 0;
            this.lbl_Total.Text = "0";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbl_TotalFemales);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(510, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 57);
            this.panel4.TabIndex = 1;
            // 
            // lbl_TotalFemales
            // 
            this.lbl_TotalFemales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalFemales.AutoSize = true;
            this.lbl_TotalFemales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalFemales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalFemales.Location = new System.Drawing.Point(87, 23);
            this.lbl_TotalFemales.Name = "lbl_TotalFemales";
            this.lbl_TotalFemales.Size = new System.Drawing.Size(36, 37);
            this.lbl_TotalFemales.TabIndex = 0;
            this.lbl_TotalFemales.Text = "0";
            this.lbl_TotalFemales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbl_TotalMales);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(305, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 57);
            this.panel5.TabIndex = 2;
            // 
            // lbl_TotalMales
            // 
            this.lbl_TotalMales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalMales.AutoSize = true;
            this.lbl_TotalMales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalMales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalMales.Location = new System.Drawing.Point(86, 24);
            this.lbl_TotalMales.Name = "lbl_TotalMales";
            this.lbl_TotalMales.Size = new System.Drawing.Size(36, 37);
            this.lbl_TotalMales.TabIndex = 0;
            this.lbl_TotalMales.Text = "0";
            this.lbl_TotalMales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lbl_NumAvg);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(100, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 57);
            this.panel6.TabIndex = 3;
            // 
            // lbl_NumAvg
            // 
            this.lbl_NumAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NumAvg.AutoSize = true;
            this.lbl_NumAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumAvg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NumAvg.Location = new System.Drawing.Point(86, 23);
            this.lbl_NumAvg.Name = "lbl_NumAvg";
            this.lbl_NumAvg.Size = new System.Drawing.Size(36, 37);
            this.lbl_NumAvg.TabIndex = 0;
            this.lbl_NumAvg.Text = "0";
            this.lbl_NumAvg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "مجموع التلاميذ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "مجموع الإناث";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "مجموع الذكور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "معدل القسم";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Statistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsList";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Statistics.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Searchtools.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Import_img;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Panel pnl_Searchtools;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_NumAvg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_TotalMales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_TotalFemales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}