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
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
        }
        EcoleDBEntities entities = new EcoleDBEntities();
        private void Student_Load(object sender, EventArgs e)
        {
            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
            LoidCombo();
        }
        void LoidCombo()
        {
            combo_Classes.DataSource = entities.Classes.Join(entities.Classe_Details, c => c.id, cd => cd.classe, (c, cd) => new { Classe = c, Details = cd }).Where(x => x.Details.annee == Program.Annee && x.Classe.niveau == (int)combo_Niveaus.SelectedItem).GroupBy(y=> y.Classe.id).Select(x => x.Key).ToList();
            combo_Classes.SelectedItem = combo_Classes.Items[0];

            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classes.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, e => e.id, (cd, e) => new { eleve = e, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar,x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidCombo();
        }

        private void combo_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classes.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
            //dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classes.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, e => e.id, (cd, e) => new { Eleve = e, Details = cd }).Select(y => y.Eleve).ToList();
        }

        private void Check_Female_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Massar.DataAdabter adabter = new Massar.DataAdabter();
            adabter.ListEleves();
            btn_Refresh_Click(new object(), new EventArgs());
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnl_Searchtools.Controls)
            {
                
                if (c is CheckBox) { CheckBox C = c as CheckBox; C.Checked = true; }
            }
        }
    }
}
