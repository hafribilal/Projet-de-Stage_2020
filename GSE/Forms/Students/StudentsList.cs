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
            Sync();
        }
        void Sync()
        {
            try
            {
                lbl_Total.Text = entities.Eleves.Count().ToString();
                lbl_TotalFemales.Text = entities.Eleves.Where(x => x.sexe == "أنثى").Count().ToString();
                lbl_TotalMales.Text = entities.Eleves.Where(x => x.sexe == "ذكر").Count().ToString();
                lbl_NumAvg.Text = (entities.Classe_Details.Where(x => x.annee == Program.Annee).Count() / entities.Classe_Details.Where(x => x.annee == Program.Annee).Select(x => x.classe).Distinct().ToList().Count()).ToString();
                combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
                combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
                LoidClasses();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        void LoidClasses()
        {
            combo_Classes.DataSource = entities.Classes.Join(entities.Classe_Details, c => c.id, cd => cd.classe, (c, cd) => new { Classe = c, Details = cd }).Where(x => x.Details.annee == Program.Annee && x.Classe.niveau == (int)combo_Niveaus.SelectedItem).GroupBy(y=> y.Classe.id).Select(x => x.Key).ToList();
            combo_Classes.SelectedItem = combo_Classes.Items[0];

            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classes.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, e => e.id, (cd, e) => new { eleve = e, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar,x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
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
            //loidingPage.Visible = true;
            adabter.ListEleves();
            //loidingPage.Visible = false;
            Sync();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnl_Searchtools.Controls)
            {
                
                if (c is CheckBox) { CheckBox C = c as CheckBox; C.Checked = true; }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //crv.BringToFront();
            //crv.Visible = true;
            //crv.ReportSource = StudentsList1;
        }
    }
}
