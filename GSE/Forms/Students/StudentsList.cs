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
            dgv.DataSource = entities.Eleves.Select(x => new { x.nom_Ar, x.prenom_Ar, x.sexe, x.date_Naissance, x.lieu_Naissance_Ar }).ToList();
        }
    }
}
