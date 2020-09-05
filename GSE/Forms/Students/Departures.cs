using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Students
{
    public partial class Departures : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public Departures()
        {
            InitializeComponent();
        }

        private void Departures_Load(object sender, EventArgs e)
        {
            Sync();
        }
        void Sync()
        {
            btn_Sync_Click(new object(), new EventArgs());

            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
            LoidClasses();
        }
        void LoidClasses()
        {
            try
            {
                combo_Classe.DataSource = entities.Classes.Join(entities.Classe_Details, c => c.id, cd => cd.classe, (c, cd) => new { Classe = c, Details = cd }).Where(x => x.Details.annee == Program.Annee && x.Classe.niveau == (int)combo_Niveaus.SelectedItem).GroupBy(y => y.Classe.id).Select(x => x.Key).ToList();
                combo_Classe.SelectedItem = combo_Classe.Items[0];

                //dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, e => e.id, (cd, e) => new { eleve = e, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
                combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Where(x => x.eleve.status == "مغادر").Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();

            lbl_DeparturesCount.Text = entities.Eleves.Where(x => x.status == "مغادر").Count().ToString();
            lbl_DeparturesFemalesCount.Text = entities.Eleves.Where(x => x.status == "مغادر" && x.sexe == "أنثى").Count().ToString();
            lbl_DeparturesMalesCount.Text = entities.Eleves.Where(x => x.status == "مغادر" && x.sexe == "ذكر").Count().ToString();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }
    }
}
