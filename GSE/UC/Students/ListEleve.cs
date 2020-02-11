using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.UC.Students
{
    public partial class ListEleve : UserControl
    {
        EcoleDBEntities entities;
        public ListEleve()
        {
            InitializeComponent();
            entities = new EcoleDBEntities();
        }
        private void ListEleve_Load(object sender, EventArgs e)
        {
            cBox_Niveaus.DataSource = entities.Niveaux.Select(x => new { x.id });
            cBox_Classes.DataSource = entities.Classes.Select(x => new { x.id }).ToList();
        }
    }
}
