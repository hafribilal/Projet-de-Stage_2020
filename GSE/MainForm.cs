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
    public partial class MainForm : Form
    {
        EcoleDBEntities entities;
        public MainForm()
        {
            this.entities = new EcoleDBEntities();
            InitializeComponent();
            this.entities = Program.entities;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EcoleDBEntities entities = new EcoleDBEntities();
            cBox_Annee.DataSource = entities.Annee_Scolaire.Select(x => x.annee_Scolaire1).ToList();
        }
    }
}
