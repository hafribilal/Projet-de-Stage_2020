using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE
{
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            EcoleDBEntities entities = new EcoleDBEntities();
            dgv_Search.DataSource = entities.Eleves.Select(x => new { x.nom_Ar, x.prenom_Ar, x.sexe, x.date_Naissance, x.lieu_Naissance_Ar }).ToList();
        }
    }
}
