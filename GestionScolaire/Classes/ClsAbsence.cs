using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsAbsence
    {
        private int id_A;
        private DateTime date_A;
        private Boolean justifie_A;
        private int id_E;
        private int idC;

        public int Id_A { get => id_A; set => id_A = value; }
        public DateTime Date_A { get => date_A; set => date_A = value; }
        public bool Justifie_A { get => justifie_A; set => justifie_A = value; }
        public int IdE { get => id_E; set => id_E = value; }
        public int IdC { get => idC; set => idC = value; }
    }
}