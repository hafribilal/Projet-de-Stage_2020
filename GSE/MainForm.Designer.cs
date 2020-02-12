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
            this.p_Nav = new System.Windows.Forms.Panel();
            this.p_SubNav = new System.Windows.Forms.Panel();
            this.cBox_Annee = new System.Windows.Forms.ComboBox();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.p_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Header
            // 
            this.p_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.p_Header.Controls.Add(this.btn_Close);
            this.p_Header.Controls.Add(this.btn_Search);
            this.p_Header.Controls.Add(this.tBox_Search);
            this.p_Header.Controls.Add(this.lbl_Logo);
            this.p_Header.Controls.Add(this.cBox_Annee);
            this.p_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Header.Location = new System.Drawing.Point(0, 0);
            this.p_Header.Name = "p_Header";
            this.p_Header.Size = new System.Drawing.Size(1122, 66);
            this.p_Header.TabIndex = 0;
            // 
            // p_Nav
            // 
            this.p_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.p_Nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_Nav.Location = new System.Drawing.Point(1032, 66);
            this.p_Nav.Name = "p_Nav";
            this.p_Nav.Size = new System.Drawing.Size(90, 575);
            this.p_Nav.TabIndex = 1;
            // 
            // p_SubNav
            // 
            this.p_SubNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(98)))));
            this.p_SubNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_SubNav.Location = new System.Drawing.Point(832, 66);
            this.p_SubNav.Name = "p_SubNav";
            this.p_SubNav.Size = new System.Drawing.Size(200, 575);
            this.p_SubNav.TabIndex = 2;
            // 
            // cBox_Annee
            // 
            this.cBox_Annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Annee.FormattingEnabled = true;
            this.cBox_Annee.Location = new System.Drawing.Point(832, 16);
            this.cBox_Annee.Name = "cBox_Annee";
            this.cBox_Annee.Size = new System.Drawing.Size(200, 37);
            this.cBox_Annee.TabIndex = 0;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Rakkas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Logo.Location = new System.Drawing.Point(12, 6);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(92, 55);
            this.lbl_Logo.TabIndex = 1;
            this.lbl_Logo.Text = "GSE";
            // 
            // tBox_Search
            // 
            this.tBox_Search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox_Search.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tBox_Search.Location = new System.Drawing.Point(111, 9);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(421, 50);
            this.tBox_Search.TabIndex = 2;
            this.tBox_Search.Text = "Type somethings ...";
            this.tBox_Search.TextChanged += new System.EventHandler(this.tBox_Search_TextChanged);
            this.tBox_Search.Enter += new System.EventHandler(this.tBox_Search_Enter);
            this.tBox_Search.Leave += new System.EventHandler(this.tBox_Search_Leave);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(538, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(143, 50);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::GSE.Properties.Resources.shutdown_40px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(1052, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 37);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(119)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1122, 641);
            this.Controls.Add(this.p_SubNav);
            this.Controls.Add(this.p_Nav);
            this.Controls.Add(this.p_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "GSE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.p_Header.ResumeLayout(false);
            this.p_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Header;
        private System.Windows.Forms.Panel p_Nav;
        private System.Windows.Forms.Panel p_SubNav;
        private System.Windows.Forms.ComboBox cBox_Annee;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Button btn_Close;
    }
}

