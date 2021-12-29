using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsPaiement
    {
        private int id_P;
        private int idE;
        private int mois_P;
        private int annee_P;
        private DateTime datePaiement_D;

        public int Id_P { get => id_P; set => id_P = value; }
        public int IdE { get => idE; set => idE = value; }
        public int Mois_P { get => mois_P; set => mois_P = value; }
        public int Annee_P { get => annee_P; set => annee_P = value; }
        public DateTime DatePaiement_D { get => datePaiement_D; set => datePaiement_D = value; }
    }
}