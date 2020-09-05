using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Exams
{
    public partial class MarkSheets : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public MarkSheets()
        {
            InitializeComponent();
        }

        private void MarkSheets_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void combo_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Profs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Sync()
        {
            combo_Classes.DataSource = entities.Classe_Details.Where(x => x.annee == Program.Annee).Select(x => x.classe).ToList();
            combo_Profs.DataSource = entities.Professeurs.Select(x => x.nom_Ar + " " + x.prenom_Ar).ToList();
            if (DateTime.Now.Month > 1 && DateTime.Now.Month < 7)
            {
                combo_Semester.SelectedIndex = 1;
            }
            else
            {
                combo_Semester.SelectedIndex = 0;
            }
        }
    }
}
