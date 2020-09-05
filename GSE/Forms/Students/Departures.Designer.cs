namespace GSE.Forms.Students
{
    partial class Departures
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
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesSwitchingProgressCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesSwitchingProgressTitle = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesOutDirectionCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesOutDirectionTitle = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesInDirectionCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesInDirectionTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesOutAdministrationCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesOutAdministrationTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesInAdmistrationCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesInAdmistrationTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesInCommuneCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesInCommuneTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesMalesCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesMalesTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesFemalesCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesFemalesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesTitle = new System.Windows.Forms.Label();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Tools.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Statistics.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.pnl_Container.TabIndex = 3;
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
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(924, 461);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Controls.Add(this.combo_Niveaus);
            this.pnl_Tools.Controls.Add(this.combo_Classe);
            this.pnl_Tools.Controls.Add(this.btn_Sync);
            this.pnl_Tools.Controls.Add(this.pnl_Btns);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 64);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(924, 63);
            this.pnl_Tools.TabIndex = 2;
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(283, 14);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(76, 38);
            this.combo_Niveaus.TabIndex = 18;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged);
            // 
            // combo_Classe
            // 
            this.combo_Classe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classe.FormattingEnabled = true;
            this.combo_Classe.Location = new System.Drawing.Point(64, 14);
            this.combo_Classe.Name = "combo_Classe";
            this.combo_Classe.Size = new System.Drawing.Size(213, 38);
            this.combo_Classe.TabIndex = 17;
            this.combo_Classe.SelectedIndexChanged += new System.EventHandler(this.combo_Classe_SelectedIndexChanged);
            // 
            // btn_Sync
            // 
            this.btn_Sync.BackgroundImage = global::GSE.Properties.Resources.synchronize_80px;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sync.FlatAppearance.BorderSize = 0;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sync.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Location = new System.Drawing.Point(4, 10);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(54, 44);
            this.btn_Sync.TabIndex = 16;
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Statistics);
            this.pnl_Btns.Controls.Add(this.btn_Print);
            this.pnl_Btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Btns.Location = new System.Drawing.Point(772, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(152, 63);
            this.pnl_Btns.TabIndex = 15;
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
            // pnl_Statistics
            // 
            this.pnl_Statistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Statistics.Controls.Add(this.panel9);
            this.pnl_Statistics.Controls.Add(this.panel8);
            this.pnl_Statistics.Controls.Add(this.panel7);
            this.pnl_Statistics.Controls.Add(this.panel6);
            this.pnl_Statistics.Controls.Add(this.panel5);
            this.pnl_Statistics.Controls.Add(this.panel4);
            this.pnl_Statistics.Controls.Add(this.panel3);
            this.pnl_Statistics.Controls.Add(this.panel2);
            this.pnl_Statistics.Controls.Add(this.panel1);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 0);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 64);
            this.pnl_Statistics.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_DeparturesSwitchingProgressCount);
            this.panel9.Controls.Add(this.lbl_DeparturesSwitchingProgressTitle);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(6, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(102, 64);
            this.panel9.TabIndex = 0;
            // 
            // lbl_DeparturesSwitchingProgressCount
            // 
            this.lbl_DeparturesSwitchingProgressCount.AutoSize = true;
            this.lbl_DeparturesSwitchingProgressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesSwitchingProgressCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesSwitchingProgressCount.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeparturesSwitchingProgressCount.Name = "lbl_DeparturesSwitchingProgressCount";
            this.lbl_DeparturesSwitchingProgressCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesSwitchingProgressCount.TabIndex = 0;
            this.lbl_DeparturesSwitchingProgressCount.Text = "0";
            // 
            // lbl_DeparturesSwitchingProgressTitle
            // 
            this.lbl_DeparturesSwitchingProgressTitle.AutoSize = true;
            this.lbl_DeparturesSwitchingProgressTitle.Location = new System.Drawing.Point(11, 4);
            this.lbl_DeparturesSwitchingProgressTitle.Name = "lbl_DeparturesSwitchingProgressTitle";
            this.lbl_DeparturesSwitchingProgressTitle.Size = new System.Drawing.Size(81, 13);
            this.lbl_DeparturesSwitchingProgressTitle.TabIndex = 0;
            this.lbl_DeparturesSwitchingProgressTitle.Text = "في طور التحويل";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_DeparturesOutDirectionCount);
            this.panel8.Controls.Add(this.lbl_DeparturesOutDirectionTitle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(108, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(102, 64);
            this.panel8.TabIndex = 0;
            // 
            // lbl_DeparturesOutDirectionCount
            // 
            this.lbl_DeparturesOutDirectionCount.AutoSize = true;
            this.lbl_DeparturesOutDirectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesOutDirectionCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesOutDirectionCount.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeparturesOutDirectionCount.Name = "lbl_DeparturesOutDirectionCount";
            this.lbl_DeparturesOutDirectionCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesOutDirectionCount.TabIndex = 0;
            this.lbl_DeparturesOutDirectionCount.Text = "0";
            // 
            // lbl_DeparturesOutDirectionTitle
            // 
            this.lbl_DeparturesOutDirectionTitle.AutoSize = true;
            this.lbl_DeparturesOutDirectionTitle.Location = new System.Drawing.Point(21, 4);
            this.lbl_DeparturesOutDirectionTitle.Name = "lbl_DeparturesOutDirectionTitle";
            this.lbl_DeparturesOutDirectionTitle.Size = new System.Drawing.Size(58, 13);
            this.lbl_DeparturesOutDirectionTitle.TabIndex = 0;
            this.lbl_DeparturesOutDirectionTitle.Text = "خارج الجهة";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_DeparturesInDirectionCount);
            this.panel7.Controls.Add(this.lbl_DeparturesInDirectionTitle);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(210, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(102, 64);
            this.panel7.TabIndex = 0;
            // 
            // lbl_DeparturesInDirectionCount
            // 
            this.lbl_DeparturesInDirectionCount.AutoSize = true;
            this.lbl_DeparturesInDirectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesInDirectionCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesInDirectionCount.Location = new System.Drawing.Point(37, 31);
            this.lbl_DeparturesInDirectionCount.Name = "lbl_DeparturesInDirectionCount";
            this.lbl_DeparturesInDirectionCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesInDirectionCount.TabIndex = 0;
            this.lbl_DeparturesInDirectionCount.Text = "0";
            // 
            // lbl_DeparturesInDirectionTitle
            // 
            this.lbl_DeparturesInDirectionTitle.AutoSize = true;
            this.lbl_DeparturesInDirectionTitle.Location = new System.Drawing.Point(24, 4);
            this.lbl_DeparturesInDirectionTitle.Name = "lbl_DeparturesInDirectionTitle";
            this.lbl_DeparturesInDirectionTitle.Size = new System.Drawing.Size(56, 13);
            this.lbl_DeparturesInDirectionTitle.TabIndex = 0;
            this.lbl_DeparturesInDirectionTitle.Text = "داخل الجهة";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_DeparturesOutAdministrationCount);
            this.panel6.Controls.Add(this.lbl_DeparturesOutAdministrationTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(312, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 64);
            this.panel6.TabIndex = 0;
            // 
            // lbl_DeparturesOutAdministrationCount
            // 
            this.lbl_DeparturesOutAdministrationCount.AutoSize = true;
            this.lbl_DeparturesOutAdministrationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesOutAdministrationCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesOutAdministrationCount.Location = new System.Drawing.Point(36, 31);
            this.lbl_DeparturesOutAdministrationCount.Name = "lbl_DeparturesOutAdministrationCount";
            this.lbl_DeparturesOutAdministrationCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesOutAdministrationCount.TabIndex = 0;
            this.lbl_DeparturesOutAdministrationCount.Text = "0";
            // 
            // lbl_DeparturesOutAdministrationTitle
            // 
            this.lbl_DeparturesOutAdministrationTitle.AutoSize = true;
            this.lbl_DeparturesOutAdministrationTitle.Location = new System.Drawing.Point(21, 4);
            this.lbl_DeparturesOutAdministrationTitle.Name = "lbl_DeparturesOutAdministrationTitle";
            this.lbl_DeparturesOutAdministrationTitle.Size = new System.Drawing.Size(61, 13);
            this.lbl_DeparturesOutAdministrationTitle.TabIndex = 0;
            this.lbl_DeparturesOutAdministrationTitle.Text = "خارج الإقليم";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_DeparturesInAdmistrationCount);
            this.panel5.Controls.Add(this.lbl_DeparturesInAdmistrationTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(414, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 64);
            this.panel5.TabIndex = 0;
            // 
            // lbl_DeparturesInAdmistrationCount
            // 
            this.lbl_DeparturesInAdmistrationCount.AutoSize = true;
            this.lbl_DeparturesInAdmistrationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesInAdmistrationCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesInAdmistrationCount.Location = new System.Drawing.Point(37, 31);
            this.lbl_DeparturesInAdmistrationCount.Name = "lbl_DeparturesInAdmistrationCount";
            this.lbl_DeparturesInAdmistrationCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesInAdmistrationCount.TabIndex = 0;
            this.lbl_DeparturesInAdmistrationCount.Text = "0";
            // 
            // lbl_DeparturesInAdmistrationTitle
            // 
            this.lbl_DeparturesInAdmistrationTitle.AutoSize = true;
            this.lbl_DeparturesInAdmistrationTitle.Location = new System.Drawing.Point(22, 4);
            this.lbl_DeparturesInAdmistrationTitle.Name = "lbl_DeparturesInAdmistrationTitle";
            this.lbl_DeparturesInAdmistrationTitle.Size = new System.Drawing.Size(59, 13);
            this.lbl_DeparturesInAdmistrationTitle.TabIndex = 0;
            this.lbl_DeparturesInAdmistrationTitle.Text = "داخل الإقليم";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_DeparturesInCommuneCount);
            this.panel4.Controls.Add(this.lbl_DeparturesInCommuneTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(516, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 64);
            this.panel4.TabIndex = 0;
            // 
            // lbl_DeparturesInCommuneCount
            // 
            this.lbl_DeparturesInCommuneCount.AutoSize = true;
            this.lbl_DeparturesInCommuneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesInCommuneCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesInCommuneCount.Location = new System.Drawing.Point(36, 31);
            this.lbl_DeparturesInCommuneCount.Name = "lbl_DeparturesInCommuneCount";
            this.lbl_DeparturesInCommuneCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesInCommuneCount.TabIndex = 0;
            this.lbl_DeparturesInCommuneCount.Text = "0";
            // 
            // lbl_DeparturesInCommuneTitle
            // 
            this.lbl_DeparturesInCommuneTitle.AutoSize = true;
            this.lbl_DeparturesInCommuneTitle.Location = new System.Drawing.Point(19, 4);
            this.lbl_DeparturesInCommuneTitle.Name = "lbl_DeparturesInCommuneTitle";
            this.lbl_DeparturesInCommuneTitle.Size = new System.Drawing.Size(66, 13);
            this.lbl_DeparturesInCommuneTitle.TabIndex = 0;
            this.lbl_DeparturesInCommuneTitle.Text = "داخل الجماعة";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_DeparturesMalesCount);
            this.panel3.Controls.Add(this.lbl_DeparturesMalesTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(618, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 64);
            this.panel3.TabIndex = 0;
            // 
            // lbl_DeparturesMalesCount
            // 
            this.lbl_DeparturesMalesCount.AutoSize = true;
            this.lbl_DeparturesMalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesMalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesMalesCount.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeparturesMalesCount.Name = "lbl_DeparturesMalesCount";
            this.lbl_DeparturesMalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesMalesCount.TabIndex = 0;
            this.lbl_DeparturesMalesCount.Text = "0";
            // 
            // lbl_DeparturesMalesTitle
            // 
            this.lbl_DeparturesMalesTitle.AutoSize = true;
            this.lbl_DeparturesMalesTitle.Location = new System.Drawing.Point(10, 4);
            this.lbl_DeparturesMalesTitle.Name = "lbl_DeparturesMalesTitle";
            this.lbl_DeparturesMalesTitle.Size = new System.Drawing.Size(83, 13);
            this.lbl_DeparturesMalesTitle.TabIndex = 0;
            this.lbl_DeparturesMalesTitle.Text = "المغادرون الذكور";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_DeparturesFemalesCount);
            this.panel2.Controls.Add(this.lbl_DeparturesFemalesTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 64);
            this.panel2.TabIndex = 0;
            // 
            // lbl_DeparturesFemalesCount
            // 
            this.lbl_DeparturesFemalesCount.AutoSize = true;
            this.lbl_DeparturesFemalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesFemalesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesFemalesCount.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeparturesFemalesCount.Name = "lbl_DeparturesFemalesCount";
            this.lbl_DeparturesFemalesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesFemalesCount.TabIndex = 0;
            this.lbl_DeparturesFemalesCount.Text = "0";
            // 
            // lbl_DeparturesFemalesTitle
            // 
            this.lbl_DeparturesFemalesTitle.AutoSize = true;
            this.lbl_DeparturesFemalesTitle.Location = new System.Drawing.Point(14, 4);
            this.lbl_DeparturesFemalesTitle.Name = "lbl_DeparturesFemalesTitle";
            this.lbl_DeparturesFemalesTitle.Size = new System.Drawing.Size(79, 13);
            this.lbl_DeparturesFemalesTitle.TabIndex = 0;
            this.lbl_DeparturesFemalesTitle.Text = "المغادرون الإناث";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_DeparturesCount);
            this.panel1.Controls.Add(this.lbl_DeparturesTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(822, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 64);
            this.panel1.TabIndex = 0;
            // 
            // lbl_DeparturesCount
            // 
            this.lbl_DeparturesCount.AutoSize = true;
            this.lbl_DeparturesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesCount.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeparturesCount.Name = "lbl_DeparturesCount";
            this.lbl_DeparturesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesCount.TabIndex = 0;
            this.lbl_DeparturesCount.Text = "0";
            // 
            // lbl_DeparturesTitle
            // 
            this.lbl_DeparturesTitle.AutoSize = true;
            this.lbl_DeparturesTitle.Location = new System.Drawing.Point(23, 4);
            this.lbl_DeparturesTitle.Name = "lbl_DeparturesTitle";
            this.lbl_DeparturesTitle.Size = new System.Drawing.Size(51, 13);
            this.lbl_DeparturesTitle.TabIndex = 0;
            this.lbl_DeparturesTitle.Text = "المغادرون";
            // 
            // Departures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Tools);
            this.Controls.Add(this.pnl_Statistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departures";
            this.Text = "Departures";
            this.Load += new System.EventHandler(this.Departures_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Tools.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Statistics.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_DeparturesSwitchingProgressCount;
        private System.Windows.Forms.Label lbl_DeparturesSwitchingProgressTitle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_DeparturesOutDirectionCount;
        private System.Windows.Forms.Label lbl_DeparturesOutDirectionTitle;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_DeparturesInDirectionCount;
        private System.Windows.Forms.Label lbl_DeparturesInDirectionTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_DeparturesOutAdministrationCount;
        private System.Windows.Forms.Label lbl_DeparturesOutAdministrationTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_DeparturesInAdmistrationCount;
        private System.Windows.Forms.Label lbl_DeparturesInAdmistrationTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_DeparturesInCommuneCount;
        private System.Windows.Forms.Label lbl_DeparturesInCommuneTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_DeparturesMalesCount;
        private System.Windows.Forms.Label lbl_DeparturesMalesTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_DeparturesFemalesCount;
        private System.Windows.Forms.Label lbl_DeparturesFemalesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DeparturesCount;
        private System.Windows.Forms.Label lbl_DeparturesTitle;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Sync;
    }
}