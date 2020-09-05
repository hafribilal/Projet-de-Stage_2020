using GSE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massar
{
    internal class NoteExam
    {
        private DataSet workBook;
        private Ecole ecole;
        private Annee_Scolaire annee_Scolaire;
        private Semestre semestre;
        private List<Niveau> niveaus;
        private List<Classe> classes;
        private List<Eleve> eleves;
        private List<Matiere> matieres;
        private List<Note> notes;
        private List<Note_Details> note_Details;
        public NoteExam()
        {
            workBook = new DataSet();
        }
        public NoteExam(DataSet workBook)
        {
            niveaus = new List<Niveau>();
            classes = new List<Classe>();
            eleves = new List<Eleve>();
            semestre = new Semestre();
            matieres = new List<Matiere>();
            note_Details = new List<Note_Details>();
            notes = new List<Note>();
            this.workBook = new DataSet();
            eleves = GetEleves(workBook);
        }
        public DataSet WorkBook { get => workBook; set => workBook = value; }
        public Ecole Ecole { get => ecole; set => ecole = value; }
        public Annee_Scolaire Annee_Scolaire { get => annee_Scolaire; set => annee_Scolaire = value; }
        public List<Niveau> Niveaus { get => niveaus; set => niveaus = value; }
        public List<Classe> Classes { get => classes; set => classes = value; }
        public List<Eleve> Eleves { get => eleves; set => eleves = value; }
        public List<Matiere> Matieres { get => matieres; set => matieres = value; }
        public Semestre Semestre { get => semestre; set => semestre = value; }
        public List<Note> Notes { get => notes; set => notes = value; }
        public List<Note_Details> Note_Details { get => note_Details; set => note_Details = value; }

        public DataSet GetData(DataTable workSheet)
        {
            string className = workSheet.Rows[5][10].ToString();
            DataSet List = new DataSet();
            DataTable eleves = new DataTable(className);
            DataTable notes = new DataTable("Notes");
            int[] ListColumns = { 24, 23, 21 };
            DataRow row = workSheet.Rows[8];
            foreach (int i in ListColumns)
            {
                eleves.Columns.Add(row[i].ToString());
            }
            int[] NotesColumns = { 20, 19, 17, 16, 15, 14, 12, 11, 9, 8 };
            foreach (int i in NotesColumns)
            {
                notes.Columns.Add(row[i].ToString());
            }
            for (int i = 9; i < workSheet.Rows.Count; i++)
            {
                row = workSheet.Rows[i];
                if (row[23] != null)
                {
                    DataRow rList = eleves.NewRow();
                    for (int j = 0; j < ListColumns.Length; j++)
                    {
                        rList[j] = row[ListColumns[j]].ToString();
                    }
                    eleves.Rows.Add(rList);
                    DataRow rNote = notes.NewRow();
                    for (int j = 0; j < NotesColumns.Length; j++)
                    {
                        string val = row[NotesColumns[j]].ToString();
                        if (val is null)
                        {
                            val = "0";
                        }
                        rNote[j] = val;
                    }
                    notes.Rows.Add(rNote);
                }
            }
            List.Tables.Add(eleves);
            List.Tables.Add(notes);
            return List;
        }

        private Eleve GetEleve(DataRow row)
        {
            return new Eleve
            {
                num = int.Parse(row[0].ToString()),
                id = row[1].ToString()
            };
        }
        public List<Eleve> GetEleves(DataTable workSheet)
        {
            List<Eleve> eleves = new List<Eleve>();
            Classe classe = GetClasse(workSheet);
            classes.Add(classe);
            DataSet set = GetData(workSheet);
            DataTable info = set.Tables[classe.id];
            DataTable not = set.Tables[1];
            for (int i = 0; i < not.Columns.Count - 1; i++)
            {
                Matiere m = new Matiere { nom_1 = not.Columns[i].ColumnName };
                bool exist = false;
                foreach (Matiere ma in matieres)
                {
                    if (ma.nom_1 == m.nom_1)
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    matieres.Add(m);
                }
            }
            for (int i = 0; i < info.Rows.Count; i++)
            {
                Note_Details _Details;
                Note note = new Note();
                DataRow row = info.Rows[i];
                Eleve eleve = GetEleve(row);
                note.eleve = eleve.id;
                note.annee = annee_Scolaire.annee_Scolaire1;
                note.semester = semestre.id;
                
                row = not.Rows[i];
                try
                {
                    note.note_Exame = Double.Parse(row[row.Table.Columns.Count - 1].ToString());
                }
                catch (Exception)
                {

                }
                for (int j = 0; j < not.Columns.Count - 1; j++)
                {
                    _Details = new Note_Details();
                    _Details.semestere = note.semester;
                    _Details.annee = note.annee;
                    _Details.matiere = matieres[j].nom_1;
                    try
                    {
                        _Details.note_Exame = double.Parse(row[j].ToString().Replace(',', '.'));
                    }
                    catch (Exception)
                    {

                    }
                    Note_Details.Add(_Details);
                }
                Notes.Add(note);
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

            Niveau n = GetNiveau(int.Parse(workSheet.Rows[5][10].ToString().Substring(0, 1)), workSheet.Rows[5][18].ToString());
            return new Classe
            {
                id = workSheet.Rows[5][10].ToString(),
                surnom = workSheet.Rows[5][18].ToString(),
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
            //string[] date = workSheet.Rows[1][10].ToString().Split('/');
            //return new Annee_Scolaire { annee_Scolaire1 = workSheet.Rows[1][10].ToString(), date_Debut = DateTime.Parse(date[0]), date_Fin = DateTime.Parse(date[1]) };

            string[] annee = workSheet.Rows[1][10].ToString().Split('/');
            var debut = "03/09/" + workSheet.Rows[1][10].ToString().Substring(0, 4);
            var date_Debut = DateTime.Parse(debut, new System.Globalization.CultureInfo("pt-BR"));
            var fin = "30/06/" + workSheet.Rows[1][10].ToString().Substring(5, 4);
            var date_Fin = DateTime.Parse(fin, new System.Globalization.CultureInfo("pt-BR"));
            return new Annee_Scolaire { annee_Scolaire1 = workSheet.Rows[1][10].ToString(), date_Debut = date_Debut, date_Fin = date_Fin };
        }
        public Ecole GetInstitution(DataTable workSheet)
        {
            return new Ecole
            {
                nom = workSheet.Rows[4][18].ToString(),
                academie = workSheet.Rows[2][18].ToString(),
                direction_Provinciale = workSheet.Rows[3][18].ToString(),
                ministere = workSheet.Rows[0][18].ToString()
            };
        }
    }
}
