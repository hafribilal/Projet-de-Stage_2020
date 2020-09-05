namespace GSE.Forms.Absences
{
    partial class StudentsAbsences
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
            this.pnl_Tools = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_NotedHoursTitle = new System.Windows.Forms.Label();
            this.lbl_NotedHoursCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_NotNotedHoursCount = new System.Windows.Forms.Label();
            this.lbl_NotNotedHoursTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_TotalHoursCount = new System.Windows.Forms.Label();
            this.lbl_TotalHoursTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_NotedDyasTitle = new System.Windows.Forms.Label();
            this.lbl_NotedDaysCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_NotNotedDaysCount = new System.Windows.Forms.Label();
            this.lbl_NotNotedDaysTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TotalDaysCount = new System.Windows.Forms.Label();
            this.lbl_TotalDaysTitle = new System.Windows.Forms.Label();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.combo_Niveaus = new System.Windows.Forms.ComboBox();
            this.combo_Classe = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.pnl_Btns = new System.Windows.Forms.Panel();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnl_Add = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_Students = new System.Windows.Forms.ComboBox();
            this.dTP_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.dTP_DateFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Tools.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Statistics.SuspendLayout();
            this.pnl_Btns.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Tools.Controls.Add(this.panel4);
            this.pnl_Tools.Controls.Add(this.panel5);
            this.pnl_Tools.Controls.Add(this.panel6);
            this.pnl_Tools.Controls.Add(this.panel3);
            this.pnl_Tools.Controls.Add(this.panel2);
            this.pnl_Tools.Controls.Add(this.panel1);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(943, 63);
            this.pnl_Tools.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_NotedHoursTitle);
            this.panel4.Controls.Add(this.lbl_NotedHoursCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(249, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 63);
            this.panel4.TabIndex = 10;
            // 
            // lbl_NotedHoursTitle
            // 
            this.lbl_NotedHoursTitle.AutoSize = true;
            this.lbl_NotedHoursTitle.Location = new System.Drawing.Point(24, 9);
            this.lbl_NotedHoursTitle.Name = "lbl_NotedHoursTitle";
            this.lbl_NotedHoursTitle.Size = new System.Drawing.Size(67, 13);
            this.lbl_NotedHoursTitle.TabIndex = 0;
            this.lbl_NotedHoursTitle.Text = "ساعات مبررة";
            // 
            // lbl_NotedHoursCount
            // 
            this.lbl_NotedHoursCount.AutoSize = true;
            this.lbl_NotedHoursCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotedHoursCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotedHoursCount.Location = new System.Drawing.Point(40, 28);
            this.lbl_NotedHoursCount.Name = "lbl_NotedHoursCount";
            this.lbl_NotedHoursCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotedHoursCount.TabIndex = 0;
            this.lbl_NotedHoursCount.Text = "0";
            this.lbl_NotedHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_NotNotedHoursCount);
            this.panel5.Controls.Add(this.lbl_NotNotedHoursTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(365, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 63);
            this.panel5.TabIndex = 9;
            // 
            // lbl_NotNotedHoursCount
            // 
            this.lbl_NotNotedHoursCount.AutoSize = true;
            this.lbl_NotNotedHoursCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotNotedHoursCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotNotedHoursCount.Location = new System.Drawing.Point(46, 28);
            this.lbl_NotNotedHoursCount.Name = "lbl_NotNotedHoursCount";
            this.lbl_NotNotedHoursCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotNotedHoursCount.TabIndex = 0;
            this.lbl_NotNotedHoursCount.Text = "0";
            this.lbl_NotNotedHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotNotedHoursTitle
            // 
            this.lbl_NotNotedHoursTitle.AutoSize = true;
            this.lbl_NotNotedHoursTitle.Location = new System.Drawing.Point(15, 9);
            this.lbl_NotNotedHoursTitle.Name = "lbl_NotNotedHoursTitle";
            this.lbl_NotNotedHoursTitle.Size = new System.Drawing.Size(86, 13);
            this.lbl_NotNotedHoursTitle.TabIndex = 0;
            this.lbl_NotNotedHoursTitle.Text = "ساعات غير مبررة";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_TotalHoursCount);
            this.panel6.Controls.Add(this.lbl_TotalHoursTitle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(481, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(115, 63);
            this.panel6.TabIndex = 8;
            // 
            // lbl_TotalHoursCount
            // 
            this.lbl_TotalHoursCount.AutoSize = true;
            this.lbl_TotalHoursCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalHoursCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalHoursCount.Location = new System.Drawing.Point(44, 28);
            this.lbl_TotalHoursCount.Name = "lbl_TotalHoursCount";
            this.lbl_TotalHoursCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_TotalHoursCount.TabIndex = 0;
            this.lbl_TotalHoursCount.Text = "0";
            this.lbl_TotalHoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalHoursTitle
            // 
            this.lbl_TotalHoursTitle.AutoSize = true;
            this.lbl_TotalHoursTitle.Location = new System.Drawing.Point(20, 9);
            this.lbl_TotalHoursTitle.Name = "lbl_TotalHoursTitle";
            this.lbl_TotalHoursTitle.Size = new System.Drawing.Size(78, 13);
            this.lbl_TotalHoursTitle.TabIndex = 0;
            this.lbl_TotalHoursTitle.Text = "مجموع الساعات";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_NotedDyasTitle);
            this.panel3.Controls.Add(this.lbl_NotedDaysCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(596, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 63);
            this.panel3.TabIndex = 6;
            // 
            // lbl_NotedDyasTitle
            // 
            this.lbl_NotedDyasTitle.AutoSize = true;
            this.lbl_NotedDyasTitle.Location = new System.Drawing.Point(33, 9);
            this.lbl_NotedDyasTitle.Name = "lbl_NotedDyasTitle";
            this.lbl_NotedDyasTitle.Size = new System.Drawing.Size(53, 13);
            this.lbl_NotedDyasTitle.TabIndex = 0;
            this.lbl_NotedDyasTitle.Text = "أيام مبررة";
            // 
            // lbl_NotedDaysCount
            // 
            this.lbl_NotedDaysCount.AutoSize = true;
            this.lbl_NotedDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotedDaysCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotedDaysCount.Location = new System.Drawing.Point(45, 28);
            this.lbl_NotedDaysCount.Name = "lbl_NotedDaysCount";
            this.lbl_NotedDaysCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotedDaysCount.TabIndex = 0;
            this.lbl_NotedDaysCount.Text = "0";
            this.lbl_NotedDaysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_NotNotedDaysCount);
            this.panel2.Controls.Add(this.lbl_NotNotedDaysTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(712, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 63);
            this.panel2.TabIndex = 7;
            // 
            // lbl_NotNotedDaysCount
            // 
            this.lbl_NotNotedDaysCount.AutoSize = true;
            this.lbl_NotNotedDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotNotedDaysCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NotNotedDaysCount.Location = new System.Drawing.Point(44, 28);
            this.lbl_NotNotedDaysCount.Name = "lbl_NotNotedDaysCount";
            this.lbl_NotNotedDaysCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_NotNotedDaysCount.TabIndex = 0;
            this.lbl_NotNotedDaysCount.Text = "0";
            this.lbl_NotNotedDaysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NotNotedDaysTitle
            // 
            this.lbl_NotNotedDaysTitle.AutoSize = true;
            this.lbl_NotNotedDaysTitle.Location = new System.Drawing.Point(20, 9);
            this.lbl_NotNotedDaysTitle.Name = "lbl_NotNotedDaysTitle";
            this.lbl_NotNotedDaysTitle.Size = new System.Drawing.Size(72, 13);
            this.lbl_NotNotedDaysTitle.TabIndex = 0;
            this.lbl_NotNotedDaysTitle.Text = "أيام غير مبررة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_TotalDaysCount);
            this.panel1.Controls.Add(this.lbl_TotalDaysTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(828, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 63);
            this.panel1.TabIndex = 5;
            // 
            // lbl_TotalDaysCount
            // 
            this.lbl_TotalDaysCount.AutoSize = true;
            this.lbl_TotalDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalDaysCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalDaysCount.Location = new System.Drawing.Point(46, 28);
            this.lbl_TotalDaysCount.Name = "lbl_TotalDaysCount";
            this.lbl_TotalDaysCount.Size = new System.Drawing.Size(30, 31);
            this.lbl_TotalDaysCount.TabIndex = 0;
            this.lbl_TotalDaysCount.Text = "0";
            this.lbl_TotalDaysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalDaysTitle
            // 
            this.lbl_TotalDaysTitle.AutoSize = true;
            this.lbl_TotalDaysTitle.Location = new System.Drawing.Point(26, 9);
            this.lbl_TotalDaysTitle.Name = "lbl_TotalDaysTitle";
            this.lbl_TotalDaysTitle.Size = new System.Drawing.Size(62, 13);
            this.lbl_TotalDaysTitle.TabIndex = 0;
            this.lbl_TotalDaysTitle.Text = "مجموع الأيام";
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
            this.pnl_Statistics.Size = new System.Drawing.Size(943, 64);
            this.pnl_Statistics.TabIndex = 11;
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
            this.pnl_Btns.Location = new System.Drawing.Point(800, 0);
            this.pnl_Btns.Name = "pnl_Btns";
            this.pnl_Btns.Size = new System.Drawing.Size(143, 64);
            this.pnl_Btns.TabIndex = 14;
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackgroundImage = global::GSE.Properties.Resources.statistics_80px;
            this.btn_Statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Statistics.FlatAppearance.BorderSize = 0;
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Statistics.Location = new System.Drawing.Point(11, 14);
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
            this.btn_Print.Location = new System.Drawing.Point(75, 14);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(58, 45);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dgv);
            this.pnl_Container.Controls.Add(this.pnl_Add);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 127);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(943, 376);
            this.pnl_Container.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(0, 56);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(943, 320);
            this.dgv.TabIndex = 0;
            // 
            // pnl_Add
            // 
            this.pnl_Add.Controls.Add(this.label2);
            this.pnl_Add.Controls.Add(this.label1);
            this.pnl_Add.Controls.Add(this.dTP_DateFin);
            this.pnl_Add.Controls.Add(this.dTP_DateDebut);
            this.pnl_Add.Controls.Add(this.combo_Students);
            this.pnl_Add.Controls.Add(this.button1);
            this.pnl_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add.Name = "pnl_Add";
            this.pnl_Add.Size = new System.Drawing.Size(943, 56);
            this.pnl_Add.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GSE.Properties.Resources.plus_30px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 33);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_Students
            // 
            this.combo_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Students.FormattingEnabled = true;
            this.combo_Students.Location = new System.Drawing.Point(735, 16);
            this.combo_Students.Name = "combo_Students";
            this.combo_Students.Size = new System.Drawing.Size(196, 28);
            this.combo_Students.TabIndex = 7;
            // 
            // dTP_DateDebut
            // 
            this.dTP_DateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_DateDebut.Location = new System.Drawing.Point(417, 16);
            this.dTP_DateDebut.Name = "dTP_DateDebut";
            this.dTP_DateDebut.Size = new System.Drawing.Size(241, 29);
            this.dTP_DateDebut.TabIndex = 8;
            // 
            // dTP_DateFin
            // 
            this.dTP_DateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_DateFin.Location = new System.Drawing.Point(102, 16);
            this.dTP_DateFin.Name = "dTP_DateFin";
            this.dTP_DateFin.Size = new System.Drawing.Size(246, 29);
            this.dTP_DateFin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "إلى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "من";
            // 
            // StudentsAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 503);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Statistics);
            this.Controls.Add(this.pnl_Tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsAbsences";
            this.Text = "StudentsAbsences";
            this.Load += new System.EventHandler(this.StudentsAbsences_Load);
            this.pnl_Tools.ResumeLayout(false);
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
            this.pnl_Statistics.ResumeLayout(false);
            this.pnl_Btns.ResumeLayout(false);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Add.ResumeLayout(false);
            this.pnl_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Tools;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_NotedHoursTitle;
        private System.Windows.Forms.Label lbl_NotedHoursCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_NotNotedHoursCount;
        private System.Windows.Forms.Label lbl_NotNotedHoursTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_TotalHoursCount;
        private System.Windows.Forms.Label lbl_TotalHoursTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_NotedDyasTitle;
        private System.Windows.Forms.Label lbl_NotedDaysCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_NotNotedDaysCount;
        private System.Windows.Forms.Label lbl_NotNotedDaysTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TotalDaysCount;
        private System.Windows.Forms.Label lbl_TotalDaysTitle;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.ComboBox combo_Niveaus;
        private System.Windows.Forms.ComboBox combo_Classe;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Panel pnl_Btns;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP_DateFin;
        private System.Windows.Forms.DateTimePicker dTP_DateDebut;
        private System.Windows.Forms.ComboBox combo_Students;
        private System.Windows.Forms.Button button1;
    }
}