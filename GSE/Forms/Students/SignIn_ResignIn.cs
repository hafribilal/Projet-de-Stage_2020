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
    public partial class SignIn_ResignIn : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public SignIn_ResignIn()
        {
            InitializeComponent();
        }

        private void SignIn_ResignIn_Load(object sender, EventArgs e)
        {
            Sync();
        }
        void Sync()
        {
            //lbl_Total.Text = entities.Eleves.Count().ToString();
            //lbl_TotalFemales.Text = entities.Eleves.Where(x => x.sexe == "أنثى").Count().ToString();
            //lbl_TotalMales.Text = entities.Eleves.Where(x => x.sexe == "ذكر").Count().ToString();
            //lbl_NumAvg.Text = (entities.Classe_Details.Where(x => x.annee == Program.Annee).Count() / entities.Classe_Details.Where(x => x.annee == Program.Annee).Select(x => x.classe).Distinct().ToList().Count()).ToString();

            //lbl_SignedInCount.Text = entities.Eleves.Where(x => x.registred == true).Count().ToString();
            //lbl_SignedInFemalesCount.Text = entities.Eleves.Where(x => x.registred == true && x.sexe == "أنثى").Count().ToString();
            //lbl_SignedInMalesCount.Text = entities.Eleves.Where(x => x.registred == true && x.sexe == "ذكر").Count().ToString();
            //lbl_NotSignedCount.Text = entities.Eleves.Where(x => x.registred == false).Count().ToString();
            //lbl_NotSignedFemalesCount.Text = entities.Eleves.Where(x => x.registred == false && x.sexe == "أنثى").Count().ToString();
            //lbl_NotSignedMalesCount.Text = entities.Eleves.Where(x => x.registred == false && x.sexe == "ذكر").Count().ToString();
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

                //dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, e => e.id, (cd, e) => new { eleve = e, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar }).ToList();
                combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void combo_Niveaus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoidClasses();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar, x.eleve.registred }).ToList();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }    
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns.Count-1)
            {
                try
                {
                    string id = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Eleve eleve = entities.Eleves.Where(x => x.id == id).FirstOrDefault();
                    if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "False")
                    {
                        eleve.registred = true;
                    }
                    else
                    {
                        eleve.registred = false;
                    }
                    btn_Save_Click(new object(), new EventArgs());
                    //btn_Sync_Click(new object(), new EventArgs());
                    dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar, x.eleve.registred }).ToList();
                }
                catch(Exception)
                {

                }
            }
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();

            lbl_SignedInCount.Text = entities.Eleves.Where(x => x.registred == true).Count().ToString();
            lbl_SignedInFemalesCount.Text = entities.Eleves.Where(x => x.registred == true && x.sexe == "أنثى").Count().ToString();
            lbl_SignedInMalesCount.Text = entities.Eleves.Where(x => x.registred == true && x.sexe == "ذكر").Count().ToString();
            lbl_NotSignedCount.Text = entities.Eleves.Where(x => x.registred == false).Count().ToString();
            lbl_NotSignedFemalesCount.Text = entities.Eleves.Where(x => x.registred == false && x.sexe == "أنثى").Count().ToString();
            lbl_NotSignedMalesCount.Text = entities.Eleves.Where(x => x.registred == false && x.sexe == "ذكر").Count().ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            entities.SaveChanges();
        }
        int registred = 0;
        private void dgv_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Eleve> eleves = new List<Eleve>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                Eleve eleve = new Eleve();
                string id =row.Cells[1].Value.ToString();
                eleve = entities.Eleves.Where(x => x.id == id).FirstOrDefault();
                if (registred %2 == 0)
                {
                    eleve.registred = true;
                }
                else
                {
                    eleve.registred = false;
                }
                eleves.Add(eleve);
            }
            registred++;
            btn_Save_Click(new object(), new EventArgs());
            dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar, x.eleve.registred }).ToList();
        }
    }
}
