using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsAvertissement
    {
        private int idA;
        private int idE;
        private string motifA;
        private int severiteA;

        public int IdA { get => idA; set => idA = value; }
        public int IdE { get => idE; set => idE = value; }
        public string MotifA { get => motifA; set => motifA = value; }
        public int SeveriteA { get => severiteA; set => severiteA = value; }
    }
}