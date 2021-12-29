using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsNote
    {
        private int idN;
        private int idM;
        private int idE;
        private int numControleN;
        private int moyenneN;

        public int IdN { get => idN; set => idN = value; }
        public int IdM { get => idM; set => idM = value; }
        public int IdE { get => idE; set => idE = value; }
        public int NumControleN { get => numControleN; set => numControleN = value; }
        public int MoyenneN { get => moyenneN; set => moyenneN = value; }
    }
}