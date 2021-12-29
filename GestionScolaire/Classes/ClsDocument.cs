using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionScolaire.Classes
{
    public class ClsDocument
    {
        private int id_D;
        private string nom_D;
        private string chemin_D;
        private DateTime dateDepot_d;

        public int Id_D { get => id_D; set => id_D = value; }
        public string Nom_D { get => nom_D; set => nom_D = value; }
        public string Chemin_D { get => chemin_D; set => chemin_D = value; }
        public DateTime DateDepot_d { get => dateDepot_d; set => dateDepot_d = value; }
    }
}