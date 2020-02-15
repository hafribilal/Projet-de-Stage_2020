using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE
{
    public partial class MainForm : Form
    {
        EcoleDBEntities entities;
        // Draging Form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
            entities = new EcoleDBEntities();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            combo_Annee.DataSource = entities.Annee_Scolaire.Select(x => x.annee_Scolaire1).ToList();
            Program.Annee = combo_Annee.SelectedItem.ToString();
            SubNav();
            
        }
        void SubNav()
        {
            foreach (Panel p in p_SubNav.Controls)
            {
                p.Hide();
            }
        }
        void OpenForm(Form form)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            gBox_SchoolName.Visible = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string search_Placeholder = "Type somethings ...";
        Search search ;
        private void tBox_Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBox_Search_Enter(object sender, EventArgs e)
        {
            if (tBox_Search.Text.Equals(search_Placeholder))
            {
                tBox_Search.Text = "";
            }
        }

        private void tBox_Search_Leave(object sender, EventArgs e)
        {
            if (tBox_Search.Text.Equals(""))
            {
                tBox_Search.Text = search_Placeholder;
            }
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Students.Show();
        }

        private void btn_Absences_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Absences.Show();
        }

        private void btn_Sessions_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Sessions.Show();
        }

        private void btn_Exames_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Exames.Show();
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Employees.Show();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            SubNav();
            pnl_Settings.Show();
        }

        private void btn_ListEleve_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentsList());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            OpenForm(Program.Search);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combo_Annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Annee = combo_Annee.SelectedItem.ToString();
        }

        private void p_Header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void p_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void p_Header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_SortFolders_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_SignIn_ResignIn_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentsMovement_Click(object sender, EventArgs e)
        {

        }

        private void btn_Arrivals_Click(object sender, EventArgs e)
        {

        }

        private void btn_Departures_Click(object sender, EventArgs e)
        {

        }

        private void btn_SchoolFiles_Click(object sender, EventArgs e)
        {

        }

        private void btn_Passwords_Click(object sender, EventArgs e)
        {

        }

        private void btn_ClassroomSistribution_Click(object sender, EventArgs e)
        {

        }

        private void btn_ClassroomSchedules_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentsAbsences_Click(object sender, EventArgs e)
        {

        }

        private void btn_AbsenceSheet_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConsultingAbsentees_Click(object sender, EventArgs e)
        {

        }

        private void btn_Marksheets_Click(object sender, EventArgs e)
        {

        }

        private void btn_TrackExamSheets_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExamsManagement_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExamsGarding_Click(object sender, EventArgs e)
        {

        }

        private void btn_ControlsNotes_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExamsNotes_Click(object sender, EventArgs e)
        {

        }

        private void btn_CouncilResolution_Click(object sender, EventArgs e)
        {

        }

        private void btn_EmployeesList_Click(object sender, EventArgs e)
        {

        }
        bool Maximized = false;
        private void p_Header_DoubleClick(object sender, EventArgs e)
        {
            if (!Maximized)
            {
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                Maximized = true;
            }
            else
            {
                Left = Top = 50;
                Width = 1223;
                Height = 663;
                Maximized = false;
            }
        }
    }
}
