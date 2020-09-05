using GSE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massar
{
    internal class InfoEleve
    {
        private DataSet workBook;
        private Ecole ecole;
        private Annee_Scolaire annee_Scolaire;
        private List<Niveau> niveaus;
        private List<Classe> classes;
        private List<Classe_Details> classe_Details;
        private List<Eleve> eleves;
        public InfoEleve()
        {
            workBook = new DataSet();
        }
        public InfoEleve(DataSet workBook)
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

        public DataTable GetData(DataTable workSheet)
        {
            string className = workSheet.Rows[6][6].ToString();
            DataTable List = new DataTable(className);
            int[] studentsColumns = { 1, 2, 3, 4, 5 };
            DataRow row = workSheet.Rows[8];
            foreach (int i in studentsColumns)
            {
                List.Columns.Add(row[i].ToString());
            }
            for (int i = 9 ; i < workSheet.Rows.Count; i++)
            {
                row = workSheet.Rows[i];
                if (row[1] != null)
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
            string[] splitDate = row[2].ToString().Split('-');
            var date = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
            return new Eleve
            {
                id = row[0].ToString(),
                //Nom_Ar = row[].ToString(),
                //Prenom_Ar = row[].ToString(),
                //Date_Naissance = DateTime.Parse(row[2].ToString()),
                date_Naissance = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                sexe = row[3].ToString(),
                password = row[4].ToString()
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
            Niveau n = GetNiveau(int.Parse(workSheet.Rows[4][5].ToString().Substring(0, 1)), workSheet.Rows[4][3].ToString());
            return new Classe
            {
                id = workSheet.Rows[4][5].ToString(),
                surnom = workSheet.Rows[4][3].ToString(),
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
        public Niveau GetNiveau(int num, string libelle)
        {
            Niveau niveau = new Niveau
            {
                id = num,
                libelle = libelle,
            };
            bool exicte = false;
            if (niveaus.Count > 0)
            {
                foreach (Niveau n in Niveaus)
                {
                    if (n.id == niveau.id)
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
            //string[] date = workSheet.Rows[2][5].ToString().Split('/');
            //return new Annee_Scolaire { annee_Scolaire1= workSheet.Rows[2][5].ToString() ,date_Debut=DateTime.Parse(date[0]),date_Fin = DateTime.Parse(date[1]) };

            string[] annee = workSheet.Rows[2][5].ToString().Split('/');
            var debut = "03/09/" + workSheet.Rows[2][5].ToString().Substring(0, 4);
            var date_Debut = DateTime.Parse(debut, new System.Globalization.CultureInfo("pt-BR"));
            var fin = "30/06/" + workSheet.Rows[2][5].ToString().Substring(5, 4);
            var date_Fin = DateTime.Parse(fin, new System.Globalization.CultureInfo("pt-BR"));
            return new Annee_Scolaire { annee_Scolaire1 = workSheet.Rows[2][5].ToString(), date_Debut = date_Debut, date_Fin = date_Fin };
        }
        public Ecole GetInstitution(DataTable workSheet)
        {
            return new Ecole
            {
                nom = workSheet.Rows[2][3].ToString(),
                academie = workSheet.Rows[0][3].ToString(),
                direction_Provinciale = workSheet.Rows[0][5].ToString(),
            };
        }
    }
}
