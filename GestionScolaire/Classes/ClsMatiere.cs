using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsMatiere
    {
        private int idM;
        private string nomM;
        private int id_P;
        private int numSalleM;

        public int IdM { get => idM; set => idM = value; }
        public string NomM { get => nomM; set => nomM = value; }
        public int Id_P { get => id_P; set => id_P = value; }
        public int NumSalleM { get => numSalleM; set => numSalleM = value; }
    }
}