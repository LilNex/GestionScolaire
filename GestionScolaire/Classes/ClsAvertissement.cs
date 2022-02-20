using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsAvertissement
    {
        private int idA;
        private int id_E;
        private string motifA;
        private int severiteA;

        public int IdA { get => idA; set => idA = value; }
        public int IdE { get => id_E; set => id_E = value; }
        public string MotifA { get => motifA; set => motifA = value; }
        public int SeveriteA { get => severiteA; set => severiteA = value; }
    }
}