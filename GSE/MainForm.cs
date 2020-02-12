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
        public MainForm()
        {
            InitializeComponent();
            entities = new EcoleDBEntities();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            cBox_Annee.DataSource = entities.Annee_Scolaire.Select(x => x.annee_Scolaire1).ToList();
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
    }
}
