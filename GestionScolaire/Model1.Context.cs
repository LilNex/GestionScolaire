﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionScolaire
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_a7e750_dbtestEntities1 : DbContext
    {
        public db_a7e750_dbtestEntities1()
            : base("name=db_a7e750_dbtestEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avertissement> Avertissements { get; set; }
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<commande> commandes { get; set; }
        public virtual DbSet<detail> details { get; set; }
        public virtual DbSet<Etudiant> Etudiants { get; set; }
        public virtual DbSet<Matiere> Matieres { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<produit> produits { get; set; }
        public virtual DbSet<Professeur> Professeurs { get; set; }
    }
}