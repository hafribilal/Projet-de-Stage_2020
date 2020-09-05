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

namespace GSE.Forms.Students
{
    public partial class StudentsMovement : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        DataTable dataTable = new DataTable("حركية التلاميذ");
        public StudentsMovement()
        {
            InitializeComponent();
            dataTable.Columns.Add("الوضعية");
            dataTable.Rows.Add("وافد");
            dataTable.Rows.Add("مغير القسم");
            dataTable.Rows.Add("مغير التوجيه");
            dataTable.Rows.Add("مدمج");
            dataTable.Rows.Add("مغادر");
            dataTable.Rows.Add("منقطع");
            dataTable.Rows.Add("مضاف");
            dataTable.Rows.Add("محذوف");
        }

        private void StudentsMovement_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoidClasses();
        }
        bool statusColomn = false;
        int ma3rftxh3laxh = 1;
        int index = 1;
        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = entities.Classe_Details.Where(x => x.classe == combo_Classe.SelectedItem.ToString() && x.annee == Program.Annee).Join(entities.Eleves, cd => cd.eleve, el => el.id, (cd, el) => new { eleve = el, detail = cd }).Select(x => new { x.eleve.num, x.eleve.id, x.eleve.prenom_Ar, x.eleve.nom_Ar, x.eleve.sexe, x.eleve.date_Naissance, x.eleve.lieu_Naissance_Ar}).ToList();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show("combo_Classe_SelectedIndexChanged");
            }
            
            if (!statusColomn)
            {
                DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
                status.DataSource = dataTable;
                status.DisplayMember = "الوضعية";
                //status.ValueMember = "الوضعية";
                dgv.Columns.Add(status);
                statusColomn = true;
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                // PROBLEM HERE ; help me
                string id = row.Cells[index].Value.ToString();
                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                
                row.Cells[row.Cells.Count - 1].Value = entities.Eleves.Where(x => x.id == id).FirstOrDefault().status.ToString();
                //cell.DisplayMember = row.Cells[row.Cells.Count - 1].Value;
                //Reference the ComboBoxCell.

                //DataGridViewComboBoxCell comboBoxCell = (row.Cells[row.Cells.Count - 1] as DataGridViewComboBoxCell);
                //Insert the Default Item to ComboBoxCell.

                ////comboBoxCell.Items.Add("Select");
                //comboBoxCell.DataSource = dataTable;
                //comboBoxCell.DisplayMember = "الوضعية";
                //comboBoxCell.DisplayMember = "الوضعية";

                ////Set the Default Value as the Selected Value.
                //comboBoxCell.Value = entities.Eleves.Where(x => x.id == id).FirstOrDefault().status.ToString();
                ////row.Cells["status"] = comboBoxCell;
            }
            if (ma3rftxh3laxh<3)
            {
                ma3rftxh3laxh++;
                if (ma3rftxh3laxh == 1)
                {
                    index = 1;
                }
                if (ma3rftxh3laxh == 2)
                {
                    index = 2;
                }
                if (ma3rftxh3laxh == 3)
                {
                    index = 2;
                }
            }
            else
            {
                ma3rftxh3laxh--;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                bool exist = false;
                foreach (DataRow r in dataTable.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString().Equals(r[0].ToString()))
                            exist = true;
                    }
                    catch (Exception)
                    {}
                }
                if (exist)
                {
                    try
                    {
                        string id = row.Cells[index].Value.ToString();
                        Eleve eleve = entities.Eleves.Where(x => x.id == id).FirstOrDefault();
                        eleve.status = row.Cells[0].Value.ToString();
                        entities.SaveChanges();
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                MessageBox.Show("Property: "+ validationError.PropertyName + "\nError: "+ validationError.ErrorMessage);
                            }
                        }
                    }
                }
            }
            
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            LoidClasses();

            lbl_ArrivalsCount.Text = entities.Eleves.Where(x => x.status == "وافد").Count().ToString();
            lbl_ClasseSwitchersCount.Text = entities.Eleves.Where(x => x.status == "مغير القسم").Count().ToString();
            lbl_BrancheSwitchersCount.Text = entities.Eleves.Where(x => x.status == "مغير التوجيه").Count().ToString();
            lbl_IntegratedCount.Text = entities.Eleves.Where(x => x.status == "مدمج").Count().ToString();
            lbl_DeparturesCount.Text = entities.Eleves.Where(x => x.status == "مغادر").Count().ToString();
            lbl_StopersCount.Text = entities.Eleves.Where(x => x.status == "منقطع").Count().ToString();
            lbl_AddedsCount.Text = entities.Eleves.Where(x => x.status == "مضاف").Count().ToString();
            lbl_DeletedsCount.Text = entities.Eleves.Where(x => x.status == "محذوف").Count().ToString();
        }
        void LoidClasses()
        {
            try
            {
                combo_Classe.DataSource = entities.Classes.Join(entities.Classe_Details, c => c.id, cd => cd.classe, (c, cd) => new { Classe = c, Details = cd }).Where(x => x.Details.annee == Program.Annee && x.Classe.niveau == (int)combo_Niveaus.SelectedItem).GroupBy(y => y.Classe.id).Select(x => x.Key).ToList();
                combo_Classe.SelectedItem = combo_Classe.Items[0];

                //combo_Classe_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show("LoidClasses");
            }
        }
        void Sync()
        {
            try
            {
                btn_Sync_Click(new object(), new EventArgs());
                combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
                combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show("Sync");
            }
        }
        ComboBox editGridCellComboBox = new ComboBox();
        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //editGridCellComboBox = (ComboBox)e.Control;
            //if ((editGridCellComboBox != null))
            //{
            //    editGridCellComboBox.SelectedIndexChanged += editGridCellComboBox_SelectedIndexChanged;
            //}
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
