using GSE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massar
{
    internal class Tuteurs
    {
        private DataSet workBook;
        private Ecole ecole;
        private Annee_Scolaire annee_Scolaire;
        private List<Niveau> niveaus;
        private List<Classe> classes;
        private List<Eleve> eleves;
        private Pere pere;
        private Mere mere;
        private Tuteur tuteur;
        public Tuteurs()
        {
            workBook = new DataSet();
        }
        public Tuteurs(DataSet workBook)
        {
            niveaus = new List<Niveau>();
            classes = new List<Classe>();
            eleves = new List<Eleve>();
            this.workBook = new DataSet();
            eleves = GetEleves(workBook);
        }
        public DataSet WorkBook { get => workBook; set => workBook = value; }
        public Ecole Ecole { get => ecole; set => ecole = value; }
        public Annee_Scolaire Annee_Scolaire { get => annee_Scolaire; set => annee_Scolaire = value; }
        public List<Niveau> Niveaus { get => niveaus; set => niveaus = value; }
        public List<Classe> Classes { get => classes; set => classes = value; }
        public List<Eleve> Eleves { get => eleves; set => eleves = value; }
        public Pere Pere { get => pere; set => pere = value; }
        public Mere Mere { get => mere; set => mere = value; }
        public Tuteur LeTuteur { get => tuteur; set => tuteur = value; }

        public DataSet GetData(DataTable workSheet)
        {
            string className = workSheet.Rows[4][6].ToString();
            DataSet List = new DataSet(className);
            DataTable eleves = new DataTable("eleves");
            DataTable peres = new DataTable("peres");
            DataTable meres = new DataTable("meres");
            DataTable tuteurs = new DataTable("tuteurs");
            //int[] studentsColumns = { 1, 2, 3, 4, 5 };
            DataRow row = workSheet.Rows[8];
            for (int i = 0; i < 4; i++)
            {
                eleves.Columns.Add(workSheet.Rows[6][i+2].ToString());
            }
            for (int i = 0; i < 8; i++)
            {
                string column = workSheet.Rows[7][i + 14].ToString();
                
                tuteurs.Columns.Add(column+"-t");
                peres.Columns.Add(column+"-p");
                meres.Columns.Add(column+"-m");
            }
            for (int i = 9; i < workSheet.Rows.Count; i++)
            {
                int R = 2;
                row = workSheet.Rows[i];
                if (row[1] != null)
                {
                    DataRow rEleve = eleves.NewRow();
                    DataRow rTuteur = tuteurs.NewRow();
                    DataRow rPere = peres.NewRow();
                    DataRow rMere = meres.NewRow();

                    for (int j = 0; j < 4; j++)
                    {
                        rEleve[j] = row[R++].ToString();
                        //System.Windows.Forms.MessageBox.Show(rEleve[j].ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            if (j==0)
                            {
                                rTuteur[k]= row[R++].ToString();
                                //System.Windows.Forms.MessageBox.Show(rTuteur[k].ToString());
                            }
                            else if(j==1)
                            {
                                rPere[k]= row[R++].ToString();
                                //System.Windows.Forms.MessageBox.Show(rPere[k].ToString());
                            }
                            else if (j==2)
                            {
                                rMere[k]= row[R++].ToString();
                                //System.Windows.Forms.MessageBox.Show(rMere[k].ToString());
                            }
                        }
                    }
                    eleves.Rows.Add(rEleve);
                    tuteurs.Rows.Add(rTuteur);
                    peres.Rows.Add(rPere);
                    meres.Rows.Add(rMere);
                }
            }
            List.Tables.Add(eleves);
            List.Tables.Add(tuteurs);
            List.Tables.Add(peres);
            List.Tables.Add(meres);
            
            return List;
        }
        private Eleve GetEleve(DataRow row)
        {
            return new Eleve
            {
                id = row[0].ToString(),
                nom_Ar = row[1].ToString(),
                prenom_Ar = row[2].ToString(),
                type_Tuteur = row[3].ToString(),
            };
        }
        private Pere GetPere(DataRow row)
        {
            Pere parent = new Pere();
            
            if (row[0].ToString() is null)
            {
                return parent;
            }
            else
            {
                parent.cin = row[0].ToString();
                parent.prenom_Ar = row[1].ToString();
                parent.nom_Ar = row[2].ToString();
                parent.prenom_Fr = row[3].ToString();
                parent.nom_Fr = row[4].ToString();
                parent.metier = row[5].ToString();
                parent.tele = row[6].ToString();
                parent.adresse = row[7].ToString();
            }
            return parent;
        }
        private Mere GetMere(DataRow row)
        {
            Mere parent = new Mere();

            if (row[0].ToString() is null)
            {
                return parent;
            }
            else
            {
                parent.cin = row[0].ToString();
                parent.prenom_Ar = row[1].ToString();
                parent.nom_Ar = row[2].ToString();
                parent.prenom_Fr = row[3].ToString();
                parent.nom_Fr = row[4].ToString();
                parent.metier = row[5].ToString();
                parent.tele = row[6].ToString();
                parent.adresse = row[7].ToString();
            }
            return parent;
        }
        private Tuteur GetTuteur(DataRow row)
        {
            Tuteur parent = new Tuteur();

            if (row[0].ToString() is null)
            {
                return parent;
            }
            else
            {
                parent.cin = row[0].ToString();
                parent.prenom_Ar = row[1].ToString();
                parent.nom_Ar = row[2].ToString();
                parent.prenom_Fr = row[3].ToString();
                parent.nom_Fr = row[4].ToString();
                parent.metier = row[5].ToString();
                parent.tele = row[6].ToString();
                parent.adresse = row[7].ToString();
            }
            return parent;
        }
        public List<Eleve> GetEleves(DataTable workSheet)
        {
            List<Eleve> eleves = new List<Eleve>();
            Classe classe = GetClasse(workSheet);
            classes.Add(classe);
            DataSet set = GetData(workSheet);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                Eleve eleve = GetEleve(set.Tables["eleves"].Rows[i]);
                pere = GetPere(set.Tables["peres"].Rows[i]);
                eleve.pere = pere.cin;
                mere = GetMere(set.Tables["meres"].Rows[i]);
                eleve.mere = mere.cin;
                tuteur = GetTuteur(set.Tables["peres"].Rows[i]);
                eleve.tuteur = tuteur.cin;
                eleves.Add(eleve);
            }

            DataTable dataList = new DataTable();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    DataColumn column = set.Tables[i].Columns[0];
                    set.Tables[i].Columns.Remove(column);
                    dataList.Columns.Add(column);
                }
            }
            dataList.TableName = classe.id;
            workBook.Tables.Add(dataList);
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
            Niveau n = GetNiveau(int.Parse(workSheet.Rows[4][6].ToString().Substring(0, 1)), workSheet.Rows[4][3].ToString());
            return new Classe
            {
                id = workSheet.Rows[4][6].ToString(),
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
                    if (n.Equals(niveau))
                    {
                        exicte = true;
                    }
                }
            }
            if (exicte)
            {
                Niveaus.Add(niveau);
            }
            return niveau;
        }
        public Annee_Scolaire GetAnnee(DataTable workSheet)
        {
            string[] date = workSheet.Rows[3][6].ToString().Split('/');
            //.Windows.Forms.MessageBox.Show(workSheet.Rows[3][6].ToString());
            return new Annee_Scolaire { annee_Scolaire1= workSheet.Rows[3][6].ToString() ,date_Debut=DateTime.Parse(date[0]), date_Fin=DateTime.Parse(date[1])};
        }
        public Ecole GetInstitution(DataTable workSheet)
        {
            return new Ecole
            {
                nom = workSheet.Rows[3][3].ToString(),
                academie = workSheet.Rows[3][2].ToString(),
                direction_Provinciale = workSheet.Rows[3][6].ToString(),
            };
        }
    }
}
