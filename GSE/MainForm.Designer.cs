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
            this.pnl_HeaderRight = new System.Windows.Forms.Panel();
            this.combo_Annee = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.p_Nav = new System.Windows.Forms.Panel();
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.btn_Exames = new System.Windows.Forms.Button();
            this.btn_Sessions = new System.Windows.Forms.Button();
            this.btn_Absences = new System.Windows.Forms.Button();
            this.btn_Students = new System.Windows.Forms.Button();
            this.p_SubNav = new System.Windows.Forms.Panel();
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.pnl_Employees = new System.Windows.Forms.Panel();
            this.btn_EmployeesList = new System.Windows.Forms.Button();
            this.pnl_Exames = new System.Windows.Forms.Panel();
            this.btn_CouncilResolution = new System.Windows.Forms.Button();
            this.btn_ExamsNotes = new System.Windows.Forms.Button();
            this.btn_ControlsNotes = new System.Windows.Forms.Button();
            this.btn_ExamsGarding = new System.Windows.Forms.Button();
            this.btn_ExamsManagement = new System.Windows.Forms.Button();
            this.btn_TrackExamSheets = new System.Windows.Forms.Button();
            this.btn_Marksheets = new System.Windows.Forms.Button();
            this.pnl_Absences = new System.Windows.Forms.Panel();
            this.btn_ConsultingAbsentees = new System.Windows.Forms.Button();
            this.btn_AbsenceSheet = new System.Windows.Forms.Button();
            this.btn_StudentsAbsences = new System.Windows.Forms.Button();
            this.pnl_Sessions = new System.Windows.Forms.Panel();
            this.btn_ClassroomSchedules = new System.Windows.Forms.Button();
            this.btn_ClassroomSistribution = new System.Windows.Forms.Button();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.btn_Passwords = new System.Windows.Forms.Button();
            this.btn_SchoolFiles = new System.Windows.Forms.Button();
            this.btn_Departures = new System.Windows.Forms.Button();
            this.btn_Arrivals = new System.Windows.Forms.Button();
            this.btn_StudentsMovement = new System.Windows.Forms.Button();
            this.btn_SignIn_ResignIn = new System.Windows.Forms.Button();
            this.btn_SortFolders = new System.Windows.Forms.Button();
            this.btn_ListEleve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBox_SchoolName = new System.Windows.Forms.GroupBox();
            this.pnl_Nav_Bottom = new System.Windows.Forms.Panel();
            this.p_Header.SuspendLayout();
            this.pnl_HeaderRight.SuspendLayout();
            this.p_Nav.SuspendLayout();
            this.p_SubNav.SuspendLayout();
            this.pnl_Employees.SuspendLayout();
            this.pnl_Exames.SuspendLayout();
            this.pnl_Absences.SuspendLayout();
            this.pnl_Sessions.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            this.gBox_SchoolName.SuspendLayout();
            this.pnl_Nav_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Header
            // 
            this.p_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.p_Header.Controls.Add(this.pnl_HeaderRight);
            this.p_Header.Controls.Add(this.btn_Search);
            this.p_Header.Controls.Add(this.tBox_Search);
            this.p_Header.Controls.Add(this.lbl_Logo);
            this.p_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Header.Location = new System.Drawing.Point(0, 0);
            this.p_Header.Name = "p_Header";
            this.p_Header.Size = new System.Drawing.Size(1223, 66);
            this.p_Header.TabIndex = 0;
            this.p_Header.DoubleClick += new System.EventHandler(this.p_Header_DoubleClick);
            this.p_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Header_MouseDown);
            this.p_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_Header_MouseMove);
            this.p_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_Header_MouseUp);
            // 
            // pnl_HeaderRight
            // 
            this.pnl_HeaderRight.Controls.Add(this.combo_Annee);
            this.pnl_HeaderRight.Controls.Add(this.btn_Close);
            this.pnl_HeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_HeaderRight.Location = new System.Drawing.Point(933, 0);
            this.pnl_HeaderRight.Name = "pnl_HeaderRight";
            this.pnl_HeaderRight.Size = new System.Drawing.Size(290, 66);
            this.pnl_HeaderRight.TabIndex = 5;
            // 
            // combo_Annee
            // 
            this.combo_Annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Annee.FormattingEnabled = true;
            this.combo_Annee.Location = new System.Drawing.Point(-1, 14);
            this.combo_Annee.Name = "combo_Annee";
            this.combo_Annee.Size = new System.Drawing.Size(200, 37);
            this.combo_Annee.TabIndex = 0;
            this.combo_Annee.SelectedIndexChanged += new System.EventHandler(this.combo_Annee_SelectedIndexChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::GSE.Properties.Resources.shutdown_40px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(221, 14);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 37);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            // p_Nav
            // 
            this.p_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.p_Nav.Controls.Add(this.pnl_Nav_Bottom);
            this.p_Nav.Controls.Add(this.btn_Employees);
            this.p_Nav.Controls.Add(this.btn_Exames);
            this.p_Nav.Controls.Add(this.btn_Sessions);
            this.p_Nav.Controls.Add(this.btn_Absences);
            this.p_Nav.Controls.Add(this.btn_Students);
            this.p_Nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_Nav.Location = new System.Drawing.Point(1133, 66);
            this.p_Nav.Name = "p_Nav";
            this.p_Nav.Size = new System.Drawing.Size(90, 597);
            this.p_Nav.TabIndex = 1;
            // 
            // btn_Notifications
            // 
            this.btn_Notifications.BackgroundImage = global::GSE.Properties.Resources.notification_80px;
            this.btn_Notifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Notifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Notifications.FlatAppearance.BorderSize = 0;
            this.btn_Notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notifications.Location = new System.Drawing.Point(8, 22);
            this.btn_Notifications.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Notifications.Name = "btn_Notifications";
            this.btn_Notifications.Size = new System.Drawing.Size(74, 34);
            this.btn_Notifications.TabIndex = 0;
            this.btn_Notifications.UseVisualStyleBackColor = true;
            this.btn_Notifications.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackgroundImage = global::GSE.Properties.Resources.settings_80px;
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Location = new System.Drawing.Point(8, 74);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(74, 34);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Employees
            // 
            this.btn_Employees.BackgroundImage = global::GSE.Properties.Resources.name_tag_80px;
            this.btn_Employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Employees.FlatAppearance.BorderSize = 0;
            this.btn_Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employees.Location = new System.Drawing.Point(8, 329);
            this.btn_Employees.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(74, 51);
            this.btn_Employees.TabIndex = 0;
            this.btn_Employees.UseVisualStyleBackColor = true;
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // btn_Exames
            // 
            this.btn_Exames.BackgroundImage = global::GSE.Properties.Resources.exam_80px;
            this.btn_Exames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exames.FlatAppearance.BorderSize = 0;
            this.btn_Exames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exames.Location = new System.Drawing.Point(8, 251);
            this.btn_Exames.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exames.Name = "btn_Exames";
            this.btn_Exames.Size = new System.Drawing.Size(74, 51);
            this.btn_Exames.TabIndex = 0;
            this.btn_Exames.UseVisualStyleBackColor = true;
            this.btn_Exames.Click += new System.EventHandler(this.btn_Exames_Click);
            // 
            // btn_Sessions
            // 
            this.btn_Sessions.BackgroundImage = global::GSE.Properties.Resources.school_sessions_80px;
            this.btn_Sessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sessions.FlatAppearance.BorderSize = 0;
            this.btn_Sessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sessions.Location = new System.Drawing.Point(8, 89);
            this.btn_Sessions.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sessions.Name = "btn_Sessions";
            this.btn_Sessions.Size = new System.Drawing.Size(74, 51);
            this.btn_Sessions.TabIndex = 0;
            this.btn_Sessions.UseVisualStyleBackColor = true;
            this.btn_Sessions.Click += new System.EventHandler(this.btn_Sessions_Click);
            // 
            // btn_Absences
            // 
            this.btn_Absences.BackgroundImage = global::GSE.Properties.Resources.id_not_verified_80px;
            this.btn_Absences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Absences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Absences.FlatAppearance.BorderSize = 0;
            this.btn_Absences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Absences.Location = new System.Drawing.Point(8, 173);
            this.btn_Absences.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Absences.Name = "btn_Absences";
            this.btn_Absences.Size = new System.Drawing.Size(74, 51);
            this.btn_Absences.TabIndex = 0;
            this.btn_Absences.UseVisualStyleBackColor = true;
            this.btn_Absences.Click += new System.EventHandler(this.btn_Absences_Click);
            // 
            // btn_Students
            // 
            this.btn_Students.BackgroundImage = global::GSE.Properties.Resources.student_male_80px;
            this.btn_Students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Students.FlatAppearance.BorderSize = 0;
            this.btn_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Students.Location = new System.Drawing.Point(8, 17);
            this.btn_Students.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(74, 51);
            this.btn_Students.TabIndex = 0;
            this.btn_Students.UseVisualStyleBackColor = true;
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // p_SubNav
            // 
            this.p_SubNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(98)))));
            this.p_SubNav.Controls.Add(this.pnl_Settings);
            this.p_SubNav.Controls.Add(this.pnl_Employees);
            this.p_SubNav.Controls.Add(this.pnl_Exames);
            this.p_SubNav.Controls.Add(this.pnl_Absences);
            this.p_SubNav.Controls.Add(this.pnl_Sessions);
            this.p_SubNav.Controls.Add(this.pnl_Students);
            this.p_SubNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_SubNav.Location = new System.Drawing.Point(933, 66);
            this.p_SubNav.Name = "p_SubNav";
            this.p_SubNav.Size = new System.Drawing.Size(200, 597);
            this.p_SubNav.TabIndex = 2;
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Settings.Location = new System.Drawing.Point(0, 1009);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(200, 100);
            this.pnl_Settings.TabIndex = 6;
            // 
            // pnl_Employees
            // 
            this.pnl_Employees.Controls.Add(this.btn_EmployeesList);
            this.pnl_Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Employees.Location = new System.Drawing.Point(0, 942);
            this.pnl_Employees.Name = "pnl_Employees";
            this.pnl_Employees.Size = new System.Drawing.Size(200, 67);
            this.pnl_Employees.TabIndex = 5;
            // 
            // btn_EmployeesList
            // 
            this.btn_EmployeesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EmployeesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmployeesList.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmployeesList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_EmployeesList.Location = new System.Drawing.Point(0, 6);
            this.btn_EmployeesList.Name = "btn_EmployeesList";
            this.btn_EmployeesList.Size = new System.Drawing.Size(200, 40);
            this.btn_EmployeesList.TabIndex = 1;
            this.btn_EmployeesList.Text = "لوائح الموظفين";
            this.btn_EmployeesList.UseVisualStyleBackColor = true;
            this.btn_EmployeesList.Click += new System.EventHandler(this.btn_EmployeesList_Click);
            // 
            // pnl_Exames
            // 
            this.pnl_Exames.Controls.Add(this.btn_CouncilResolution);
            this.pnl_Exames.Controls.Add(this.btn_ExamsNotes);
            this.pnl_Exames.Controls.Add(this.btn_ControlsNotes);
            this.pnl_Exames.Controls.Add(this.btn_ExamsGarding);
            this.pnl_Exames.Controls.Add(this.btn_ExamsManagement);
            this.pnl_Exames.Controls.Add(this.btn_TrackExamSheets);
            this.pnl_Exames.Controls.Add(this.btn_Marksheets);
            this.pnl_Exames.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Exames.Location = new System.Drawing.Point(0, 608);
            this.pnl_Exames.Name = "pnl_Exames";
            this.pnl_Exames.Size = new System.Drawing.Size(200, 334);
            this.pnl_Exames.TabIndex = 4;
            // 
            // btn_CouncilResolution
            // 
            this.btn_CouncilResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CouncilResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CouncilResolution.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CouncilResolution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CouncilResolution.Location = new System.Drawing.Point(0, 282);
            this.btn_CouncilResolution.Name = "btn_CouncilResolution";
            this.btn_CouncilResolution.Size = new System.Drawing.Size(200, 40);
            this.btn_CouncilResolution.TabIndex = 1;
            this.btn_CouncilResolution.Text = "قرار مجلس القسم";
            this.btn_CouncilResolution.UseVisualStyleBackColor = true;
            this.btn_CouncilResolution.Click += new System.EventHandler(this.btn_CouncilResolution_Click);
            // 
            // btn_ExamsNotes
            // 
            this.btn_ExamsNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExamsNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExamsNotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExamsNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ExamsNotes.Location = new System.Drawing.Point(0, 236);
            this.btn_ExamsNotes.Name = "btn_ExamsNotes";
            this.btn_ExamsNotes.Size = new System.Drawing.Size(200, 40);
            this.btn_ExamsNotes.TabIndex = 1;
            this.btn_ExamsNotes.Text = "نقط الإمتحان الموحد";
            this.btn_ExamsNotes.UseVisualStyleBackColor = true;
            this.btn_ExamsNotes.Click += new System.EventHandler(this.btn_ExamsNotes_Click);
            // 
            // btn_ControlsNotes
            // 
            this.btn_ControlsNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ControlsNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlsNotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlsNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ControlsNotes.Location = new System.Drawing.Point(0, 190);
            this.btn_ControlsNotes.Name = "btn_ControlsNotes";
            this.btn_ControlsNotes.Size = new System.Drawing.Size(200, 40);
            this.btn_ControlsNotes.TabIndex = 1;
            this.btn_ControlsNotes.Text = "نقط المراقبة المستمرة";
            this.btn_ControlsNotes.UseVisualStyleBackColor = true;
            this.btn_ControlsNotes.Click += new System.EventHandler(this.btn_ControlsNotes_Click);
            // 
            // btn_ExamsGarding
            // 
            this.btn_ExamsGarding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExamsGarding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExamsGarding.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExamsGarding.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ExamsGarding.Location = new System.Drawing.Point(0, 144);
            this.btn_ExamsGarding.Name = "btn_ExamsGarding";
            this.btn_ExamsGarding.Size = new System.Drawing.Size(200, 40);
            this.btn_ExamsGarding.TabIndex = 1;
            this.btn_ExamsGarding.Text = "تنظيم الحراسة";
            this.btn_ExamsGarding.UseVisualStyleBackColor = true;
            this.btn_ExamsGarding.Click += new System.EventHandler(this.btn_ExamsGarding_Click);
            // 
            // btn_ExamsManagement
            // 
            this.btn_ExamsManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExamsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExamsManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExamsManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ExamsManagement.Location = new System.Drawing.Point(0, 98);
            this.btn_ExamsManagement.Name = "btn_ExamsManagement";
            this.btn_ExamsManagement.Size = new System.Drawing.Size(200, 40);
            this.btn_ExamsManagement.TabIndex = 1;
            this.btn_ExamsManagement.Text = "تنظيم الإمتحانات";
            this.btn_ExamsManagement.UseVisualStyleBackColor = true;
            this.btn_ExamsManagement.Click += new System.EventHandler(this.btn_ExamsManagement_Click);
            // 
            // btn_TrackExamSheets
            // 
            this.btn_TrackExamSheets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TrackExamSheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrackExamSheets.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrackExamSheets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TrackExamSheets.Location = new System.Drawing.Point(0, 52);
            this.btn_TrackExamSheets.Name = "btn_TrackExamSheets";
            this.btn_TrackExamSheets.Size = new System.Drawing.Size(200, 40);
            this.btn_TrackExamSheets.TabIndex = 1;
            this.btn_TrackExamSheets.Text = "تتبع اوراق التحرير";
            this.btn_TrackExamSheets.UseVisualStyleBackColor = true;
            this.btn_TrackExamSheets.Click += new System.EventHandler(this.btn_TrackExamSheets_Click);
            // 
            // btn_Marksheets
            // 
            this.btn_Marksheets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Marksheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Marksheets.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Marksheets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Marksheets.Location = new System.Drawing.Point(0, 6);
            this.btn_Marksheets.Name = "btn_Marksheets";
            this.btn_Marksheets.Size = new System.Drawing.Size(200, 40);
            this.btn_Marksheets.TabIndex = 1;
            this.btn_Marksheets.Text = "اوراق التقيط الدورية";
            this.btn_Marksheets.UseVisualStyleBackColor = true;
            this.btn_Marksheets.Click += new System.EventHandler(this.btn_Marksheets_Click);
            // 
            // pnl_Absences
            // 
            this.pnl_Absences.Controls.Add(this.btn_ConsultingAbsentees);
            this.pnl_Absences.Controls.Add(this.btn_AbsenceSheet);
            this.pnl_Absences.Controls.Add(this.btn_StudentsAbsences);
            this.pnl_Absences.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Absences.Location = new System.Drawing.Point(0, 459);
            this.pnl_Absences.Name = "pnl_Absences";
            this.pnl_Absences.Size = new System.Drawing.Size(200, 149);
            this.pnl_Absences.TabIndex = 3;
            // 
            // btn_ConsultingAbsentees
            // 
            this.btn_ConsultingAbsentees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultingAbsentees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultingAbsentees.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultingAbsentees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConsultingAbsentees.Location = new System.Drawing.Point(0, 97);
            this.btn_ConsultingAbsentees.Name = "btn_ConsultingAbsentees";
            this.btn_ConsultingAbsentees.Size = new System.Drawing.Size(200, 40);
            this.btn_ConsultingAbsentees.TabIndex = 0;
            this.btn_ConsultingAbsentees.Text = "مراسلة المتغيبين";
            this.btn_ConsultingAbsentees.UseVisualStyleBackColor = true;
            this.btn_ConsultingAbsentees.Click += new System.EventHandler(this.btn_ConsultingAbsentees_Click);
            // 
            // btn_AbsenceSheet
            // 
            this.btn_AbsenceSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AbsenceSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbsenceSheet.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbsenceSheet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AbsenceSheet.Location = new System.Drawing.Point(0, 51);
            this.btn_AbsenceSheet.Name = "btn_AbsenceSheet";
            this.btn_AbsenceSheet.Size = new System.Drawing.Size(200, 40);
            this.btn_AbsenceSheet.TabIndex = 0;
            this.btn_AbsenceSheet.Text = "ورقة الغياب";
            this.btn_AbsenceSheet.UseVisualStyleBackColor = true;
            this.btn_AbsenceSheet.Click += new System.EventHandler(this.btn_AbsenceSheet_Click);
            // 
            // btn_StudentsAbsences
            // 
            this.btn_StudentsAbsences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StudentsAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StudentsAbsences.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentsAbsences.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_StudentsAbsences.Location = new System.Drawing.Point(0, 6);
            this.btn_StudentsAbsences.Name = "btn_StudentsAbsences";
            this.btn_StudentsAbsences.Size = new System.Drawing.Size(200, 40);
            this.btn_StudentsAbsences.TabIndex = 0;
            this.btn_StudentsAbsences.Text = "غياب التلاميذ";
            this.btn_StudentsAbsences.UseVisualStyleBackColor = true;
            this.btn_StudentsAbsences.Click += new System.EventHandler(this.btn_StudentsAbsences_Click);
            // 
            // pnl_Sessions
            // 
            this.pnl_Sessions.Controls.Add(this.btn_ClassroomSchedules);
            this.pnl_Sessions.Controls.Add(this.btn_ClassroomSistribution);
            this.pnl_Sessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Sessions.Location = new System.Drawing.Point(0, 366);
            this.pnl_Sessions.Name = "pnl_Sessions";
            this.pnl_Sessions.Size = new System.Drawing.Size(200, 93);
            this.pnl_Sessions.TabIndex = 1;
            // 
            // btn_ClassroomSchedules
            // 
            this.btn_ClassroomSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassroomSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClassroomSchedules.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassroomSchedules.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ClassroomSchedules.Location = new System.Drawing.Point(0, 52);
            this.btn_ClassroomSchedules.Name = "btn_ClassroomSchedules";
            this.btn_ClassroomSchedules.Size = new System.Drawing.Size(200, 40);
            this.btn_ClassroomSchedules.TabIndex = 1;
            this.btn_ClassroomSchedules.Text = "جداول الحصص";
            this.btn_ClassroomSchedules.UseVisualStyleBackColor = true;
            this.btn_ClassroomSchedules.Click += new System.EventHandler(this.btn_ClassroomSchedules_Click);
            // 
            // btn_ClassroomSistribution
            // 
            this.btn_ClassroomSistribution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassroomSistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClassroomSistribution.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassroomSistribution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ClassroomSistribution.Location = new System.Drawing.Point(0, 6);
            this.btn_ClassroomSistribution.Name = "btn_ClassroomSistribution";
            this.btn_ClassroomSistribution.Size = new System.Drawing.Size(200, 40);
            this.btn_ClassroomSistribution.TabIndex = 1;
            this.btn_ClassroomSistribution.Text = "توزيع الأقسام";
            this.btn_ClassroomSistribution.UseVisualStyleBackColor = true;
            this.btn_ClassroomSistribution.Click += new System.EventHandler(this.btn_ClassroomSistribution_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.btn_Passwords);
            this.pnl_Students.Controls.Add(this.btn_SchoolFiles);
            this.pnl_Students.Controls.Add(this.btn_Departures);
            this.pnl_Students.Controls.Add(this.btn_Arrivals);
            this.pnl_Students.Controls.Add(this.btn_StudentsMovement);
            this.pnl_Students.Controls.Add(this.btn_SignIn_ResignIn);
            this.pnl_Students.Controls.Add(this.btn_SortFolders);
            this.pnl_Students.Controls.Add(this.btn_ListEleve);
            this.pnl_Students.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Students.Location = new System.Drawing.Point(0, 0);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(200, 366);
            this.pnl_Students.TabIndex = 0;
            // 
            // btn_Passwords
            // 
            this.btn_Passwords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Passwords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Passwords.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Passwords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Passwords.Location = new System.Drawing.Point(0, 326);
            this.btn_Passwords.Name = "btn_Passwords";
            this.btn_Passwords.Size = new System.Drawing.Size(200, 40);
            this.btn_Passwords.TabIndex = 0;
            this.btn_Passwords.Text = "القن السري";
            this.btn_Passwords.UseVisualStyleBackColor = true;
            this.btn_Passwords.Click += new System.EventHandler(this.btn_Passwords_Click);
            // 
            // btn_SchoolFiles
            // 
            this.btn_SchoolFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SchoolFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SchoolFiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SchoolFiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SchoolFiles.Location = new System.Drawing.Point(0, 281);
            this.btn_SchoolFiles.Name = "btn_SchoolFiles";
            this.btn_SchoolFiles.Size = new System.Drawing.Size(200, 40);
            this.btn_SchoolFiles.TabIndex = 0;
            this.btn_SchoolFiles.Text = "الملف المدرسي";
            this.btn_SchoolFiles.UseVisualStyleBackColor = true;
            this.btn_SchoolFiles.Click += new System.EventHandler(this.btn_SchoolFiles_Click);
            // 
            // btn_Departures
            // 
            this.btn_Departures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Departures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Departures.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Departures.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Departures.Location = new System.Drawing.Point(0, 235);
            this.btn_Departures.Name = "btn_Departures";
            this.btn_Departures.Size = new System.Drawing.Size(200, 40);
            this.btn_Departures.TabIndex = 0;
            this.btn_Departures.Text = "المغاذرون";
            this.btn_Departures.UseVisualStyleBackColor = true;
            this.btn_Departures.Click += new System.EventHandler(this.btn_Departures_Click);
            // 
            // btn_Arrivals
            // 
            this.btn_Arrivals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Arrivals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arrivals.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Arrivals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Arrivals.Location = new System.Drawing.Point(0, 189);
            this.btn_Arrivals.Name = "btn_Arrivals";
            this.btn_Arrivals.Size = new System.Drawing.Size(200, 40);
            this.btn_Arrivals.TabIndex = 0;
            this.btn_Arrivals.Text = "الوافذون";
            this.btn_Arrivals.UseVisualStyleBackColor = true;
            this.btn_Arrivals.Click += new System.EventHandler(this.btn_Arrivals_Click);
            // 
            // btn_StudentsMovement
            // 
            this.btn_StudentsMovement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StudentsMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StudentsMovement.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentsMovement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_StudentsMovement.Location = new System.Drawing.Point(0, 143);
            this.btn_StudentsMovement.Name = "btn_StudentsMovement";
            this.btn_StudentsMovement.Size = new System.Drawing.Size(200, 40);
            this.btn_StudentsMovement.TabIndex = 0;
            this.btn_StudentsMovement.Text = "حركية التلاميذ";
            this.btn_StudentsMovement.UseVisualStyleBackColor = true;
            this.btn_StudentsMovement.Click += new System.EventHandler(this.btn_StudentsMovement_Click);
            // 
            // btn_SignIn_ResignIn
            // 
            this.btn_SignIn_ResignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignIn_ResignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn_ResignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn_ResignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SignIn_ResignIn.Location = new System.Drawing.Point(0, 97);
            this.btn_SignIn_ResignIn.Name = "btn_SignIn_ResignIn";
            this.btn_SignIn_ResignIn.Size = new System.Drawing.Size(200, 40);
            this.btn_SignIn_ResignIn.TabIndex = 0;
            this.btn_SignIn_ResignIn.Text = "تسجيل التلاميذ";
            this.btn_SignIn_ResignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn_ResignIn.Click += new System.EventHandler(this.btn_SignIn_ResignIn_Click);
            // 
            // btn_SortFolders
            // 
            this.btn_SortFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SortFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SortFolders.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortFolders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SortFolders.Location = new System.Drawing.Point(0, 51);
            this.btn_SortFolders.Name = "btn_SortFolders";
            this.btn_SortFolders.Size = new System.Drawing.Size(200, 40);
            this.btn_SortFolders.TabIndex = 0;
            this.btn_SortFolders.Text = "ترتيب الملفات";
            this.btn_SortFolders.UseVisualStyleBackColor = true;
            this.btn_SortFolders.Click += new System.EventHandler(this.btn_SortFolders_Click);
            // 
            // btn_ListEleve
            // 
            this.btn_ListEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListEleve.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListEleve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListEleve.Location = new System.Drawing.Point(0, 6);
            this.btn_ListEleve.Name = "btn_ListEleve";
            this.btn_ListEleve.Size = new System.Drawing.Size(200, 40);
            this.btn_ListEleve.TabIndex = 0;
            this.btn_ListEleve.Text = "لوائح التلاميذ";
            this.btn_ListEleve.UseVisualStyleBackColor = true;
            this.btn_ListEleve.Click += new System.EventHandler(this.btn_ListEleve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "Groupe Scolaire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 139);
            this.label2.TabIndex = 5;
            this.label2.Text = "El Jadida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gBox_SchoolName
            // 
            this.gBox_SchoolName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gBox_SchoolName.Controls.Add(this.label1);
            this.gBox_SchoolName.Controls.Add(this.label2);
            this.gBox_SchoolName.Location = new System.Drawing.Point(157, 241);
            this.gBox_SchoolName.Name = "gBox_SchoolName";
            this.gBox_SchoolName.Size = new System.Drawing.Size(590, 265);
            this.gBox_SchoolName.TabIndex = 7;
            this.gBox_SchoolName.TabStop = false;
            // 
            // pnl_Nav_Bottom
            // 
            this.pnl_Nav_Bottom.Controls.Add(this.btn_Settings);
            this.pnl_Nav_Bottom.Controls.Add(this.btn_Notifications);
            this.pnl_Nav_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Nav_Bottom.Location = new System.Drawing.Point(0, 480);
            this.pnl_Nav_Bottom.Name = "pnl_Nav_Bottom";
            this.pnl_Nav_Bottom.Size = new System.Drawing.Size(90, 117);
            this.pnl_Nav_Bottom.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(119)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1223, 663);
            this.Controls.Add(this.gBox_SchoolName);
            this.Controls.Add(this.p_SubNav);
            this.Controls.Add(this.p_Nav);
            this.Controls.Add(this.p_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "GSE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.p_Header.ResumeLayout(false);
            this.p_Header.PerformLayout();
            this.pnl_HeaderRight.ResumeLayout(false);
            this.p_Nav.ResumeLayout(false);
            this.p_SubNav.ResumeLayout(false);
            this.pnl_Employees.ResumeLayout(false);
            this.pnl_Exames.ResumeLayout(false);
            this.pnl_Absences.ResumeLayout(false);
            this.pnl_Sessions.ResumeLayout(false);
            this.pnl_Students.ResumeLayout(false);
            this.gBox_SchoolName.ResumeLayout(false);
            this.gBox_SchoolName.PerformLayout();
            this.pnl_Nav_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Header;
        private System.Windows.Forms.Panel p_Nav;
        private System.Windows.Forms.Panel p_SubNav;
        private System.Windows.Forms.ComboBox combo_Annee;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Employees;
        private System.Windows.Forms.Button btn_Exames;
        private System.Windows.Forms.Button btn_Sessions;
        private System.Windows.Forms.Button btn_Absences;
        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pnl_Absences;
        private System.Windows.Forms.Panel pnl_Sessions;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Panel pnl_Settings;
        private System.Windows.Forms.Panel pnl_Employees;
        private System.Windows.Forms.Panel pnl_Exames;
        private System.Windows.Forms.Button btn_SignIn_ResignIn;
        private System.Windows.Forms.Button btn_SortFolders;
        private System.Windows.Forms.Button btn_ListEleve;
        private System.Windows.Forms.Button btn_StudentsAbsences;
        private System.Windows.Forms.Button btn_Notifications;
        private System.Windows.Forms.Button btn_Passwords;
        private System.Windows.Forms.Button btn_SchoolFiles;
        private System.Windows.Forms.Button btn_Departures;
        private System.Windows.Forms.Button btn_Arrivals;
        private System.Windows.Forms.Button btn_StudentsMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBox_SchoolName;
        private System.Windows.Forms.Button btn_ClassroomSchedules;
        private System.Windows.Forms.Button btn_ClassroomSistribution;
        private System.Windows.Forms.Button btn_EmployeesList;
        private System.Windows.Forms.Button btn_CouncilResolution;
        private System.Windows.Forms.Button btn_ExamsNotes;
        private System.Windows.Forms.Button btn_ControlsNotes;
        private System.Windows.Forms.Button btn_ExamsGarding;
        private System.Windows.Forms.Button btn_ExamsManagement;
        private System.Windows.Forms.Button btn_TrackExamSheets;
        private System.Windows.Forms.Button btn_Marksheets;
        private System.Windows.Forms.Button btn_ConsultingAbsentees;
        private System.Windows.Forms.Button btn_AbsenceSheet;
        private System.Windows.Forms.Panel pnl_HeaderRight;
        private System.Windows.Forms.Panel pnl_Nav_Bottom;
    }
}

