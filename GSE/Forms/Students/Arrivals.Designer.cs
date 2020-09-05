namespace GSE.Forms.Students
{
    partial class Arrivals
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
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classe = new System.Windows.Forms.ComboBox();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsOutDirectionCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsOutDirectionTitle = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsInDirectionCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsInDirectionTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsOutAdmnistrationCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsOutAdmnistrationTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsInAdmnistrationCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsInAdmnistrationTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsInCommuneCountCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsInCommuneTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsMalsCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsMalsTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsFemalsCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsFemalsTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsCount = new System.Windows.Forms.Label();
            this.lbl_ArrivalsTitle = new System.Windows.Forms.Label();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Tools.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Statistics.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 123);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(924, 465);
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
            this.dgv.Size = new System.Drawing.Size(924, 465);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Controls.Add(this.pnl_Btns);
            this.pnl_Tools.Controls.Add(this.combo_Niveaus);
            this.pnl_Tools.Controls.Add(this.combo_Classe);
            this.pnl_Tools.Controls.Add(this.btn_Sync);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 57);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(924, 66);
            this.pnl_Tools.TabIndex = 2;
            // 
            // pnl_Btns
            // 
            this.pnl_Btns.Controls.Add(this.btn_Statistics);
            this.pnl_Btns.Controls.Add(this.btn_Print);
            this.pnl_Btns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Btns.Location = new System.Drawing.Point(772, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(152, 66);
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
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(282, 18);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(76, 38);
            this.combo_Niveaus.TabIndex = 1;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged);
            // 
            // combo_Classe
            // 
            this.combo_Classe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classe.FormattingEnabled = true;
            this.combo_Classe.Location = new System.Drawing.Point(63, 18);
            this.combo_Classe.Name = "combo_Classe";
            this.combo_Classe.Size = new System.Drawing.Size(213, 38);
            this.combo_Classe.TabIndex = 1;
            this.combo_Classe.SelectedIndexChanged += new System.EventHandler(this.combo_Classe_SelectedIndexChanged);
            // 
            // btn_Sync
            // 
            this.btn_Sync.BackgroundImage = global::GSE.Properties.Resources.synchronize_80px;
            this.btn_Sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sync.FlatAppearance.BorderSize = 0;
            this.btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sync.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sync.Location = new System.Drawing.Point(3, 14);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(54, 44);
            this.btn_Sync.TabIndex = 0;
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Statistics.Controls.Add(this.panel8);
            this.pnl_Statistics.Controls.Add(this.panel7);
            this.pnl_Statistics.Controls.Add(this.panel6);
            this.pnl_Statistics.Controls.Add(this.panel5);
            this.pnl_Statistics.Controls.Add(this.panel4);
            this.pnl_Statistics.Controls.Add(this.panel3);
            this.pnl_Statistics.Controls.Add(this.panel2);
            this.pnl_Statistics.Controls.Add(this.flowLayoutPanel1);
            this.pnl_Statistics.Controls.Add(this.panel1);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 0);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 57);
            this.pnl_Statistics.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_ArrivalsOutDirectionCount);
            this.panel8.Controls.Add(this.lbl_ArrivalsOutDirectionTitle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(12, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(114, 57);
            this.panel8.TabIndex = 10;
            // 
            // lbl_ArrivalsOutDirectionCount
            // 
            this.lbl_ArrivalsOutDirectionCount.AutoSize = true;
            this.lbl_ArrivalsOutDirectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsOutDirectionCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsOutDirectionCount.Location = new System.Drawing.Point(39, 24);
            this.lbl_ArrivalsOutDirectionCount.Name = "lbl_ArrivalsOutDirectionCount";
            this.lbl_ArrivalsOutDirectionCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsOutDirectionCount.TabIndex = 1;
            this.lbl_ArrivalsOutDirectionCount.Text = "0";
            // 
            // lbl_ArrivalsOutDirectionTitle
            // 
            this.lbl_ArrivalsOutDirectionTitle.AutoSize = true;
            this.lbl_ArrivalsOutDirectionTitle.Location = new System.Drawing.Point(27, 4);
            this.lbl_ArrivalsOutDirectionTitle.Name = "lbl_ArrivalsOutDirectionTitle";
            this.lbl_ArrivalsOutDirectionTitle.Size = new System.Drawing.Size(58, 13);
            this.lbl_ArrivalsOutDirectionTitle.TabIndex = 0;
            this.lbl_ArrivalsOutDirectionTitle.Text = "خارج الجهة";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_ArrivalsInDirectionCount);
            this.panel7.Controls.Add(this.lbl_ArrivalsInDirectionTitle);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(126, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 57);
            this.panel7.TabIndex = 7;
            // 
            // lbl_ArrivalsInDirectionCount
            // 
            this.lbl_ArrivalsInDirectionCount.AutoSize = true;
            this.lbl_ArrivalsInDirectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsInDirectionCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsInDirectionCount.Location = new System.Drawing.Point(42, 24);
            this.lbl_ArrivalsInDirectionCount.Name = "lbl_ArrivalsInDirectionCount";
            this.lbl_ArrivalsInDirectionCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsInDirectionCount.TabIndex = 1;
            this.lbl_ArrivalsInDirectionCount.Text = "0";
            // 
            // lbl_ArrivalsInDirectionTitle
            // 
            this.lbl_ArrivalsInDirectionTitle.AutoSize = true;
            this.lbl_ArrivalsInDirectionTitle.Location = new System.Drawing.Point(29, 4);
            this.lbl_ArrivalsInDirectionTitle.Name = "lbl_ArrivalsInDirectionTitle";
            this.lbl_ArrivalsInDirectionTitle.Size = new System.Drawing.Size(56, 13);
            this.lbl_ArrivalsInDirectionTitle.TabIndex = 0;
            this.lbl_ArrivalsInDirectionTitle.Text = "داخل الجهة";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_ArrivalsOutAdmnistrationCount);
            this.panel6.Controls.Add(this.lbl_ArrivalsOutAdmnistrationTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(240, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 57);
            this.panel6.TabIndex = 6;
            // 
            // lbl_ArrivalsOutAdmnistrationCount
            // 
            this.lbl_ArrivalsOutAdmnistrationCount.AutoSize = true;
            this.lbl_ArrivalsOutAdmnistrationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsOutAdmnistrationCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsOutAdmnistrationCount.Location = new System.Drawing.Point(42, 24);
            this.lbl_ArrivalsOutAdmnistrationCount.Name = "lbl_ArrivalsOutAdmnistrationCount";
            this.lbl_ArrivalsOutAdmnistrationCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsOutAdmnistrationCount.TabIndex = 1;
            this.lbl_ArrivalsOutAdmnistrationCount.Text = "0";
            // 
            // lbl_ArrivalsOutAdmnistrationTitle
            // 
            this.lbl_ArrivalsOutAdmnistrationTitle.AutoSize = true;
            this.lbl_ArrivalsOutAdmnistrationTitle.Location = new System.Drawing.Point(28, 4);
            this.lbl_ArrivalsOutAdmnistrationTitle.Name = "lbl_ArrivalsOutAdmnistrationTitle";
            this.lbl_ArrivalsOutAdmnistrationTitle.Size = new System.Drawing.Size(61, 13);
            this.lbl_ArrivalsOutAdmnistrationTitle.TabIndex = 0;
            this.lbl_ArrivalsOutAdmnistrationTitle.Text = "خارج الإقليم";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_ArrivalsInAdmnistrationCount);
            this.panel5.Controls.Add(this.lbl_ArrivalsInAdmnistrationTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(354, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 57);
            this.panel5.TabIndex = 5;
            // 
            // lbl_ArrivalsInAdmnistrationCount
            // 
            this.lbl_ArrivalsInAdmnistrationCount.AutoSize = true;
            this.lbl_ArrivalsInAdmnistrationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsInAdmnistrationCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsInAdmnistrationCount.Location = new System.Drawing.Point(44, 24);
            this.lbl_ArrivalsInAdmnistrationCount.Name = "lbl_ArrivalsInAdmnistrationCount";
            this.lbl_ArrivalsInAdmnistrationCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsInAdmnistrationCount.TabIndex = 1;
            this.lbl_ArrivalsInAdmnistrationCount.Text = "0";
            // 
            // lbl_ArrivalsInAdmnistrationTitle
            // 
            this.lbl_ArrivalsInAdmnistrationTitle.AutoSize = true;
            this.lbl_ArrivalsInAdmnistrationTitle.Location = new System.Drawing.Point(30, 5);
            this.lbl_ArrivalsInAdmnistrationTitle.Name = "lbl_ArrivalsInAdmnistrationTitle";
            this.lbl_ArrivalsInAdmnistrationTitle.Size = new System.Drawing.Size(59, 13);
            this.lbl_ArrivalsInAdmnistrationTitle.TabIndex = 0;
            this.lbl_ArrivalsInAdmnistrationTitle.Text = "داخل الإقليم";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_ArrivalsInCommuneCountCount);
            this.panel4.Controls.Add(this.lbl_ArrivalsInCommuneTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(468, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 57);
            this.panel4.TabIndex = 4;
            // 
            // lbl_ArrivalsInCommuneCountCount
            // 
            this.lbl_ArrivalsInCommuneCountCount.AutoSize = true;
            this.lbl_ArrivalsInCommuneCountCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsInCommuneCountCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsInCommuneCountCount.Location = new System.Drawing.Point(42, 24);
            this.lbl_ArrivalsInCommuneCountCount.Name = "lbl_ArrivalsInCommuneCountCount";
            this.lbl_ArrivalsInCommuneCountCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsInCommuneCountCount.TabIndex = 2;
            this.lbl_ArrivalsInCommuneCountCount.Text = "0";
            // 
            // lbl_ArrivalsInCommuneTitle
            // 
            this.lbl_ArrivalsInCommuneTitle.AutoSize = true;
            this.lbl_ArrivalsInCommuneTitle.Location = new System.Drawing.Point(23, 5);
            this.lbl_ArrivalsInCommuneTitle.Name = "lbl_ArrivalsInCommuneTitle";
            this.lbl_ArrivalsInCommuneTitle.Size = new System.Drawing.Size(66, 13);
            this.lbl_ArrivalsInCommuneTitle.TabIndex = 0;
            this.lbl_ArrivalsInCommuneTitle.Text = "داخل الجماعة";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_ArrivalsMalsCount);
            this.panel3.Controls.Add(this.lbl_ArrivalsMalsTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(582, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 57);
            this.panel3.TabIndex = 3;
            // 
            // lbl_ArrivalsMalsCount
            // 
            this.lbl_ArrivalsMalsCount.AutoSize = true;
            this.lbl_ArrivalsMalsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsMalsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsMalsCount.Location = new System.Drawing.Point(43, 24);
            this.lbl_ArrivalsMalsCount.Name = "lbl_ArrivalsMalsCount";
            this.lbl_ArrivalsMalsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsMalsCount.TabIndex = 1;
            this.lbl_ArrivalsMalsCount.Text = "0";
            // 
            // lbl_ArrivalsMalsTitle
            // 
            this.lbl_ArrivalsMalsTitle.AutoSize = true;
            this.lbl_ArrivalsMalsTitle.Location = new System.Drawing.Point(19, 5);
            this.lbl_ArrivalsMalsTitle.Name = "lbl_ArrivalsMalsTitle";
            this.lbl_ArrivalsMalsTitle.Size = new System.Drawing.Size(78, 13);
            this.lbl_ArrivalsMalsTitle.TabIndex = 0;
            this.lbl_ArrivalsMalsTitle.Text = "الوافذون الذكور";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ArrivalsFemalsCount);
            this.panel2.Controls.Add(this.lbl_ArrivalsFemalsTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(696, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 57);
            this.panel2.TabIndex = 2;
            // 
            // lbl_ArrivalsFemalsCount
            // 
            this.lbl_ArrivalsFemalsCount.AutoSize = true;
            this.lbl_ArrivalsFemalsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsFemalsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsFemalsCount.Location = new System.Drawing.Point(42, 24);
            this.lbl_ArrivalsFemalsCount.Name = "lbl_ArrivalsFemalsCount";
            this.lbl_ArrivalsFemalsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsFemalsCount.TabIndex = 1;
            this.lbl_ArrivalsFemalsCount.Text = "0";
            // 
            // lbl_ArrivalsFemalsTitle
            // 
            this.lbl_ArrivalsFemalsTitle.AutoSize = true;
            this.lbl_ArrivalsFemalsTitle.Location = new System.Drawing.Point(19, 5);
            this.lbl_ArrivalsFemalsTitle.Name = "lbl_ArrivalsFemalsTitle";
            this.lbl_ArrivalsFemalsTitle.Size = new System.Drawing.Size(74, 13);
            this.lbl_ArrivalsFemalsTitle.TabIndex = 0;
            this.lbl_ArrivalsFemalsTitle.Text = "الوافذون الإناث";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(696, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 57);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_ArrivalsCount);
            this.panel1.Controls.Add(this.lbl_ArrivalsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(810, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 57);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ArrivalsCount
            // 
            this.lbl_ArrivalsCount.AutoSize = true;
            this.lbl_ArrivalsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsCount.Location = new System.Drawing.Point(40, 24);
            this.lbl_ArrivalsCount.Name = "lbl_ArrivalsCount";
            this.lbl_ArrivalsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsCount.TabIndex = 1;
            this.lbl_ArrivalsCount.Text = "0";
            // 
            // lbl_ArrivalsTitle
            // 
            this.lbl_ArrivalsTitle.AutoSize = true;
            this.lbl_ArrivalsTitle.Location = new System.Drawing.Point(30, 5);
            this.lbl_ArrivalsTitle.Name = "lbl_ArrivalsTitle";
            this.lbl_ArrivalsTitle.Size = new System.Drawing.Size(46, 13);
            this.lbl_ArrivalsTitle.TabIndex = 0;
            this.lbl_ArrivalsTitle.Text = "الوافذون";
            // 
            // Arrivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Tools);
            this.Controls.Add(this.pnl_Statistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arrivals";
            this.Text = "Arrivals";
            this.Load += new System.EventHandler(this.Arrivals_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Tools.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Statistics.ResumeLayout(false);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_ArrivalsOutDirectionTitle;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_ArrivalsInDirectionTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_ArrivalsOutAdmnistrationTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_ArrivalsInAdmnistrationTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_ArrivalsInCommuneTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_ArrivalsMalsTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ArrivalsFemalsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ArrivalsTitle;
        private System.Windows.Forms.Label lbl_ArrivalsOutDirectionCount;
        private System.Windows.Forms.Label lbl_ArrivalsInDirectionCount;
        private System.Windows.Forms.Label lbl_ArrivalsOutAdmnistrationCount;
        private System.Windows.Forms.Label lbl_ArrivalsInAdmnistrationCount;
        private System.Windows.Forms.Label lbl_ArrivalsInCommuneCountCount;
        private System.Windows.Forms.Label lbl_ArrivalsMalsCount;
        private System.Windows.Forms.Label lbl_ArrivalsFemalsCount;
        private System.Windows.Forms.Label lbl_ArrivalsCount;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Print;
    }
}