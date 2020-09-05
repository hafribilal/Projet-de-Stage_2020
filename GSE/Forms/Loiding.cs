using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE.Forms.Students
{
    public partial class Loiding : UserControl
    {
        public Loiding()
        {
            InitializeComponent();
        }

        private void Loiding_Resize(object sender, EventArgs e)
        {
            //pictureBox.Location = new Point(ClientSize.Width / 2 - 2*pictureBox.Size.Width + 290 / 2, ClientSize.Height / 2 - 2 * pictureBox.Size.Height / 3);
            //pictureBox.Anchor = AnchorStyles.None;
        }
    }
}
