namespace GSE.Forms.Students
{
    partial class Passwords
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
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classe = new System.Windows.Forms.ComboBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Import_img = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Tools.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 63);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(924, 525);
            this.pnl_Container.TabIndex = 6;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(924, 525);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Controls.Add(this.combo_Niveaus);
            this.pnl_Tools.Controls.Add(this.combo_Classe);
            this.pnl_Tools.Controls.Add(this.btn_Sync);
            this.pnl_Tools.Controls.Add(this.pnl_Btns);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(924, 63);
            this.pnl_Tools.TabIndex = 5;
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(287, 14);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(76, 38);
            this.combo_Niveaus.TabIndex = 13;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged);
            // 
            // combo_Classe
            // 
            this.combo_Classe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classe.FormattingEnabled = true;
            this.combo_Classe.Location = new System.Drawing.Point(68, 14);
            this.combo_Classe.Name = "combo_Classe";
            this.combo_Classe.Size = new System.Drawing.Size(213, 38);
            this.combo_Classe.TabIndex = 12;
            this.combo_Classe.SelectedIndexChanged += new System.EventHandler(this.combo_Classe_SelectedIndexChanged);
            // 
            // btn_Sync
            // 
            this.btn_Sync.BackgroundImage = global::GSE.Properties.Resources.synchronize_80px;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sync.FlatAppearance.BorderSize = 0;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sync.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Location = new System.Drawing.Point(8, 10);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(54, 44);
            this.btn_Sync.TabIndex = 11;
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Import_img);
            this.pnl_Btns.Controls.Add(this.btn_Import);
            this.pnl_Btns.Controls.Add(this.btn_Print);
            this.pnl_Btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Btns.Location = new System.Drawing.Point(682, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(242, 63);
            this.pnl_Btns.TabIndex = 10;
            // 
            // btn_Print
            // 
            this.btn_Print.BackgroundImage = global::GSE.Properties.Resources.print_80px;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Location = new System.Drawing.Point(172, 9);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(58, 45);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.UseVisualStyleBackColor = true;
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
            this.btn_Import_img.Location = new System.Drawing.Point(3, 9);
            this.btn_Import_img.Name = "btn_Import_img";
            this.btn_Import_img.Size = new System.Drawing.Size(55, 45);
            this.btn_Import_img.TabIndex = 8;
            this.btn_Import_img.UseVisualStyleBackColor = true;
            this.btn_Import_img.Click += new System.EventHandler(this.btn_Import_img_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(3, 9);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(148, 45);
            this.btn_Import.TabIndex = 9;
            this.btn_Import.Text = "إسـتـيـراد";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // Passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passwords";
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.Passwords_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Tools.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_Import_img;
        private System.Windows.Forms.Button btn_Import;
    }
}