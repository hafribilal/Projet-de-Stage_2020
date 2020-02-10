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
            this.SuspendLayout();
            // 
            // p_Header
            // 
            this.p_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Header.Location = new System.Drawing.Point(0, 0);
            this.p_Header.Name = "p_Header";
            this.p_Header.Size = new System.Drawing.Size(1122, 66);
            this.p_Header.TabIndex = 0;
            // 
            // p_Nav
            // 
            this.p_Nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_Nav.Location = new System.Drawing.Point(1032, 66);
            this.p_Nav.Name = "p_Nav";
            this.p_Nav.Size = new System.Drawing.Size(90, 575);
            this.p_Nav.TabIndex = 1;
            // 
            // p_SubNav
            // 
            this.p_SubNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_SubNav.Location = new System.Drawing.Point(832, 66);
            this.p_SubNav.Name = "p_SubNav";
            this.p_SubNav.Size = new System.Drawing.Size(200, 575);
            this.p_SubNav.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 641);
            this.Controls.Add(this.p_SubNav);
            this.Controls.Add(this.p_Nav);
            this.Controls.Add(this.p_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "GSE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Header;
        private System.Windows.Forms.Panel p_Nav;
        private System.Windows.Forms.Panel p_SubNav;
    }
}

