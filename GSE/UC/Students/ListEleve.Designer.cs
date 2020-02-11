namespace GSE.UC.Students
{
    partial class ListEleve
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
            this.p_Statistics = new System.Windows.Forms.Panel();
            this.p_Tools = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.rBtn_Gender_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Gender_Male = new System.Windows.Forms.RadioButton();
            this.cBox_Classes = new System.Windows.Forms.ComboBox();
            this.cBox_Niveaus = new System.Windows.Forms.ComboBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.p_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Statistics
            // 
            this.p_Statistics.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Statistics.Location = new System.Drawing.Point(0, 0);
            this.p_Statistics.Name = "p_Statistics";
            this.p_Statistics.Size = new System.Drawing.Size(966, 64);
            this.p_Statistics.TabIndex = 0;
            // 
            // p_Tools
            // 
            this.p_Tools.Controls.Add(this.btn_Print);
            this.p_Tools.Controls.Add(this.btn_Statistics);
            this.p_Tools.Controls.Add(this.btn_Import);
            this.p_Tools.Controls.Add(this.cBox_Niveaus);
            this.p_Tools.Controls.Add(this.cBox_Classes);
            this.p_Tools.Controls.Add(this.rBtn_Gender_Male);
            this.p_Tools.Controls.Add(this.rBtn_Gender_Female);
            this.p_Tools.Controls.Add(this.btn_Sync);
            this.p_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Tools.Location = new System.Drawing.Point(0, 64);
            this.p_Tools.Name = "p_Tools";
            this.p_Tools.Size = new System.Drawing.Size(966, 45);
            this.p_Tools.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 109);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(966, 509);
            this.dgv.TabIndex = 2;
            // 
            // btn_Sync
            // 
            this.btn_Sync.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sync.BackgroundImage = global::GSE.Properties.Resources.synchronize_32px;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Sync.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sync.Location = new System.Drawing.Point(4, 6);
            this.btn_Sync.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(38, 33);
            this.btn_Sync.TabIndex = 0;
            this.btn_Sync.UseVisualStyleBackColor = false;
            // 
            // rBtn_Gender_Female
            // 
            this.rBtn_Gender_Female.AutoSize = true;
            this.rBtn_Gender_Female.Location = new System.Drawing.Point(45, 6);
            this.rBtn_Gender_Female.Name = "rBtn_Gender_Female";
            this.rBtn_Gender_Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rBtn_Gender_Female.Size = new System.Drawing.Size(59, 17);
            this.rBtn_Gender_Female.TabIndex = 1;
            this.rBtn_Gender_Female.TabStop = true;
            this.rBtn_Gender_Female.Text = "Female";
            this.rBtn_Gender_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_Gender_Male
            // 
            this.rBtn_Gender_Male.AutoSize = true;
            this.rBtn_Gender_Male.Location = new System.Drawing.Point(56, 22);
            this.rBtn_Gender_Male.Name = "rBtn_Gender_Male";
            this.rBtn_Gender_Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rBtn_Gender_Male.Size = new System.Drawing.Size(48, 17);
            this.rBtn_Gender_Male.TabIndex = 2;
            this.rBtn_Gender_Male.TabStop = true;
            this.rBtn_Gender_Male.Text = "Male";
            this.rBtn_Gender_Male.UseVisualStyleBackColor = true;
            // 
            // cBox_Classes
            // 
            this.cBox_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Classes.FormattingEnabled = true;
            this.cBox_Classes.Location = new System.Drawing.Point(110, 6);
            this.cBox_Classes.Name = "cBox_Classes";
            this.cBox_Classes.Size = new System.Drawing.Size(261, 33);
            this.cBox_Classes.TabIndex = 3;
            this.cBox_Classes.Text = "*";
            // 
            // cBox_Niveaus
            // 
            this.cBox_Niveaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Niveaus.FormattingEnabled = true;
            this.cBox_Niveaus.Location = new System.Drawing.Point(377, 6);
            this.cBox_Niveaus.Name = "cBox_Niveaus";
            this.cBox_Niveaus.Size = new System.Drawing.Size(120, 33);
            this.cBox_Niveaus.TabIndex = 4;
            this.cBox_Niveaus.Text = "*";
            // 
            // btn_Import
            // 
            this.btn_Import.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(503, 6);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(186, 33);
            this.btn_Import.TabIndex = 5;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistics.Location = new System.Drawing.Point(695, 6);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(131, 33);
            this.btn_Statistics.TabIndex = 6;
            this.btn_Statistics.Text = "Statistics";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(832, 6);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(131, 33);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // ListEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.p_Tools);
            this.Controls.Add(this.p_Statistics);
            this.Name = "ListEleve";
            this.Size = new System.Drawing.Size(966, 618);
            this.Load += new System.EventHandler(this.ListEleve_Load);
            this.p_Tools.ResumeLayout(false);
            this.p_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Statistics;
        private System.Windows.Forms.Panel p_Tools;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.ComboBox cBox_Niveaus;
        private System.Windows.Forms.ComboBox cBox_Classes;
        private System.Windows.Forms.RadioButton rBtn_Gender_Male;
        private System.Windows.Forms.RadioButton rBtn_Gender_Female;
    }
}
