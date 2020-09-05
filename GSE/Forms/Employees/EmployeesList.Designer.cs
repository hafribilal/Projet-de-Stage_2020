namespace GSE.Forms.Employees
{
    partial class EmployeesList
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
            this.pnl_List = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnl_Tools = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_MalesCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_FemalesCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tBox_Address = new System.Windows.Forms.TextBox();
            this.tBox_Fix = new System.Windows.Forms.TextBox();
            this.tBox_Tele = new System.Windows.Forms.TextBox();
            this.combo_Specialite = new System.Windows.Forms.ComboBox();
            this.tBox_BirthLocationAr = new System.Windows.Forms.TextBox();
            this.tBox_BirthLocationFr = new System.Windows.Forms.TextBox();
            this.dTP_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.tBox_FirstNameFr = new System.Windows.Forms.TextBox();
            this.tBox_LastNameFr = new System.Windows.Forms.TextBox();
            this.tBox_Cin = new System.Windows.Forms.TextBox();
            this.tBox_FirstNameAr = new System.Windows.Forms.TextBox();
            this.tBox_LastNameAr = new System.Windows.Forms.TextBox();
            this.tBox_NumSomme = new System.Windows.Forms.TextBox();
            this.pBox_Photo = new System.Windows.Forms.PictureBox();
            this.pnl_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_Tools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.dgv);
            this.pnl_List.Controls.Add(this.pnl_Tools);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 0);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(291, 450);
            this.pnl_List.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 71);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(291, 379);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // pnl_Tools
            // 
            this.pnl_Tools.Controls.Add(this.panel2);
            this.pnl_Tools.Controls.Add(this.panel3);
            this.pnl_Tools.Controls.Add(this.panel4);
            this.pnl_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tools.Name = "pnl_Tools";
            this.pnl_Tools.Size = new System.Drawing.Size(291, 71);
            this.pnl_Tools.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_MalesCount);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 61);
            this.panel2.TabIndex = 0;
            // 
            // lbl_MalesCount
            // 
            this.lbl_MalesCount.AutoSize = true;
            this.lbl_MalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MalesCount.Location = new System.Drawing.Point(38, 33);
            this.lbl_MalesCount.Name = "lbl_MalesCount";
            this.lbl_MalesCount.Size = new System.Drawing.Size(25, 25);
            this.lbl_MalesCount.TabIndex = 1;
            this.lbl_MalesCount.Text = "0";
            this.lbl_MalesCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "الموظفين الذكور";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_FemalesCount);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(105, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 61);
            this.panel3.TabIndex = 1;
            // 
            // lbl_FemalesCount
            // 
            this.lbl_FemalesCount.AutoSize = true;
            this.lbl_FemalesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FemalesCount.Location = new System.Drawing.Point(31, 33);
            this.lbl_FemalesCount.Name = "lbl_FemalesCount";
            this.lbl_FemalesCount.Size = new System.Drawing.Size(25, 25);
            this.lbl_FemalesCount.TabIndex = 1;
            this.lbl_FemalesCount.Text = "0";
            this.lbl_FemalesCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "الموظفين الإناث";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_TotalCount);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(197, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 61);
            this.panel4.TabIndex = 2;
            // 
            // lbl_TotalCount
            // 
            this.lbl_TotalCount.AutoSize = true;
            this.lbl_TotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCount.Location = new System.Drawing.Point(27, 33);
            this.lbl_TotalCount.Name = "lbl_TotalCount";
            this.lbl_TotalCount.Size = new System.Drawing.Size(25, 25);
            this.lbl_TotalCount.TabIndex = 1;
            this.lbl_TotalCount.Text = "0";
            this.lbl_TotalCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "مجموع الموظفين";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 450);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Import);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.tBox_Address);
            this.groupBox1.Controls.Add(this.tBox_Fix);
            this.groupBox1.Controls.Add(this.tBox_Tele);
            this.groupBox1.Controls.Add(this.combo_Specialite);
            this.groupBox1.Controls.Add(this.tBox_BirthLocationAr);
            this.groupBox1.Controls.Add(this.tBox_BirthLocationFr);
            this.groupBox1.Controls.Add(this.dTP_BirthDay);
            this.groupBox1.Controls.Add(this.rBtn_Female);
            this.groupBox1.Controls.Add(this.rBtn_Male);
            this.groupBox1.Controls.Add(this.tBox_FirstNameFr);
            this.groupBox1.Controls.Add(this.tBox_LastNameFr);
            this.groupBox1.Controls.Add(this.tBox_Cin);
            this.groupBox1.Controls.Add(this.tBox_FirstNameAr);
            this.groupBox1.Controls.Add(this.tBox_LastNameAr);
            this.groupBox1.Controls.Add(this.tBox_NumSomme);
            this.groupBox1.Controls.Add(this.pBox_Photo);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(495, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 407);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "العنوان";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "الهاتف التابت";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "الهاتف الشخصي";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Lieu de Naissance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "التخصص";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "مكان الإزدياد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 184);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "الجنس :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "تاريخ الإزدياد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "الإسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "النسب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Num Somme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cin";
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(10, 340);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(149, 51);
            this.btn_Import.TabIndex = 8;
            this.btn_Import.Text = "إستيراد";
            this.btn_Import.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(10, 298);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(149, 35);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(10, 258);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(149, 35);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "حفظ";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tBox_Address
            // 
            this.tBox_Address.Location = new System.Drawing.Point(183, 298);
            this.tBox_Address.Multiline = true;
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(296, 93);
            this.tBox_Address.TabIndex = 7;
            // 
            // tBox_Fix
            // 
            this.tBox_Fix.Location = new System.Drawing.Point(183, 258);
            this.tBox_Fix.Name = "tBox_Fix";
            this.tBox_Fix.Size = new System.Drawing.Size(127, 20);
            this.tBox_Fix.TabIndex = 7;
            // 
            // tBox_Tele
            // 
            this.tBox_Tele.Location = new System.Drawing.Point(356, 258);
            this.tBox_Tele.Name = "tBox_Tele";
            this.tBox_Tele.Size = new System.Drawing.Size(123, 20);
            this.tBox_Tele.TabIndex = 6;
            // 
            // combo_Specialite
            // 
            this.combo_Specialite.FormattingEnabled = true;
            this.combo_Specialite.Location = new System.Drawing.Point(10, 210);
            this.combo_Specialite.Name = "combo_Specialite";
            this.combo_Specialite.Size = new System.Drawing.Size(149, 21);
            this.combo_Specialite.TabIndex = 5;
            // 
            // tBox_BirthLocationAr
            // 
            this.tBox_BirthLocationAr.Location = new System.Drawing.Point(183, 219);
            this.tBox_BirthLocationAr.Name = "tBox_BirthLocationAr";
            this.tBox_BirthLocationAr.Size = new System.Drawing.Size(127, 20);
            this.tBox_BirthLocationAr.TabIndex = 4;
            // 
            // tBox_BirthLocationFr
            // 
            this.tBox_BirthLocationFr.Location = new System.Drawing.Point(356, 219);
            this.tBox_BirthLocationFr.Name = "tBox_BirthLocationFr";
            this.tBox_BirthLocationFr.Size = new System.Drawing.Size(123, 20);
            this.tBox_BirthLocationFr.TabIndex = 4;
            // 
            // dTP_BirthDay
            // 
            this.dTP_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_BirthDay.Location = new System.Drawing.Point(356, 182);
            this.dTP_BirthDay.Name = "dTP_BirthDay";
            this.dTP_BirthDay.Size = new System.Drawing.Size(123, 20);
            this.dTP_BirthDay.TabIndex = 3;
            // 
            // rBtn_Female
            // 
            this.rBtn_Female.AutoSize = true;
            this.rBtn_Female.Checked = true;
            this.rBtn_Female.Location = new System.Drawing.Point(235, 182);
            this.rBtn_Female.Name = "rBtn_Female";
            this.rBtn_Female.Size = new System.Drawing.Size(48, 17);
            this.rBtn_Female.TabIndex = 2;
            this.rBtn_Female.TabStop = true;
            this.rBtn_Female.Text = "أنثى";
            this.rBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_Male
            // 
            this.rBtn_Male.AutoSize = true;
            this.rBtn_Male.Location = new System.Drawing.Point(187, 182);
            this.rBtn_Male.Name = "rBtn_Male";
            this.rBtn_Male.Size = new System.Drawing.Size(42, 17);
            this.rBtn_Male.TabIndex = 2;
            this.rBtn_Male.Text = "ذكر";
            this.rBtn_Male.UseVisualStyleBackColor = true;
            // 
            // tBox_FirstNameFr
            // 
            this.tBox_FirstNameFr.Location = new System.Drawing.Point(352, 108);
            this.tBox_FirstNameFr.Name = "tBox_FirstNameFr";
            this.tBox_FirstNameFr.Size = new System.Drawing.Size(127, 20);
            this.tBox_FirstNameFr.TabIndex = 1;
            // 
            // tBox_LastNameFr
            // 
            this.tBox_LastNameFr.Location = new System.Drawing.Point(352, 145);
            this.tBox_LastNameFr.Name = "tBox_LastNameFr";
            this.tBox_LastNameFr.Size = new System.Drawing.Size(127, 20);
            this.tBox_LastNameFr.TabIndex = 1;
            // 
            // tBox_Cin
            // 
            this.tBox_Cin.Location = new System.Drawing.Point(183, 71);
            this.tBox_Cin.Name = "tBox_Cin";
            this.tBox_Cin.Size = new System.Drawing.Size(296, 20);
            this.tBox_Cin.TabIndex = 1;
            this.tBox_Cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_FirstNameAr
            // 
            this.tBox_FirstNameAr.Location = new System.Drawing.Point(183, 108);
            this.tBox_FirstNameAr.Name = "tBox_FirstNameAr";
            this.tBox_FirstNameAr.Size = new System.Drawing.Size(127, 20);
            this.tBox_FirstNameAr.TabIndex = 1;
            // 
            // tBox_LastNameAr
            // 
            this.tBox_LastNameAr.Location = new System.Drawing.Point(183, 145);
            this.tBox_LastNameAr.Name = "tBox_LastNameAr";
            this.tBox_LastNameAr.Size = new System.Drawing.Size(127, 20);
            this.tBox_LastNameAr.TabIndex = 1;
            // 
            // tBox_NumSomme
            // 
            this.tBox_NumSomme.Location = new System.Drawing.Point(183, 32);
            this.tBox_NumSomme.Name = "tBox_NumSomme";
            this.tBox_NumSomme.Size = new System.Drawing.Size(296, 20);
            this.tBox_NumSomme.TabIndex = 1;
            this.tBox_NumSomme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBox_Photo
            // 
            this.pBox_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Photo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pBox_Photo.Location = new System.Drawing.Point(10, 16);
            this.pBox_Photo.Name = "pBox_Photo";
            this.pBox_Photo.Size = new System.Drawing.Size(149, 158);
            this.pBox_Photo.TabIndex = 0;
            this.pBox_Photo.TabStop = false;
            // 
            // EmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesList";
            this.Text = "EmployeesList";
            this.Load += new System.EventHandler(this.EmployeesList_Load);
            this.pnl_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_Tools.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.FlowLayoutPanel pnl_Tools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBox_Address;
        private System.Windows.Forms.TextBox tBox_Fix;
        private System.Windows.Forms.TextBox tBox_Tele;
        private System.Windows.Forms.ComboBox combo_Specialite;
        private System.Windows.Forms.TextBox tBox_BirthLocationAr;
        private System.Windows.Forms.TextBox tBox_BirthLocationFr;
        private System.Windows.Forms.DateTimePicker dTP_BirthDay;
        private System.Windows.Forms.RadioButton rBtn_Female;
        private System.Windows.Forms.RadioButton rBtn_Male;
        private System.Windows.Forms.TextBox tBox_FirstNameFr;
        private System.Windows.Forms.TextBox tBox_LastNameFr;
        private System.Windows.Forms.TextBox tBox_Cin;
        private System.Windows.Forms.TextBox tBox_FirstNameAr;
        private System.Windows.Forms.TextBox tBox_LastNameAr;
        private System.Windows.Forms.TextBox tBox_NumSomme;
        private System.Windows.Forms.PictureBox pBox_Photo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_MalesCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_FemalesCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_TotalCount;
        private System.Windows.Forms.Label label15;
    }
}