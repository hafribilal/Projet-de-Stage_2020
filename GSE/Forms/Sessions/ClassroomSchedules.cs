using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Sessions
{
    public partial class ClassroomSchedules : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public ClassroomSchedules()
        {
            InitializeComponent();
        }
        List<string> Days;
        Dictionary<string,DateTime> Times;
        List<DateTime> valueTimes;
        private void ClassroomSchedules_Load(object sender, EventArgs e)
        {
            Times = new Dictionary<string, DateTime>();
            //Morning
            Times.Add("08:30 > 09:30", DateTime.Parse("03/20/1999 08:30:00"));
            Times.Add("09:30 > 10:30", DateTime.Parse("03/20/1999 09:30:00"));
            Times.Add("10:30 > 11:30", DateTime.Parse("03/20/1999 10:30:00"));
            Times.Add("11:30 > 12:00", DateTime.Parse("03/20/1999 11:30:00"));
            // Afternoon
            Times.Add("13:30 > 14:30", DateTime.Parse("03/20/1999 13:30:00"));
            Times.Add("14:30 > 15:30", DateTime.Parse("03/20/1999 14:00:00"));
            Times.Add("15:30 > 16:30", DateTime.Parse("03/20/1999 15:30:00"));
            Times.Add("16:30 > 17:30", DateTime.Parse("03/20/1999 16:30:00"));

            combo_Time.DataSource = new BindingSource(Times, null);
            combo_Time.DisplayMember = "Key";
            combo_Time.ValueMember = "Value";
            combo_Time.SelectedIndex = 0;
            Days = new List<string>();
            Days.Add("الإثنين");
            Days.Add("الثلاتاء");
            Days.Add("الأربعاء");
            Days.Add("الخميس");
            Days.Add("الجمعة");
            //Days.Add("السبت");
            combo_Day.DataSource = Days;
            combo_Day.SelectedIndex = 0;
            
            Sync();

        }
        void Sync()
        {
            //btn_Sync_Click(new object(), new EventArgs());
            try
            {
                combo_Matiere.DataSource = entities.Matieres.Select(x => x.nom_1).ToList();
                combo_Prof.DataSource = entities.Professeurs.Select(x => new { id = x.num_Somme, fullName = x.nom_Ar + " " + x.prenom_Ar }).ToList();
                combo_Prof.DisplayMember = "fullName";
                combo_Prof.ValueMember = "id";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

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
        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            foreach (string day in Days)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = day;
                row.Cells.Add(Subject(day, "08:30:00"));
                row.Cells.Add(Subject(day, "09:30:00"));
                row.Cells.Add(Subject(day, "10:30:00"));
                row.Cells.Add(Subject(day, "11:30:00"));
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(Subject(day, "13:30:00"));
                row.Cells.Add(Subject(day, "14:30:00"));
                row.Cells.Add(Subject(day, "15:30:00"));
                row.Cells.Add(Subject(day, "16:30:00"));
                dgv.Rows.Add(row);
            }
        }
        DataGridViewTextBoxCell Subject(string day,string time)
        {
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            DateTime subjectTime = DateTime.Parse("03/20/1999 " + time);
            var subject = entities.Emploi_Temps.Join(entities.Professeurs, eT => eT.prof, p => p.num_Somme, (eT, p) => new { Emploi = eT, Prof = p }).FirstOrDefault(x => x.Emploi.classe == combo_Classe.SelectedItem.ToString() && x.Emploi.joure == day && x.Emploi.date_Debut == subjectTime);
            if (subject != null)
            {
                string v = subject.Emploi.salle + " - " + subject.Prof.specialite;
                cell.Value = v;
            }
            return cell;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool exist = true;
            bool twoHours = false;
            DateTime date_Debut = DateTime.Parse(combo_Time.SelectedValue.ToString());
            Emploi_Temps emploi = entities.Emploi_Temps.FirstOrDefault(x => x.date_Debut == date_Debut  && x.classe == combo_Classe.SelectedItem.ToString() && x.joure == combo_Day.SelectedItem.ToString());
            if (emploi is null)
            {
                emploi = new Emploi_Temps();
                exist = false;
            }
            emploi.joure = combo_Day.SelectedItem.ToString();
            emploi.date_Debut = DateTime.Parse(combo_Time.SelectedValue.ToString());
            emploi.salle = tBox_Salle.Text;
            emploi.prof = combo_Prof.SelectedValue.ToString();
            emploi.classe = combo_Classe.SelectedItem.ToString();
            if (rBtn_OneHour.Checked)
            {
                if (DateTime.Parse(combo_Time.SelectedValue.ToString()) == DateTime.Parse("03/20/1999 11:30:00"))
                {
                    emploi.date_Fin = DateTime.Parse("03/20/1999 12:00:00");
                }
                else
                {
                    emploi.date_Fin = DateTime.Parse(combo_Time.SelectedValue.ToString()).AddHours(1);
                }
            }
            else
            {
                if (DateTime.Parse(combo_Time.SelectedValue.ToString()) == DateTime.Parse("03/20/1999 11:30:00") || DateTime.Parse(combo_Time.SelectedValue.ToString()) == DateTime.Parse("03/20/1999 16:30:00"))
                {
                    MessageBox.Show("Error Time");
                }
                else
                {
                    emploi.date_Fin = DateTime.Parse(combo_Time.SelectedValue.ToString()).AddHours(1);
                    twoHours = true;
                }
            }
            if (entities.Salles.FirstOrDefault(x=> x.num == tBox_Salle.Text) is null)
            {
                entities.Salles.Add(new Salle { num = tBox_Salle.Text, capacite = 40 });
            }
            if (!exist)
            {
                entities.Emploi_Temps.Add(emploi);
            }
            entities.SaveChanges();
            if (twoHours)
            {
                emploi.date_Debut = DateTime.Parse(emploi.date_Debut.ToString()).AddHours(1);
                emploi.date_Fin = DateTime.Parse(emploi.date_Fin.ToString()).AddHours(1);
                entities.Emploi_Temps.Add(emploi);
                entities.SaveChanges();
            }
            combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DateTime date_Debut = DateTime.Parse(combo_Time.SelectedValue.ToString());
            Emploi_Temps emploi = entities.Emploi_Temps.FirstOrDefault(x => x.classe == combo_Classe.SelectedItem.ToString() && x.joure == combo_Day.SelectedItem.ToString() && x.date_Debut == date_Debut);
            if (emploi is null)
            {
                MessageBox.Show("Ops ... nothings");
            }
            else
            {
                entities.Emploi_Temps.Remove(emploi);
            }
            entities.SaveChanges();
            combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name != " " && e.RowIndex >= 0)
            {
                combo_Day.SelectedItem = dgv.Rows[e.RowIndex].HeaderCell.Value;
                if (e.ColumnIndex < 4)
                {
                    combo_Time.SelectedIndex = e.ColumnIndex;
                }
                else if(e.ColumnIndex > 4)
                {
                    combo_Time.SelectedIndex = e.ColumnIndex;
                }
            }
        }
    }
}
