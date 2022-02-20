using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace GestionScolaire.Classes
{
    public class ClsEtudiant
    {
       

        private int id_E;
        private string nom_E;
        private string prenom_E;
        private DateTime dateNiassance_E;
        private string sexe_E;
        private int niveauScolaire_E;
        private string adress_E;
        private string telEtudiant_E;
        private string nomPere_E;
        private string metierPere_E;
        private string telPere_E;
        private string nomMere_E;
        private string metierMere_E;
        private string telMere_E;

        public int Id_E { get => id_E; set => id_E = value; }
        public string Nom_E { get => nom_E; set => nom_E = value; }
        public string Prenom_E { get => prenom_E; set => prenom_E = value; }
        public DateTime DateNiassance_E { get => dateNiassance_E; set => dateNiassance_E = value; }
        public string Sexe_E { get => sexe_E; set => sexe_E = value; }
        public int NiveauScolaire_E { get => niveauScolaire_E; set => niveauScolaire_E = value; }
        public string Adress_E { get => adress_E; set => adress_E = value; }
        public string TelEtudiant_E { get => telEtudiant_E; set => telEtudiant_E = value; }
        public string NomPere_E { get => nomPere_E; set => nomPere_E = value; }
        public string MetierPere_E { get => metierPere_E; set => metierPere_E = value; }
        public string TelPere_E { get => telPere_E; set => telPere_E = value; }
        public string NomMere_E { get => nomMere_E; set => nomMere_E = value; }
        public string MetierMere_E { get => metierMere_E; set => metierMere_E = value; }
        public string TelMere_E { get => telMere_E; set => telMere_E = value; }
        //----------------------------------

       


    }
}