using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsProfesseur
    {
        private int idP;
        private string nomP;
        private string prenomP;
        private DateTime date_NaissanceF;
        private string niveau_ScolaireF;
        private string telF;

        public int IdP { get => idP; set => idP = value; }
        public string NomP { get => nomP; set => nomP = value; }
        public string PrenomP { get => prenomP; set => prenomP = value; }
        public DateTime Date_NaissanceF { get => date_NaissanceF; set => date_NaissanceF = value; }
        public string Niveau_ScolaireF { get => niveau_ScolaireF; set => niveau_ScolaireF = value; }
        public string TelF { get => telF; set => telF = value; }
    }
}