using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsPaiement
    {
        private int id_Pa;
        private int id_E;
        private int mois_Pa;
        private int annee_Pa;
        private DateTime datePaiement_Pa;

        public int Id_P { get => id_Pa; set => id_Pa = value; }
        public int IdE { get => id_E; set => id_E = value; }
        public int Mois_P { get => mois_Pa; set => mois_Pa = value; }
        public int Annee_P { get => annee_Pa; set => annee_Pa = value; }
        public DateTime DatePaiement_D { get => datePaiement_Pa; set => datePaiement_Pa = value; }
    }
}