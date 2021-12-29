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
        private int idP;
        private int numSalle;

        public int IdM { get => idM; set => idM = value; }
        public string NomM { get => nomM; set => nomM = value; }
        public int NumSalle { get => numSalle; set => numSalle = value; }
        public int IdP { get => idP; set => idP = value; }
    }
}