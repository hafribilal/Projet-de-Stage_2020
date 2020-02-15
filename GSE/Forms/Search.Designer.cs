namespace GSE
{
    partial class Search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classes = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_NotSigned = new System.Windows.Forms.CheckBox();
            this.check_Signed = new System.Windows.Forms.CheckBox();
            this.Check_Female = new System.Windows.Forms.CheckBox();
            this.check_Male = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(924, 528);
            this.dgv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check_NotSigned);
            this.panel1.Controls.Add(this.check_Signed);
            this.panel1.Controls.Add(this.Check_Female);
            this.panel1.Controls.Add(this.check_Male);
            this.panel1.Controls.Add(this.combo_Niveaus);
            this.panel1.Controls.Add(this.combo_Classes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 60);
            this.panel1.TabIndex = 1;
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(845, 15);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(73, 33);
            this.combo_Niveaus.TabIndex = 0;
            // 
            // combo_Classes
            // 
            this.combo_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classes.FormattingEnabled = true;
            this.combo_Classes.Location = new System.Drawing.Point(591, 15);
            this.combo_Classes.Name = "combo_Classes";
            this.combo_Classes.Size = new System.Drawing.Size(248, 33);
            this.combo_Classes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 528);
            this.panel2.TabIndex = 2;
            // 
            // check_NotSigned
            // 
            this.check_NotSigned.AutoSize = true;
            this.check_NotSigned.Checked = true;
            this.check_NotSigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_NotSigned.Location = new System.Drawing.Point(409, 31);
            this.check_NotSigned.Name = "check_NotSigned";
            this.check_NotSigned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_NotSigned.Size = new System.Drawing.Size(106, 17);
            this.check_NotSigned.TabIndex = 6;
            this.check_NotSigned.Text = "غـيـر المـسـجـلـون";
            this.check_NotSigned.UseVisualStyleBackColor = true;
            // 
            // check_Signed
            // 
            this.check_Signed.AutoSize = true;
            this.check_Signed.Checked = true;
            this.check_Signed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Signed.Location = new System.Drawing.Point(434, 13);
            this.check_Signed.Name = "check_Signed";
            this.check_Signed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_Signed.Size = new System.Drawing.Size(81, 17);
            this.check_Signed.TabIndex = 7;
            this.check_Signed.Text = "المـسـجـلـون";
            this.check_Signed.UseVisualStyleBackColor = true;
            // 
            // Check_Female
            // 
            this.Check_Female.AutoSize = true;
            this.Check_Female.Checked = true;
            this.Check_Female.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Female.Location = new System.Drawing.Point(526, 14);
            this.Check_Female.Name = "Check_Female";
            this.Check_Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Check_Female.Size = new System.Drawing.Size(46, 17);
            this.Check_Female.TabIndex = 8;
            this.Check_Female.Text = "إناث";
            this.Check_Female.UseVisualStyleBackColor = true;
            // 
            // check_Male
            // 
            this.check_Male.AutoSize = true;
            this.check_Male.Checked = true;
            this.check_Male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Male.Location = new System.Drawing.Point(523, 31);
            this.check_Male.Name = "check_Male";
            this.check_Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_Male.Size = new System.Drawing.Size(49, 17);
            this.check_Male.TabIndex = 9;
            this.check_Male.Text = "ذكور";
            this.check_Male.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox check_NotSigned;
        private System.Windows.Forms.CheckBox check_Signed;
        private System.Windows.Forms.CheckBox Check_Female;
        private System.Windows.Forms.CheckBox check_Male;
    }
}