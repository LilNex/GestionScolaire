//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionScolaire
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professeur
    {
        public int id_P { get; set; }
        public string Nom_P { get; set; }
        public string Prenom_P { get; set; }
        public Nullable<System.DateTime> Datenaissance_P { get; set; }
        public Nullable<int> NiveauScolaire_P { get; set; }
        public string Adresse_P { get; set; }
        public string Tel_P { get; set; }
    }
}