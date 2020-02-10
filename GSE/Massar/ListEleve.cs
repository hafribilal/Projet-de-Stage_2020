using GSE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massar
{
    internal class ListEleve
    {
        private DataSet workBook;
        private Ecole ecole;
        private Annee_Scolaire annee_Scolaire;
        private List<Classe_Details> classe_Details;
        private List<Niveau> niveaus;
        private List<Classe> classes;
        private List<Eleve> eleves;
        public ListEleve()
        {
            workBook = new DataSet();
        }
        public ListEleve(DataSet workBook)
        {
            niveaus = new List<Niveau>();
            classes = new List<Classe>();
            eleves = new List<Eleve>();
            classe_Details = new List<Classe_Details>();
            this.workBook = new DataSet();
            eleves = GetEleves(workBook);
        }
        public DataSet WorkBook { get => workBook; set => workBook = value; }
        public Ecole Ecole { get => ecole; set => ecole = value; }
        public Annee_Scolaire Annee_Scolaire { get => annee_Scolaire; set => annee_Scolaire = value; }
        public List<Niveau> Niveaus { get => niveaus; set => niveaus = value; }
        public List<Classe> Classes { get => classes; set => classes = value; }
        public List<Eleve> Eleves { get => eleves; set => eleves = value; }
        public List<Classe_Details> Classe_Details { get => classe_Details; set => classe_Details = value; }

        public DataTable GetData(DataTable workSheet)
        {
            string className = workSheet.Rows[9][8].ToString();
            DataTable List = new DataTable(className);
            int[] studentsColumns = { 26, 23, 16, 12, 11, 5, 2 };
            DataRow row = workSheet.Rows[13];
            foreach (int i in studentsColumns)
            {
                List.Columns.Add(row[i].ToString());
            }
            for (int i = 14; i < workSheet.Rows.Count; i++)
            {
                row = workSheet.Rows[i];
                if (row[26] != null)
                {
                    DataRow dr = List.NewRow();

                    for (int j = 0; j < studentsColumns.Length; j++)
                    {
                        dr[j] = row[studentsColumns[j]].ToString();
                    }
                    List.Rows.Add(dr);
                }
            }
            workBook.Tables.Add(List);
            return List;
        }
        private Eleve GetEleve(DataRow row)
        {
            return new Eleve
            {
                num = int.Parse(row[0].ToString()),
                id = row[1].ToString(),
                nom_Ar = row[2].ToString(),
                prenom_Ar = row[3].ToString(),
                sexe = row[4].ToString(),
                date_Naissance = DateTime.Parse(row[5].ToString()),
                lieu_Naissance_Ar = row[6].ToString()
            };
        }
        public List<Eleve> GetEleves(DataTable workSheet)
        {
            List<Eleve> eleves = new List<Eleve>();
            Classe classe = GetClasse(workSheet);
            Classe_Details details;
            classes.Add(classe);
            DataTable table = GetData(workSheet);
            foreach (DataRow row in table.Rows)
            {
                details = new Classe_Details();
                Eleve eleve = GetEleve(row);
                details.eleve = eleve.id;
                details.classe = classe.id;
                details.annee = annee_Scolaire.annee_Scolaire1;
                classe_Details.Add(details);
                eleves.Add(eleve);
            }
            return eleves;
        }
        public List<Eleve> GetEleves(DataSet workBook)
        {
            ecole = GetInstitution(workBook.Tables[0]);
            annee_Scolaire = GetAnnee(workBook.Tables[0]);
            List<Eleve> ListEleves = new List<Eleve>();
            foreach (DataTable workSheet in workBook.Tables)
            {
                ListEleves.AddRange(GetEleves(workSheet));
            }
            return ListEleves;
        }
        public Classe GetClasse(DataTable workSheet)
        {
            Niveau n = GetNiveau(int.Parse(workSheet.Rows[9][8].ToString().Substring(0, 1)), workSheet.Rows[9][19].ToString());
            return new Classe
            {
                id = workSheet.Rows[9][8].ToString(),
                surnom = workSheet.Rows[9][19].ToString(),
                niveau = n.id
            };
        }
        public List<Classe> GetClasses(DataSet workBook)
        {
            List<Classe> classes = new List<Classe>();
            foreach (DataTable workSheet in workBook.Tables)
            {
                classes.Add(GetClasse(workSheet));
            }
            return classes;
        }
        public Niveau GetNiveau(int num,string libelle)
        {
            Niveau niveau = new Niveau
            {
                id = num,
                libelle = libelle,
            };
            bool exicte=false;
            if (niveaus.Count>0)
            {
                foreach (Niveau n in Niveaus)
                {
                    if (n.Equals(niveau))
                    {
                        exicte = true;
                    }
                }
            }
            if (!exicte)
            {
                Niveaus.Add(niveau);
            }
            return niveau;
        }
        public Annee_Scolaire GetAnnee(DataTable workSheet)
        {
            string[] annee = workSheet.Rows[4][2].ToString().Split('/');
            var debut = "03/09/" + workSheet.Rows[4][2].ToString().Substring(0,4);
            var date_Debut = DateTime.Parse(debut, new System.Globalization.CultureInfo("pt-BR"));
            var fin = "30/06/" + workSheet.Rows[4][2].ToString().Substring(5, 4);
            var date_Fin = DateTime.Parse(fin, new System.Globalization.CultureInfo("pt-BR"));
            return new Annee_Scolaire { annee_Scolaire1= workSheet.Rows[4][2].ToString(), date_Debut=date_Debut, date_Fin= date_Fin};
        }
        public Ecole GetInstitution(DataTable workSheet)
        {
            return new Ecole
            {
                nom= workSheet.Rows[6][7].ToString(),
                academie = workSheet.Rows[4][19].ToString(),
                direction_Provinciale= workSheet.Rows[6][20].ToString(),
                commoune= workSheet.Rows[4][7].ToString(),
            };
        }
    }
}
