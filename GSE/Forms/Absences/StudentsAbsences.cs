using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Absences
{
    public partial class StudentsAbsences : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public StudentsAbsences()
        {
            InitializeComponent();
        }

        private void StudentsAbsences_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Classe.DataSource = entities.Classe_Details.Join(entities.Classes, cD => cD.classe, c => c.id, (cD, c) => new { Details = cD, Classe = c }).Where(x => x.Classe.niveau == (int)combo_Niveaus.SelectedItem && x.Details.annee == Program.Annee).Select(x => x.Classe.id).ToList();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                combo_Students.DataSource = entities.Eleves.Join(entities.Classe_Details, el => el.id, cD => cD.eleve, (el, cD) => new { Eleve = el, Classe = cD }).Where(x=> x.Classe.classe == combo_Classe.SelectedItem.ToString()).Select(x => new { id = x.Eleve.id, fullName = x.Eleve.nom_Ar + " " +x.Eleve.prenom_Ar }).ToList();
                combo_Students.DisplayMember = "fullName";
                combo_Students.ValueMember = "id";
                dgv.DataSource = entities.Eleves.Join(entities.Absence_Eleve, el => el.id, aE => aE.eleve, (el, aE) => new { eleve = el, Absence = aE }).Where(x => x.eleve.id == combo_Students.SelectedValue.ToString()).Select(x => new { x.eleve.num,x.eleve.id, x.eleve.nom_Ar, x.eleve.prenom_Ar }).ToList();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        void Sync()
        {
            //btn_Sync_Click(new object(), new EventArgs());
            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
            lbl_TotalDaysCount.Text = entities.Absence_Eleve.Count().ToString();
            lbl_NotedDaysCount.Text = entities.Absence_Eleve.Where(x => x.motife != null).Count().ToString();
            lbl_NotNotedDaysCount.Text = entities.Absence_Eleve.Where(x => x.motife == null).Count().ToString();
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            Sync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Absence_Eleve absence = new Absence_Eleve();
            absence.eleve = combo_Students.SelectedItem.ToString();
            absence.heure_Debut = TimeSpan.Parse(dTP_DateDebut.ToString());
            absence.heure_Fin = TimeSpan.Parse(dTP_DateFin.ToString());
            entities.Absence_Eleve.Add(absence);
            entities.SaveChanges();
        }
    }
}
