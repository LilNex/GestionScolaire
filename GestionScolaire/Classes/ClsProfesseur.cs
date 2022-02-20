using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsProfesseur
    {
        private int id_P;
        private string nom_P;
        private string prenom_P;
        private DateTime date_Naissance_P;
        private string niveau_Scolaire_P;
        private string adresse_P;
        private string tel_P;

        public int Id_P { get => id_P; set => id_P = value; }
        public string Nom_P { get => nom_P; set => nom_P = value; }
        public string Prenom_P { get => prenom_P; set => prenom_P = value; }
        public DateTime Date_Naissance_P { get => date_Naissance_P; set => date_Naissance_P = value; }
        public string Niveau_Scolaire_P { get => niveau_Scolaire_P; set => niveau_Scolaire_P = value; }
        public string Adresse_P { get => adresse_P; set => adresse_P = value; }
        public string Tel_P { get => tel_P; set => tel_P = value; }
    }
}