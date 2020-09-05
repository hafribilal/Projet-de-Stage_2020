namespace GSE.Forms.Students
{
    partial class StudentsMovement
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
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classe = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_DeletedsTitle = new System.Windows.Forms.Label();
            this.lbl_DeletedsCount = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_AddedsTitle = new System.Windows.Forms.Label();
            this.lbl_AddedsCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_StopersTitle = new System.Windows.Forms.Label();
            this.lbl_StopersCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_DeparturesCount = new System.Windows.Forms.Label();
            this.lbl_DeparturesTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_IntegratedCount = new System.Windows.Forms.Label();
            this.lbl_IntegratedTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_BrancheSwitchersTitle = new System.Windows.Forms.Label();
            this.lbl_BrancheSwitchersCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ClasseSwitchersCount = new System.Windows.Forms.Label();
            this.lbl_ClasseSwitchersTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ArrivalsCount = new System.Windows.Forms.Label();
            this.lbl_SignedInTitle = new System.Windows.Forms.Label();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Statistics.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Tools.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(924, 461);
            this.dgv.TabIndex = 0;
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.Controls.Add(this.combo_Niveaus);
            this.pnl_Statistics.Controls.Add(this.combo_Classe);
            this.pnl_Statistics.Controls.Add(this.btn_Save);
            this.pnl_Statistics.Controls.Add(this.btn_Sync);
            this.pnl_Statistics.Controls.Add(this.pnl_Btns);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(0, 63);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(924, 64);
            this.pnl_Statistics.TabIndex = 10;
            // 
            // combo_Niveaus
            // 
            this.combo_Niveaus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Niveaus.FormattingEnabled = true;
            this.combo_Niveaus.Location = new System.Drawing.Point(366, 14);
            this.combo_Niveaus.Name = "combo_Niveaus";
            this.combo_Niveaus.Size = new System.Drawing.Size(76, 38);
            this.combo_Niveaus.TabIndex = 17;
            this.combo_Niveaus.SelectedIndexChanged += new System.EventHandler(this.combo_Niveaus_SelectedIndexChanged);
            // 
            // combo_Classe
            // 
            this.combo_Classe.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Classe.FormattingEnabled = true;
            this.combo_Classe.Location = new System.Drawing.Point(147, 14);
            this.combo_Classe.Name = "combo_Classe";
            this.combo_Classe.Size = new System.Drawing.Size(213, 38);
            this.combo_Classe.TabIndex = 18;
            this.combo_Classe.SelectedIndexChanged += new System.EventHandler(this.combo_Classe_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::GSE.Properties.Resources.save_30px;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(69, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(54, 44);
            this.btn_Save.TabIndex = 15;
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
            this.btn_Sync.Location = new System.Drawing.Point(9, 13);
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
            this.pnl_Btns.Size = new System.Drawing.Size(152, 64);
            this.pnl_Btns.TabIndex = 14;
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
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Tools.Controls.Add(this.panel8);
            this.pnl_Tools.Controls.Add(this.panel7);
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
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_DeletedsTitle);
            this.panel8.Controls.Add(this.lbl_DeletedsCount);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(-2, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(116, 63);
            this.panel8.TabIndex = 12;
            // 
            // lbl_DeletedsTitle
            // 
            this.lbl_DeletedsTitle.AutoSize = true;
            this.lbl_DeletedsTitle.Location = new System.Drawing.Point(29, 9);
            this.lbl_DeletedsTitle.Name = "lbl_DeletedsTitle";
            this.lbl_DeletedsTitle.Size = new System.Drawing.Size(55, 13);
            this.lbl_DeletedsTitle.TabIndex = 0;
            this.lbl_DeletedsTitle.Text = "المحذوفون";
            // 
            // lbl_DeletedsCount
            // 
            this.lbl_DeletedsCount.AutoSize = true;
            this.lbl_DeletedsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeletedsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeletedsCount.Location = new System.Drawing.Point(40, 28);
            this.lbl_DeletedsCount.Name = "lbl_DeletedsCount";
            this.lbl_DeletedsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeletedsCount.TabIndex = 0;
            this.lbl_DeletedsCount.Text = "0";
            this.lbl_DeletedsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_AddedsTitle);
            this.panel7.Controls.Add(this.lbl_AddedsCount);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(114, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(116, 63);
            this.panel7.TabIndex = 11;
            // 
            // lbl_AddedsTitle
            // 
            this.lbl_AddedsTitle.AutoSize = true;
            this.lbl_AddedsTitle.Location = new System.Drawing.Point(30, 9);
            this.lbl_AddedsTitle.Name = "lbl_AddedsTitle";
            this.lbl_AddedsTitle.Size = new System.Drawing.Size(50, 13);
            this.lbl_AddedsTitle.TabIndex = 0;
            this.lbl_AddedsTitle.Text = "المضافون";
            // 
            // lbl_AddedsCount
            // 
            this.lbl_AddedsCount.AutoSize = true;
            this.lbl_AddedsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddedsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AddedsCount.Location = new System.Drawing.Point(40, 28);
            this.lbl_AddedsCount.Name = "lbl_AddedsCount";
            this.lbl_AddedsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_AddedsCount.TabIndex = 0;
            this.lbl_AddedsCount.Text = "0";
            this.lbl_AddedsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_StopersTitle);
            this.panel4.Controls.Add(this.lbl_StopersCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(230, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 63);
            this.panel4.TabIndex = 10;
            // 
            // lbl_StopersTitle
            // 
            this.lbl_StopersTitle.AutoSize = true;
            this.lbl_StopersTitle.Location = new System.Drawing.Point(29, 9);
            this.lbl_StopersTitle.Name = "lbl_StopersTitle";
            this.lbl_StopersTitle.Size = new System.Drawing.Size(53, 13);
            this.lbl_StopersTitle.TabIndex = 0;
            this.lbl_StopersTitle.Text = "المنقطعون";
            // 
            // lbl_StopersCount
            // 
            this.lbl_StopersCount.AutoSize = true;
            this.lbl_StopersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StopersCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_StopersCount.Location = new System.Drawing.Point(40, 28);
            this.lbl_StopersCount.Name = "lbl_StopersCount";
            this.lbl_StopersCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_StopersCount.TabIndex = 0;
            this.lbl_StopersCount.Text = "0";
            this.lbl_StopersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_DeparturesCount);
            this.panel5.Controls.Add(this.lbl_DeparturesTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(346, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 63);
            this.panel5.TabIndex = 9;
            // 
            // lbl_DeparturesCount
            // 
            this.lbl_DeparturesCount.AutoSize = true;
            this.lbl_DeparturesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeparturesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeparturesCount.Location = new System.Drawing.Point(46, 28);
            this.lbl_DeparturesCount.Name = "lbl_DeparturesCount";
            this.lbl_DeparturesCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_DeparturesCount.TabIndex = 0;
            this.lbl_DeparturesCount.Text = "0";
            this.lbl_DeparturesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DeparturesTitle
            // 
            this.lbl_DeparturesTitle.AutoSize = true;
            this.lbl_DeparturesTitle.Location = new System.Drawing.Point(35, 9);
            this.lbl_DeparturesTitle.Name = "lbl_DeparturesTitle";
            this.lbl_DeparturesTitle.Size = new System.Drawing.Size(51, 13);
            this.lbl_DeparturesTitle.TabIndex = 0;
            this.lbl_DeparturesTitle.Text = "المغادرون";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_IntegratedCount);
            this.panel6.Controls.Add(this.lbl_IntegratedTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(462, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(115, 63);
            this.panel6.TabIndex = 8;
            // 
            // lbl_IntegratedCount
            // 
            this.lbl_IntegratedCount.AutoSize = true;
            this.lbl_IntegratedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IntegratedCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_IntegratedCount.Location = new System.Drawing.Point(44, 28);
            this.lbl_IntegratedCount.Name = "lbl_IntegratedCount";
            this.lbl_IntegratedCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_IntegratedCount.TabIndex = 0;
            this.lbl_IntegratedCount.Text = "0";
            this.lbl_IntegratedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IntegratedTitle
            // 
            this.lbl_IntegratedTitle.AutoSize = true;
            this.lbl_IntegratedTitle.Location = new System.Drawing.Point(35, 9);
            this.lbl_IntegratedTitle.Name = "lbl_IntegratedTitle";
            this.lbl_IntegratedTitle.Size = new System.Drawing.Size(48, 13);
            this.lbl_IntegratedTitle.TabIndex = 0;
            this.lbl_IntegratedTitle.Text = "المدمجون";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_BrancheSwitchersTitle);
            this.panel3.Controls.Add(this.lbl_BrancheSwitchersCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(577, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 63);
            this.panel3.TabIndex = 6;
            // 
            // lbl_BrancheSwitchersTitle
            // 
            this.lbl_BrancheSwitchersTitle.AutoSize = true;
            this.lbl_BrancheSwitchersTitle.Location = new System.Drawing.Point(26, 9);
            this.lbl_BrancheSwitchersTitle.Name = "lbl_BrancheSwitchersTitle";
            this.lbl_BrancheSwitchersTitle.Size = new System.Drawing.Size(68, 13);
            this.lbl_BrancheSwitchersTitle.TabIndex = 0;
            this.lbl_BrancheSwitchersTitle.Text = "مغيرو التوجيه";
            // 
            // lbl_BrancheSwitchersCount
            // 
            this.lbl_BrancheSwitchersCount.AutoSize = true;
            this.lbl_BrancheSwitchersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BrancheSwitchersCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BrancheSwitchersCount.Location = new System.Drawing.Point(45, 28);
            this.lbl_BrancheSwitchersCount.Name = "lbl_BrancheSwitchersCount";
            this.lbl_BrancheSwitchersCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_BrancheSwitchersCount.TabIndex = 0;
            this.lbl_BrancheSwitchersCount.Text = "0";
            this.lbl_BrancheSwitchersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ClasseSwitchersCount);
            this.panel2.Controls.Add(this.lbl_ClasseSwitchersTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(693, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 63);
            this.panel2.TabIndex = 7;
            // 
            // lbl_ClasseSwitchersCount
            // 
            this.lbl_ClasseSwitchersCount.AutoSize = true;
            this.lbl_ClasseSwitchersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClasseSwitchersCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ClasseSwitchersCount.Location = new System.Drawing.Point(44, 28);
            this.lbl_ClasseSwitchersCount.Name = "lbl_ClasseSwitchersCount";
            this.lbl_ClasseSwitchersCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ClasseSwitchersCount.TabIndex = 0;
            this.lbl_ClasseSwitchersCount.Text = "0";
            this.lbl_ClasseSwitchersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ClasseSwitchersTitle
            // 
            this.lbl_ClasseSwitchersTitle.AutoSize = true;
            this.lbl_ClasseSwitchersTitle.Location = new System.Drawing.Point(28, 9);
            this.lbl_ClasseSwitchersTitle.Name = "lbl_ClasseSwitchersTitle";
            this.lbl_ClasseSwitchersTitle.Size = new System.Drawing.Size(61, 13);
            this.lbl_ClasseSwitchersTitle.TabIndex = 0;
            this.lbl_ClasseSwitchersTitle.Text = "مغيرو القسم";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_ArrivalsCount);
            this.panel1.Controls.Add(this.lbl_SignedInTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(809, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 63);
            this.panel1.TabIndex = 5;
            // 
            // lbl_ArrivalsCount
            // 
            this.lbl_ArrivalsCount.AutoSize = true;
            this.lbl_ArrivalsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArrivalsCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ArrivalsCount.Location = new System.Drawing.Point(46, 28);
            this.lbl_ArrivalsCount.Name = "lbl_ArrivalsCount";
            this.lbl_ArrivalsCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_ArrivalsCount.TabIndex = 0;
            this.lbl_ArrivalsCount.Text = "0";
            this.lbl_ArrivalsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SignedInTitle
            // 
            this.lbl_SignedInTitle.AutoSize = true;
            this.lbl_SignedInTitle.Location = new System.Drawing.Point(36, 9);
            this.lbl_SignedInTitle.Name = "lbl_SignedInTitle";
            this.lbl_SignedInTitle.Size = new System.Drawing.Size(46, 13);
            this.lbl_SignedInTitle.TabIndex = 0;
            this.lbl_SignedInTitle.Text = "الوافدون";
            // 
            // StudentsMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Statistics);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsMovement";
            this.Text = "StudentsMovement";
            this.Load += new System.EventHandler(this.StudentsMovement_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Statistics.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Tools.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_DeletedsTitle;
        private System.Windows.Forms.Label lbl_DeletedsCount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_AddedsTitle;
        private System.Windows.Forms.Label lbl_AddedsCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_StopersTitle;
        private System.Windows.Forms.Label lbl_StopersCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_DeparturesCount;
        private System.Windows.Forms.Label lbl_DeparturesTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_IntegratedCount;
        private System.Windows.Forms.Label lbl_IntegratedTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_BrancheSwitchersTitle;
        private System.Windows.Forms.Label lbl_BrancheSwitchersCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ClasseSwitchersCount;
        private System.Windows.Forms.Label lbl_ClasseSwitchersTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ArrivalsCount;
        private System.Windows.Forms.Label lbl_SignedInTitle;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sync;
    }
}