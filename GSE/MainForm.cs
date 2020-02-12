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
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string search_Placeholder = "Type somethings ...";
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
    }
}
