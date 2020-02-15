using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSE;

namespace Massar
{
    public class DataAdabter
    {
        private EcoleDBEntities dbEntities;
        bool Arrivals = true;

        public DataAdabter()
        {
            dbEntities = new EcoleDBEntities();
        }
        public DataSet ListEleves()
        {
            Import import = new Import();
            import.OpenFile("ListEleve");
            ListEleve listEleve = new ListEleve(import.WorkBook);
            //
            Update(listEleve.Annee_Scolaire);
            Update(listEleve.Ecole);
            System.Collections.IList list = listEleve.Niveaus;
            for (int i = 0; i < list.Count; i++)
            {
                Niveau n = (Niveau)list[i];
                Update(n);
            }
            System.Collections.IList list1 = listEleve.Classes;
            for (int i = 0; i < list1.Count; i++)
            {
                Classe c = (Classe)list1[i];
                Update(c);
            }
            System.Collections.IList list2 = listEleve.Eleves;
            for (int i = 0; i < list2.Count; i++)
            {
                Eleve e = (Eleve)list2[i];
                Update(e);
            }
            System.Windows.Forms.MessageBox.Show(listEleve.Eleves.Count.ToString());
            System.Collections.IList list3 = listEleve.Classe_Details;
            for (int i = 0; i < list3.Count; i++)
            {
                Classe_Details cD = (Classe_Details)list3[i];
                Update(cD);
            }
            
            return listEleve.WorkBook;
        }
        public DataSet InfoEleve()
        {
            Import import = new Import();
            import.OpenFolder("InfoEleve");
            InfoEleve eleve = new InfoEleve(import.WorkBook);
            //
            Update(eleve.Annee_Scolaire);
            Update(eleve.Ecole);
            System.Collections.IList list = eleve.Classes;
            for (int i = 0; i < list.Count; i++)
            {
                Classe c = (Classe)list[i];
                Update(c);
            }
            System.Collections.IList list1 = eleve.Eleves;
            for (int i = 0; i < list1.Count; i++)
            {
                Eleve e = (Eleve)list1[i];
                Update(e);
            }

            return eleve.WorkBook;
        }
        public DataSet Tuteur()
        {
            Import import = new Import();
            import.OpenFolder("Tuteur");
            Tuteurs tuteur = new Tuteurs(import.WorkBook);
            //
            Update(tuteur.Annee_Scolaire);
            Update(tuteur.Ecole);
            System.Collections.IList list = tuteur.Niveaus;
            for (int i = 0; i < list.Count; i++)
            {
                Niveau n = (Niveau)list[i];
                Update(n);
            }
            System.Collections.IList list1 = tuteur.Classes;
            for (int i = 0; i < list1.Count; i++)
            {
                Classe c = (Classe)list1[i];
                Update(c);
            }
            System.Collections.IList list2 = tuteur.Eleves;
            for (int i = 0; i < list2.Count; i++)
            {
                Eleve e = (Eleve)list2[i];
                Update(e);
            }

            return tuteur.WorkBook;
        }
        public DataSet MoyenneCc()
        {
            Import import = new Import();
            import.OpenFolder("MoyenneCc");
            MoyenneCc moyenne = new MoyenneCc(import.WorkBook);
            //
            Update(moyenne.Annee_Scolaire);
            Update(moyenne.Ecole);
            System.Collections.IList list = moyenne.Matieres;
            for (int i = 0; i < list.Count; i++)
            {
                Matiere m = (Matiere)list[i];
                Update(m);
            }
            System.Collections.IList list1 = moyenne.Niveaus;
            for (int i = 0; i < list1.Count; i++)
            {
                Niveau n = (Niveau)list1[i];
                Update(n);
            }
            System.Collections.IList list2 = moyenne.Classes;
            for (int i = 0; i < list2.Count; i++)
            {
                Classe c = (Classe)list2[i];
                Update(c);
            }
            System.Collections.IList list3 = moyenne.Eleves;
            for (int i = 0; i < list3.Count; i++)
            {
                Eleve e = (Eleve)list3[i];
                Update(e);
            }

            return moyenne.WorkBook;
        }
        public DataSet NoteExam()
        {
            Import import = new Import();
            import.OpenFile("MoyenneCc");
            NoteExam note = new NoteExam(import.WorkBook);
            //
            Update(note.Annee_Scolaire);
            Update(note.Ecole);
            System.Collections.IList list = note.Matieres;
            for (int i = 0; i < list.Count; i++)
            {
                Matiere m = (Matiere)list[i];
                Update(m);
            }
            System.Collections.IList list1 = note.Niveaus;
            for (int i = 0; i < list1.Count; i++)
            {
                Niveau n = (Niveau)list1[i];
                Update(n);
            }
            System.Collections.IList list2 = note.Classes;
            for (int i = 0; i < list2.Count; i++)
            {
                Classe c = (Classe)list2[i];
                Update(c);
            }
            System.Collections.IList list3 = note.Eleves;
            for (int i = 0; i < list3.Count; i++)
            {
                Eleve e = (Eleve)list3[i];
                Update(e);
            }

            return note.WorkBook;
        }
        public void Update()
        {
            //
        }
        private void Update(Ecole institution)
        {
            Ecole i = dbEntities.Ecoles.FirstOrDefault(x => x.nom == institution.nom);
            if (i is null)
            {
                dbEntities.Ecoles.Add(institution);
            }
            else
            {
                if(institution.nom != null)
                    i.nom = institution.nom;
                if (institution.academie != null)
                    i.academie = institution.academie;
                if (institution.direction_Provinciale != null)
                    i.direction_Provinciale = institution.direction_Provinciale;
                if (institution.ministere != null)
                    i.ministere = institution.ministere;
                if (institution.commoune != null)
                    i.commoune = institution.commoune;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Annee_Scolaire annee_Scolaire)
        {
            Annee_Scolaire annee = dbEntities.Annee_Scolaire.FirstOrDefault(x => x.annee_Scolaire1 == annee_Scolaire.annee_Scolaire1);
            if (annee is null)
            {
                dbEntities.Annee_Scolaire.Add(annee_Scolaire);
                Arrivals = false;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Eleve eleve)
        {
            Eleve e = dbEntities.Eleves.FirstOrDefault(x =>  x.id == eleve.id );

            if (e is null)
            {
                dbEntities.Eleves.Add(eleve);
            }
            else
            {
                if(eleve.nom_Ar != null)
                    e.nom_Ar = eleve.nom_Ar;
                if (eleve.prenom_Ar != null)
                    e.prenom_Ar = eleve.prenom_Ar;
                if (eleve.date_Naissance != null)
                    e.date_Naissance = eleve.date_Naissance;
                if (eleve.lieu_Naissance_Ar != null)
                    e.lieu_Naissance_Ar = eleve.lieu_Naissance_Ar;
                if (eleve.sexe != null)
                    e.sexe = eleve.sexe;
                if (eleve.password != null)
                    e.password = eleve.password;
                if (eleve.type_Tuteur != null)
                    e.type_Tuteur = eleve.type_Tuteur;
                if (eleve.tuteur != null)
                    e.tuteur = eleve.tuteur;
                if (eleve.pere != null)
                    e.pere = eleve.pere;
                if (eleve.mere != null)
                    e.mere = eleve.mere;
                if (!Arrivals) // there is a problem
                    e.registred = false;
                else
                    e.status = "وافد";
               
            }
            dbEntities.SaveChanges();
        }
        private void Update(Classe classe)
        {
            Classe c = dbEntities.Classes.FirstOrDefault(x => x.id == classe.id);

            if (c is null)
            {
                dbEntities.Classes.Add(classe);
            }
            else
            {
                if(classe.surnom != null)
                    c.surnom = classe.surnom;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Niveau niveau)
        {
            Niveau n = dbEntities.Niveaux.FirstOrDefault(x => x.id == niveau.id);

            if (n is null)
            {
                dbEntities.Niveaux.Add(niveau);
            }
            dbEntities.SaveChanges();
        }
        private void Update(Classe_Details classe_Details)
        {
            Classe_Details cD = dbEntities.Classe_Details.FirstOrDefault(x => x.annee == classe_Details.annee && x.classe == classe_Details.classe && x.eleve == classe_Details.eleve);
            
            if (cD is null)
            {
                Classe_Details ancienne_Classe = dbEntities.Classe_Details.FirstOrDefault(x => x.annee == classe_Details.annee && x.eleve == classe_Details.eleve);
                if (ancienne_Classe != null)
                {
                    Ancienne_Classe classe = new Ancienne_Classe { id = ancienne_Classe.classe };
                    dbEntities.Ancienne_Classe.Add(classe);
                    classe_Details.ancienne = ancienne_Classe.classe;
                }
                dbEntities.Classe_Details.Add(classe_Details);
            }
            dbEntities.SaveChanges();
        }
        private void Update(Pere parent)
        {
            Pere p = dbEntities.Peres.FirstOrDefault(x => x.cin == parent.cin);

            if (p is null)
            {
                dbEntities.Peres.Add(parent);
            }
            else
            {
                if(parent.nom_Ar != null)
                    p.nom_Ar = parent.nom_Ar;
                if (parent.nom_Fr != null)
                    p.nom_Fr = parent.nom_Fr;
                if (parent.prenom_Ar != null)
                    p.prenom_Ar = parent.prenom_Ar;
                if (parent.prenom_Fr != null)
                    p.prenom_Fr = parent.prenom_Fr;
                if (parent.metier != null)
                    p.metier = parent.metier;
                if (parent.tele != null)
                    p.tele = parent.tele;
                if (parent.adresse != null)
                    p.adresse = parent.adresse;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Mere parent)
        {
            Mere p = dbEntities.Meres.FirstOrDefault(x => x.cin == parent.cin);

            if (p is null)
            {
                dbEntities.Meres.Add(parent);
            }
            else
            {
                if (parent.nom_Ar != null)
                    p.nom_Ar = parent.nom_Ar;
                if (parent.nom_Fr != null)
                    p.nom_Fr = parent.nom_Fr;
                if (parent.prenom_Ar != null)
                    p.prenom_Ar = parent.prenom_Ar;
                if (parent.prenom_Fr != null)
                    p.prenom_Fr = parent.prenom_Fr;
                if (parent.metier != null)
                    p.metier = parent.metier;
                if (parent.tele != null)
                    p.tele = parent.tele;
                if (parent.adresse != null)
                    p.adresse = parent.adresse;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Tuteur parent)
        {
            Tuteur p = dbEntities.Tuteurs.FirstOrDefault(x => x.cin == parent.cin);

            if (p is null)
            {
                dbEntities.Tuteurs.Add(parent);
            }
            else
            {
                if (parent.nom_Ar != null)
                    p.nom_Ar = parent.nom_Ar;
                if (parent.nom_Fr != null)
                    p.nom_Fr = parent.nom_Fr;
                if (parent.prenom_Ar != null)
                    p.prenom_Ar = parent.prenom_Ar;
                if (parent.prenom_Fr != null)
                    p.prenom_Fr = parent.prenom_Fr;
                if (parent.metier != null)
                    p.metier = parent.metier;
                if (parent.tele != null)
                    p.tele = parent.tele;
                if (parent.adresse != null)
                    p.adresse = parent.adresse;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Professeur professeur)
        {
            Professeur p = dbEntities.Professeurs.FirstOrDefault(x => x.cin == professeur.cin);

            if (p is null)
            {
                dbEntities.Professeurs.Add(professeur);
            }
            else
            {
                if(professeur.num_Somme != null)
                    p.num_Somme = professeur.num_Somme;
                if (professeur.nom_Ar != null)
                    p.nom_Ar = professeur.nom_Ar;
                if (professeur.nom_Fr != null)
                    p.nom_Fr = professeur.nom_Fr;
                if (professeur.prenom_Ar != null)
                    p.prenom_Ar = professeur.prenom_Ar;
                if (professeur.prenom_Fr != null)
                    p.prenom_Fr = professeur.prenom_Fr;
                if (professeur.specialite != null)
                    p.specialite = professeur.specialite;
                if (professeur.tele != null)
                    p.tele = professeur.tele;
                if (professeur.adresse != null)
                    p.adresse = professeur.adresse;
            }
            dbEntities.SaveChanges();
        }
        private void Update(Matiere matiere)
        {
            Matiere m = dbEntities.Matieres.FirstOrDefault(x => x.nom_1 == matiere.nom_1);

            if (m is null)
            {
                dbEntities.Matieres.Add(matiere);
            }
            dbEntities.SaveChanges();
        }
        private void Update(Semestre semestre)
        {
            Semestre s = dbEntities.Semestres.FirstOrDefault(x => x.id == semestre.id);

            if (s is null)
            {
                dbEntities.Semestres.Add(semestre);
            }
            else
            {
                if(semestre.libelle != null)
                    s.libelle = semestre.libelle;
            }
            dbEntities.SaveChanges();
        }

        //public 
    }
}
