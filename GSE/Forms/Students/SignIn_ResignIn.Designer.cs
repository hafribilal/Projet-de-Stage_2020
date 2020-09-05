namespace GSE.Forms.Students
{
    partial class SignIn_ResignIn
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
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classe = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_NotSignedMalesTitle = new System.Windows.Forms.Label();
            this.lbl_NotSignedMalesCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_NotSignedFemalesCount = new System.Windows.Forms.Label();
            this.lbl_NotSignedFemalesTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_NotSignedCount = new System.Windows.Forms.Label();
            this.lbl_NotSignedTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_SignedInMalesTitle = new System.Windows.Forms.Label();
            this.lbl_SignedInMalesCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SignedInFemalesCount = new System.Windows.Forms.Label();
            this.lbl_SignedInFemalesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SignedInCount = new System.Windows.Forms.Label();
            this.lbl_SignedInTitle = new System.Windows.Forms.Label();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Statistics.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Tools.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 127);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(924, 461);
            this.pnl_Container.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(924, 461);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseDoubleClick);
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.Controls.Add(this.pnl_Btns);
            this.pnl_Statistics.Controls.Add(this.combo_Niveaus);
            this.pnl_Statistics.Controls.Add(this.combo_Classe);
            this.pnl_Statistics.Controls.Add(this.btn_Save);
            this.pnl_Statistics.Controls.Add(this.btn_Sync);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 63);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 64);
            this.pnl_Statistics.TabIndex = 10;
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Statistics);
            this.pnl_Btns.Controls.Add(this.btn_Print);
            this.pnl_Btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Btns.Location = new System.Drawing.Point(772, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(152, 64);
            this.pnl_Btns.TabIndex = 13;
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackgroundImage = global::GSE.Properties.Resources.statistics_80px;
            this.btn_Statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Statistics.FlatAppearance.BorderSize = 0;
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistics.Location = new System.Drawing.Point(17, 14);
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
            this.btn_Print.Location = new System.Drawing.Point(81, 14);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(58, 45);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(359, 14);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(76, 38);
            this.combo_Niveaus.TabIndex = 11;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged_1);
            // 
            // combo_Classe
            // 
            this.combo_Classe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classe.FormattingEnabled = true;
            this.combo_Classe.Location = new System.Drawing.Point(140, 14);
            this.combo_Classe.Name = "combo_Classe";
            this.combo_Classe.Size = new System.Drawing.Size(213, 38);
            this.combo_Classe.TabIndex = 12;
            this.combo_Classe.SelectedIndexChanged += new System.EventHandler(this.combo_Classe_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::GSE.Properties.Resources.save_30px;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(62, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(54, 44);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sync
            // 
            this.btn_Sync.BackgroundImage = global::GSE.Properties.Resources.synchronize_80px;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sync.FlatAppearance.BorderSize = 0;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sync.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Location = new System.Drawing.Point(2, 14);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(54, 44);
            this.btn_Sync.TabIndex = 10;
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Tools.Controls.Add(this.panel4);
            this.pnl_Tools.Controls.Add(this.panel5);
            this.pnl_Tools.Controls.Add(this.panel6);
            this.pnl_Tools.Controls.Add(this.panel3);
            this.pnl_Tools.Controls.Add(this.panel2);
            this.pnl_Tools.Controls.Add(this.panel1);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(924, 63);
            this.pnl_Tools.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_NotSignedMalesTitle);
            this.panel4.Controls.Add(this.lbl_NotSignedMalesCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 63);
            this.panel4.TabIndex = 4;
            // 
            // lbl_NotSignedMalesTitle
            // 
            this.lbl_NotSignedMalesTitle.AutoSize = true;
            this.lbl_NotSignedMalesTitle.Location = new System.Drawing.Point(23, 9);
            this.lbl_NotSignedMalesTitle.Name = "lbl_NotSignedMalesTitle";
            this.lbl_NotSignedMalesTitle.Size = new System.Drawing.Size(101, 13);
            this.lbl_NotSignedMalesTitle.TabIndex = 0;
            this.lbl_NotSignedMalesTitle.Text = "غير المسجلون الذكور";
            // 
            // lbl_NotSignedMalesCount
            // 
            this.lbl_NotSignedMalesCount.AutoSize = true;
            this.lbl_NotSignedMalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotSignedMalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotSignedMalesCount.Location = new System.Drawing.Point(57, 28);
            this.lbl_NotSignedMalesCount.Name = "lbl_NotSignedMalesCount";
            this.lbl_NotSignedMalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotSignedMalesCount.TabIndex = 0;
            this.lbl_NotSignedMalesCount.Text = "0";
            this.lbl_NotSignedMalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_NotSignedFemalesCount);
            this.panel5.Controls.Add(this.lbl_NotSignedFemalesTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(161, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 63);
            this.panel5.TabIndex = 3;
            // 
            // lbl_NotSignedFemalesCount
            // 
            this.lbl_NotSignedFemalesCount.AutoSize = true;
            this.lbl_NotSignedFemalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotSignedFemalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotSignedFemalesCount.Location = new System.Drawing.Point(63, 28);
            this.lbl_NotSignedFemalesCount.Name = "lbl_NotSignedFemalesCount";
            this.lbl_NotSignedFemalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotSignedFemalesCount.TabIndex = 0;
            this.lbl_NotSignedFemalesCount.Text = "0";
            this.lbl_NotSignedFemalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotSignedFemalesTitle
            // 
            this.lbl_NotSignedFemalesTitle.AutoSize = true;
            this.lbl_NotSignedFemalesTitle.Location = new System.Drawing.Point(29, 9);
            this.lbl_NotSignedFemalesTitle.Name = "lbl_NotSignedFemalesTitle";
            this.lbl_NotSignedFemalesTitle.Size = new System.Drawing.Size(97, 13);
            this.lbl_NotSignedFemalesTitle.TabIndex = 0;
            this.lbl_NotSignedFemalesTitle.Text = "غير المسجلون الإناث";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_NotSignedCount);
            this.panel6.Controls.Add(this.lbl_NotSignedTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(314, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 63);
            this.panel6.TabIndex = 2;
            // 
            // lbl_NotSignedCount
            // 
            this.lbl_NotSignedCount.AutoSize = true;
            this.lbl_NotSignedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotSignedCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotSignedCount.Location = new System.Drawing.Point(61, 28);
            this.lbl_NotSignedCount.Name = "lbl_NotSignedCount";
            this.lbl_NotSignedCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotSignedCount.TabIndex = 0;
            this.lbl_NotSignedCount.Text = "0";
            this.lbl_NotSignedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotSignedTitle
            // 
            this.lbl_NotSignedTitle.AutoSize = true;
            this.lbl_NotSignedTitle.Location = new System.Drawing.Point(42, 9);
            this.lbl_NotSignedTitle.Name = "lbl_NotSignedTitle";
            this.lbl_NotSignedTitle.Size = new System.Drawing.Size(69, 13);
            this.lbl_NotSignedTitle.TabIndex = 0;
            this.lbl_NotSignedTitle.Text = "غير المسجلون";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_SignedInMalesTitle);
            this.panel3.Controls.Add(this.lbl_SignedInMalesCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(466, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 63);
            this.panel3.TabIndex = 1;
            // 
            // lbl_SignedInMalesTitle
            // 
            this.lbl_SignedInMalesTitle.AutoSize = true;
            this.lbl_SignedInMalesTitle.Location = new System.Drawing.Point(38, 9);
            this.lbl_SignedInMalesTitle.Name = "lbl_SignedInMalesTitle";
            this.lbl_SignedInMalesTitle.Size = new System.Drawing.Size(82, 13);
            this.lbl_SignedInMalesTitle.TabIndex = 0;
            this.lbl_SignedInMalesTitle.Text = "المسجلون الذكور";
            // 
            // lbl_SignedInMalesCount
            // 
            this.lbl_SignedInMalesCount.AutoSize = true;
            this.lbl_SignedInMalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignedInMalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SignedInMalesCount.Location = new System.Drawing.Point(62, 28);
            this.lbl_SignedInMalesCount.Name = "lbl_SignedInMalesCount";
            this.lbl_SignedInMalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_SignedInMalesCount.TabIndex = 0;
            this.lbl_SignedInMalesCount.Text = "0";
            this.lbl_SignedInMalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_SignedInFemalesCount);
            this.panel2.Controls.Add(this.lbl_SignedInFemalesTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(619, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 63);
            this.panel2.TabIndex = 1;
            // 
            // lbl_SignedInFemalesCount
            // 
            this.lbl_SignedInFemalesCount.AutoSize = true;
            this.lbl_SignedInFemalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignedInFemalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SignedInFemalesCount.Location = new System.Drawing.Point(61, 28);
            this.lbl_SignedInFemalesCount.Name = "lbl_SignedInFemalesCount";
            this.lbl_SignedInFemalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_SignedInFemalesCount.TabIndex = 0;
            this.lbl_SignedInFemalesCount.Text = "0";
            this.lbl_SignedInFemalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SignedInFemalesTitle
            // 
            this.lbl_SignedInFemalesTitle.AutoSize = true;
            this.lbl_SignedInFemalesTitle.Location = new System.Drawing.Point(40, 9);
            this.lbl_SignedInFemalesTitle.Name = "lbl_SignedInFemalesTitle";
            this.lbl_SignedInFemalesTitle.Size = new System.Drawing.Size(78, 13);
            this.lbl_SignedInFemalesTitle.TabIndex = 0;
            this.lbl_SignedInFemalesTitle.Text = "المسجلون الإناث";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_SignedInCount);
            this.panel1.Controls.Add(this.lbl_SignedInTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(772, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 63);
            this.panel1.TabIndex = 0;
            // 
            // lbl_SignedInCount
            // 
            this.lbl_SignedInCount.AutoSize = true;
            this.lbl_SignedInCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignedInCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SignedInCount.Location = new System.Drawing.Point(61, 28);
            this.lbl_SignedInCount.Name = "lbl_SignedInCount";
            this.lbl_SignedInCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_SignedInCount.TabIndex = 0;
            this.lbl_SignedInCount.Text = "0";
            this.lbl_SignedInCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SignedInTitle
            // 
            this.lbl_SignedInTitle.AutoSize = true;
            this.lbl_SignedInTitle.Location = new System.Drawing.Point(52, 9);
            this.lbl_SignedInTitle.Name = "lbl_SignedInTitle";
            this.lbl_SignedInTitle.Size = new System.Drawing.Size(50, 13);
            this.lbl_SignedInTitle.TabIndex = 0;
            this.lbl_SignedInTitle.Text = "المسجلون";
            // 
            // SignIn_ResignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Statistics);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn_ResignIn";
            this.Text = "SignIn_ResignIn";
            this.Load += new System.EventHandler(this.SignIn_ResignIn_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Statistics.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Tools.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_SignedInMalesTitle;
        private System.Windows.Forms.Label lbl_SignedInMalesCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_SignedInFemalesCount;
        private System.Windows.Forms.Label lbl_SignedInFemalesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SignedInCount;
        private System.Windows.Forms.Label lbl_SignedInTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_NotSignedMalesTitle;
        private System.Windows.Forms.Label lbl_NotSignedMalesCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_NotSignedFemalesCount;
        private System.Windows.Forms.Label lbl_NotSignedFemalesTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_NotSignedCount;
        private System.Windows.Forms.Label lbl_NotSignedTitle;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sync;
    }
}