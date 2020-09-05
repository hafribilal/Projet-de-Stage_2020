using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Absences
{
    public partial class AbsenceSheet : Form
    {
        EcoleDBEntities entities = new EcoleDBEntities();
        public AbsenceSheet()
        {
            InitializeComponent();
        }

        private void AbsenceSheet_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void combo_Niveaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Classe.DataSource = entities.Classe_Details.Join(entities.Classes, cD => cD.classe, c => c.id, (cD, c) => new { Details = cD, Classe = c }).Where(x => x.Classe.niveau == (int)combo_Niveaus.SelectedItem && x.Details.annee == Program.Annee).Select(x => x.Classe.id).ToList();
        }

        private void combo_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Sync()
        {
            combo_Niveaus.DataSource = entities.Niveaux.Select(x => x.id).ToList();
            combo_Niveaus.SelectedItem = combo_Niveaus.Items[0];
        }
    }
}
