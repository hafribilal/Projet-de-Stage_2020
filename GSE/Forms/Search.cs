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
    public partial class Search : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            timer.Start();
            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            dgv.DataSource = entities.Eleves.Select(x => new { x.id, fullName = x.prenom_Ar + " " + x.nom_Ar, x.sexe, x.registred, x.status }).ToList();
        }
        public string search = "";
        public void Loader(string search)
        {
            if (search != "" || search != "Type somethings ...")
            {
                dgv.Rows.Clear();
                this.search = search;
            }
            // problem is here
            
            //.Where(x => x.prenom_Ar.Contains(search) || x.prenom_Fr.Contains(search) || x.nom_Ar.Contains(search) || x.nom_Fr.Contains(search) || x.id.Contains(search))
        }
        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (count == 10)
            {
                count = 0;
                dgv.DataSource = entities.Eleves.Select(x => new { x.id, fullName = x.prenom_Ar + " " + x.nom_Ar, x.sexe, x.registred, x.status }).ToList();
            }
            else
            {
                count++;
            }
        }
    }
}
