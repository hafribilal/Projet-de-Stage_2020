namespace GSE.Forms.Students
{
    partial class SortingFolders
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
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 64);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(924, 524);
            this.pnl_Container.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(924, 524);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.Controls.Add(this.tBox_Search);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 0);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 64);
            this.pnl_Statistics.TabIndex = 10;
            // 
            // tBox_Search
            // 
            this.tBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Search.Location = new System.Drawing.Point(490, 17);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(283, 31);
            this.tBox_Search.TabIndex = 0;
            // 
            // SortingFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Statistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortingFolders";
            this.Text = "SortingFolders";
            this.Load += new System.EventHandler(this.SortingFolders_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Statistics.ResumeLayout(false);
            this.pnl_Statistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.TextBox tBox_Search;
    }
}