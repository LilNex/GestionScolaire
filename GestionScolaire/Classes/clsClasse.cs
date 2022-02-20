using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class clsClasse
    {
        private int numeroC;
        private int etageC;
        private int superficieC;
        private Boolean salle_informatiqueC;
        private Boolean laboC;
        private Boolean travaux_PratiqueC;
        private Boolean bibliotheque;
     

        public int NumeroC { get => numeroC; set => numeroC = value; }
        public int EtageC { get => etageC; set => etageC = value; }
        public int SuperficieC { get => superficieC; set => superficieC = value; }
        public bool Salle_informatiqueC { get => salle_informatiqueC; set => salle_informatiqueC = value; }
        public bool LaboC { get => laboC; set => laboC = value; }
        public bool Travaux_PratiqueC { get => travaux_PratiqueC; set => travaux_PratiqueC = value; }
        public bool Bibliotheque { get => bibliotheque; set => bibliotheque = value; }
    }
}
