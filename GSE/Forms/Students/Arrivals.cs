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
    public partial class Arrivals : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public Arrivals()
        {
            InitializeComponent();
        }

        private void Arrivals_Load(object sender, EventArgs e)
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

                combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();

            lbl_ArrivalsCount.Text = entities.Eleves.Where(x => x.status == "وافد").Count().ToString();
            lbl_ArrivalsFemalsCount.Text = entities.Eleves.Where(x => x.status == "وافد" && x.sexe == "أنثى").Count().ToString();
            lbl_ArrivalsMalsCount.Text = entities.Eleves.Where(x => x.status == "وافد" && x.sexe == "ذكر").Count().ToString();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Where(x=> x.eleve.status == "وافد").Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }
    }
}
