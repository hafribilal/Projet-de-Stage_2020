using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Employees
{
    public partial class EmployeesList : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public EmployeesList()
        {
            InitializeComponent();
        }

        private void EmployeesList_Load(object sender, EventArgs e)
        {
            Sync();
        }
        void Sync()
        {
            dgv.DataSource = entities.Professeurs.Select(x => new { x.num_Somme, fullName = x.nom_Ar + " " + x.prenom_Ar, x.cin, x.sexe, x.specialite }).ToList();
            lbl_TotalCount.Text = entities.Professeurs.Count().ToString();
            lbl_FemalesCount.Text = entities.Professeurs.Where(x => x.sexe == "أنثى").Count().ToString();
            lbl_MalesCount.Text = entities.Professeurs.Where(x => x.sexe == "ذكر").Count().ToString();
            foreach (Control c in groupBox1.Controls) if (c is TextBox) c.Text = "";
            combo_Specialite.DataSource = entities.Matieres.Select(x=> x.nom_1).ToList();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool exist = false;
            try
            {
                Professeur professeur = entities.Professeurs.FirstOrDefault(x => x.num_Somme == tBox_NumSomme.Text);
                if (professeur is null)
                {
                    professeur = new Professeur();
                    professeur.num_Somme = tBox_NumSomme.Text;
                    exist = true;
                }
                professeur.cin = tBox_Cin.Text;
                professeur.nom_Ar = tBox_LastNameAr.Text;
                professeur.nom_Fr = tBox_LastNameFr.Text;
                professeur.prenom_Ar = tBox_FirstNameAr.Text;
                professeur.prenom_Fr = tBox_FirstNameFr.Text;
                if (rBtn_Male.Checked)
                {
                    professeur.sexe = rBtn_Male.Text;
                }
                else
                {
                    professeur.sexe = rBtn_Female.Text;
                }
                professeur.date_Naissance = dTP_BirthDay.Value;
                professeur.lieu_Naissance_Ar = tBox_BirthLocationAr.Text;
                professeur.lieu_Naissance_Fr = tBox_BirthLocationFr.Text;
                professeur.specialite = combo_Specialite.SelectedItem.ToString();
                professeur.tele = tBox_Tele.Text;
                professeur.fix = tBox_Fix.Text;
                if (exist)
                {
                    entities.Professeurs.Add(professeur);
                }
                entities.SaveChanges();
                Sync();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + "\nError: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Professeur professeur = entities.Professeurs.FirstOrDefault(x => x.num_Somme == tBox_NumSomme.Text);
                if (professeur != null)
                {
                    professeur.num_Somme = tBox_NumSomme.Text;
                    entities.Professeurs.Remove(professeur);
                }
                entities.SaveChanges();
                Sync();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + "\nError: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string numSomme = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Professeur professeur = entities.Professeurs.FirstOrDefault(x => x.num_Somme == numSomme);
                tBox_Cin.Text = professeur.cin;
                tBox_LastNameAr.Text = professeur.nom_Ar;
                tBox_LastNameFr.Text = professeur.nom_Fr;
                tBox_FirstNameAr.Text = professeur.prenom_Ar;
                tBox_FirstNameFr.Text = professeur.prenom_Fr;
                if (professeur.sexe.Equals(rBtn_Female.Text))
                {
                    rBtn_Female.Checked = true;
                }
                else
                {
                    rBtn_Male.Checked = true;
                }
                dTP_BirthDay.Value = DateTime.Parse(professeur.date_Naissance.ToString());
                tBox_BirthLocationAr.Text = professeur.lieu_Naissance_Ar;
                tBox_BirthLocationFr.Text = professeur.lieu_Naissance_Fr;
                combo_Specialite.SelectedItem = professeur.specialite;
                tBox_Tele.Text = professeur.tele;
                tBox_Fix.Text = professeur.fix;
            }
        }
    }
}
