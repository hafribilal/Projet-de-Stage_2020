using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static EcoleDBEntities entities;
        [STAThread]
        static void Main()
        {
            entities = new EcoleDBEntities();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
