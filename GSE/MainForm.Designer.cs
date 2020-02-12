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
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.pnl_Sessions = new System.Windows.Forms.Panel();
            this.pnl_Absences = new System.Windows.Forms.Panel();
            this.pnl_Exames = new System.Windows.Forms.Panel();
            this.pnl_Employees = new System.Windows.Forms.Panel();
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.btn_ListEleve = new System.Windows.Forms.Button();
            this.btn_SortFolders = new System.Windows.Forms.Button();
            this.btn_SignIn_ResignIn = new System.Windows.Forms.Button();
            this.btn_AbsenceEleves = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Notifications = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.btn_Exames = new System.Windows.Forms.Button();
            this.btn_Sessions = new System.Windows.Forms.Button();
            this.btn_Absences = new System.Windows.Forms.Button();
            this.btn_Students = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_Header.SuspendLayout();
            this.p_Nav.SuspendLayout();
            this.p_SubNav.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            this.pnl_Absences.SuspendLayout();
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
            this.p_Header.Size = new System.Drawing.Size(1223, 66);
            this.p_Header.TabIndex = 0;
            // 
            // p_Nav
            // 
            this.p_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.p_Nav.Controls.Add(this.btn_Notifications);
            this.p_Nav.Controls.Add(this.btn_Settings);
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
            // cBox_Annee
            // 
            this.cBox_Annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Annee.FormattingEnabled = true;
            this.cBox_Annee.Location = new System.Drawing.Point(933, 14);
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.button6);
            this.pnl_Students.Controls.Add(this.button5);
            this.pnl_Students.Controls.Add(this.button4);
            this.pnl_Students.Controls.Add(this.button3);
            this.pnl_Students.Controls.Add(this.button2);
            this.pnl_Students.Controls.Add(this.button1);
            this.pnl_Students.Controls.Add(this.btn_SignIn_ResignIn);
            this.pnl_Students.Controls.Add(this.btn_SortFolders);
            this.pnl_Students.Controls.Add(this.btn_ListEleve);
            this.pnl_Students.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Students.Location = new System.Drawing.Point(0, 0);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(200, 426);
            this.pnl_Students.TabIndex = 0;
            // 
            // pnl_Sessions
            // 
            this.pnl_Sessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Sessions.Location = new System.Drawing.Point(0, 426);
            this.pnl_Sessions.Name = "pnl_Sessions";
            this.pnl_Sessions.Size = new System.Drawing.Size(200, 57);
            this.pnl_Sessions.TabIndex = 1;
            // 
            // pnl_Absences
            // 
            this.pnl_Absences.Controls.Add(this.btn_AbsenceEleves);
            this.pnl_Absences.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Absences.Location = new System.Drawing.Point(0, 483);
            this.pnl_Absences.Name = "pnl_Absences";
            this.pnl_Absences.Size = new System.Drawing.Size(200, 100);
            this.pnl_Absences.TabIndex = 3;
            // 
            // pnl_Exames
            // 
            this.pnl_Exames.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Exames.Location = new System.Drawing.Point(0, 583);
            this.pnl_Exames.Name = "pnl_Exames";
            this.pnl_Exames.Size = new System.Drawing.Size(200, 100);
            this.pnl_Exames.TabIndex = 4;
            // 
            // pnl_Employees
            // 
            this.pnl_Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Employees.Location = new System.Drawing.Point(0, 683);
            this.pnl_Employees.Name = "pnl_Employees";
            this.pnl_Employees.Size = new System.Drawing.Size(200, 100);
            this.pnl_Employees.TabIndex = 5;
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Settings.Location = new System.Drawing.Point(0, 783);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(200, 100);
            this.pnl_Settings.TabIndex = 6;
            // 
            // btn_ListEleve
            // 
            this.btn_ListEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListEleve.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListEleve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListEleve.Location = new System.Drawing.Point(0, 0);
            this.btn_ListEleve.Name = "btn_ListEleve";
            this.btn_ListEleve.Size = new System.Drawing.Size(200, 40);
            this.btn_ListEleve.TabIndex = 0;
            this.btn_ListEleve.Text = "List Eleves";
            this.btn_ListEleve.UseVisualStyleBackColor = true;
            this.btn_ListEleve.Click += new System.EventHandler(this.btn_ListEleve_Click);
            // 
            // btn_SortFolders
            // 
            this.btn_SortFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SortFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SortFolders.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortFolders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SortFolders.Location = new System.Drawing.Point(0, 46);
            this.btn_SortFolders.Name = "btn_SortFolders";
            this.btn_SortFolders.Size = new System.Drawing.Size(200, 40);
            this.btn_SortFolders.TabIndex = 0;
            this.btn_SortFolders.Text = "test 2";
            this.btn_SortFolders.UseVisualStyleBackColor = true;
            // 
            // btn_SignIn_ResignIn
            // 
            this.btn_SignIn_ResignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignIn_ResignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn_ResignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn_ResignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SignIn_ResignIn.Location = new System.Drawing.Point(0, 92);
            this.btn_SignIn_ResignIn.Name = "btn_SignIn_ResignIn";
            this.btn_SignIn_ResignIn.Size = new System.Drawing.Size(200, 40);
            this.btn_SignIn_ResignIn.TabIndex = 0;
            this.btn_SignIn_ResignIn.Text = "test 3";
            this.btn_SignIn_ResignIn.UseVisualStyleBackColor = true;
            // 
            // btn_AbsenceEleves
            // 
            this.btn_AbsenceEleves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AbsenceEleves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbsenceEleves.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbsenceEleves.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AbsenceEleves.Location = new System.Drawing.Point(0, 6);
            this.btn_AbsenceEleves.Name = "btn_AbsenceEleves";
            this.btn_AbsenceEleves.Size = new System.Drawing.Size(200, 40);
            this.btn_AbsenceEleves.TabIndex = 0;
            this.btn_AbsenceEleves.Text = "Absence Eleves";
            this.btn_AbsenceEleves.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "test 4";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "test 5";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "test 6";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "test 7";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "test 8";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(0, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "test 9";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_Notifications
            // 
            this.btn_Notifications.BackgroundImage = global::GSE.Properties.Resources.notification_80px;
            this.btn_Notifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Notifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Notifications.FlatAppearance.BorderSize = 0;
            this.btn_Notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notifications.Location = new System.Drawing.Point(8, 496);
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
            this.btn_Settings.Location = new System.Drawing.Point(8, 548);
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
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::GSE.Properties.Resources.shutdown_40px;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(1153, 14);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(50, 37);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(178, 268);
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
            this.label2.Location = new System.Drawing.Point(216, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 139);
            this.label2.TabIndex = 5;
            this.label2.Text = "El Jadida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(119)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1223, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
            this.p_Nav.ResumeLayout(false);
            this.p_SubNav.ResumeLayout(false);
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Absences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_AbsenceEleves;
        private System.Windows.Forms.Button btn_Notifications;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

