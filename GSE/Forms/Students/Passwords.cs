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
    public partial class Passwords : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public Passwords()
        {
            InitializeComponent();
        }

        private void Passwords_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Massar.DataAdabter data = new Massar.DataAdabter();
            data.InfoEleve();
        }

        private void btn_Import_img_Click(object sender, EventArgs e)
        {
            btn_Import_Click(new object(), new EventArgs());
        }
        void Sync()
        {
            try
            {
                btn_Sync_Click(new object(), new EventArgs());

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
            try
            {
                combo_Classe.DataSource = entities.Classes.Join(entities.Classe_Details, c => c.id, cd => cd.classe, (c, cd) => new { Classe = c, Details = cd }).Where(x => x.Details.annee == Program.Annee && x.Classe.niveau == (int)combo_Niveaus.SelectedItem).GroupBy(y => y.Classe.id).Select(x => x.Key).ToList();
                combo_Classe.SelectedItem = combo_Classe.Items[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.password}).ToList();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();
        }
    }
}
