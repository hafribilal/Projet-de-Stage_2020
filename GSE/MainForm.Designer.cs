namespace GSE
{
    partial class MainForm
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
            this.p_Header = new System.Windows.Forms.Panel();
            this.cBox_Annee = new System.Windows.Forms.ComboBox();
            this.p_Nav = new System.Windows.Forms.Panel();
            this.p_SubNav = new System.Windows.Forms.Panel();
            this.listEleve1 = new GSE.UC.Students.ListEleve();
            this.p_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Header
            // 
            this.p_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.p_Header.Controls.Add(this.cBox_Annee);
            this.p_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Header.Location = new System.Drawing.Point(0, 0);
            this.p_Header.Name = "p_Header";
            this.p_Header.Size = new System.Drawing.Size(1253, 66);
            this.p_Header.TabIndex = 0;
            // 
            // cBox_Annee
            // 
            this.cBox_Annee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cBox_Annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Annee.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBox_Annee.FormattingEnabled = true;
            this.cBox_Annee.Items.AddRange(new object[] {
            "-"});
            this.cBox_Annee.Location = new System.Drawing.Point(832, 12);
            this.cBox_Annee.Name = "cBox_Annee";
            this.cBox_Annee.Size = new System.Drawing.Size(200, 37);
            this.cBox_Annee.TabIndex = 0;
            // 
            // p_Nav
            // 
            this.p_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.p_Nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_Nav.Location = new System.Drawing.Point(1163, 66);
            this.p_Nav.Name = "p_Nav";
            this.p_Nav.Size = new System.Drawing.Size(90, 575);
            this.p_Nav.TabIndex = 1;
            // 
            // p_SubNav
            // 
            this.p_SubNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(98)))));
            this.p_SubNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_SubNav.Location = new System.Drawing.Point(963, 66);
            this.p_SubNav.Name = "p_SubNav";
            this.p_SubNav.Size = new System.Drawing.Size(200, 575);
            this.p_SubNav.TabIndex = 2;
            // 
            // listEleve1
            // 
            this.listEleve1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEleve1.Location = new System.Drawing.Point(0, 66);
            this.listEleve1.Name = "listEleve1";
            this.listEleve1.Size = new System.Drawing.Size(963, 575);
            this.listEleve1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(119)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1253, 641);
            this.Controls.Add(this.listEleve1);
            this.Controls.Add(this.p_SubNav);
            this.Controls.Add(this.p_Nav);
            this.Controls.Add(this.p_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "GSE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.p_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Header;
        private System.Windows.Forms.Panel p_Nav;
        private System.Windows.Forms.Panel p_SubNav;
        private System.Windows.Forms.ComboBox cBox_Annee;
        private UC.Students.ListEleve listEleve1;
    }
}

