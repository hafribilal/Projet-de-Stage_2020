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
    public partial class ClassroomSistribution : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public ClassroomSistribution()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ClassroomSistribution_Load(object sender, EventArgs e)
        {
            //cLBox_Classes.Items.AddRange();
            foreach (string item in entities.Matieres.Select(x => x.nom_1))
            {
                cLBox_Classes.Items.Add(item);
            }
        }
    }
}
