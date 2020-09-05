using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GSE.Forms.Exams
{
    public partial class ControlsNotes : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public ControlsNotes()
        {
            InitializeComponent();
        }

        private void ControlsNotes_Load(object sender, EventArgs e)
        {
            Sync();
            combo_Semester.DataSource = entities.Semestres.Select(x => new { id = x.id, libelle = x.libelle }).ToList();
            combo_Semester.DisplayMember = "libelle";
            combo_Semester.ValueMember = "id";
            combo_Semester.SelectedIndex = 0;
        }
        int semester = 0;
        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Columns.Clear();
            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id,fullName = x.eleve.prenom_Ar+" "+ x.eleve.nom_Ar, x.eleve.sexe}).ToList();
            //dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Join(entities.Note_Details, el => el.eleve.id, nD => nD.eleve, (el, nD) => new { eleve = el, note = nD }).Select(x => new { x.eleve.eleve.num, x.eleve.eleve.id, fullName = x.eleve.eleve.nom_Ar + " " + x.eleve.eleve.prenom_Ar}).ToList();
            
            for (int i = 1; i <= entities.Matieres.Count(); i++)
            {
                try
                {
                    Matiere matiere = entities.Matieres.FirstOrDefault(x => x.id == i);
                    dgv.Columns.Add(matiere.id.ToString(), matiere.nom_1);
                }
                catch (Exception)
                {}
            }
            //MessageBox.Show(combo_Semester.SelectedValue.ToString());
            //semester = int.Parse(combo_Semester.SelectedValue.ToString());

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string id = row.Cells[1].Value.ToString();
                for (int i = 4; i < dgv.Columns.Count; i++)
                {
                    try
                    {
                        
                        string matiere = dgv.Columns[i].HeaderText;
                        //MessageBox.Show(matiere);
                        row.Cells[i].Value = entities.Note_Details.FirstOrDefault(x => x.annee == Program.Annee && x.eleve == id && x.semestere == 0 && x.matiere == matiere).note;
                    }
                    catch (Exception)
                    {

                    }
                }
                try
                {
                    row.Cells[dgv.Columns.Count - 1].Value = entities.Notes.FirstOrDefault(x => x.eleve == id && x.annee == Program.Annee && x.semester == 0).note1;

                }
                catch (Exception)
                {

                }
            }
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            Sync();
        }
        void Sync()
        {
            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
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

        private void btn_Import_Click(object sender, EventArgs e)
        {
            Massar.DataAdabter data = new Massar.DataAdabter();
            data.MoyenneCc();
        }
    }
}
