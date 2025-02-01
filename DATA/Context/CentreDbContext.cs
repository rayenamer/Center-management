using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using System.Numerics;

namespace DATA.Context
{
    public class CentreDbContext : DbContext
    {

        public CentreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Batiment> Batiments  { get; set; }
        public DbSet<Centre> Centres  { get; set; }
        public DbSet<Affectation> Affectations  { get; set; }
        public DbSet<Mise_En_Place_Sous_Lots> Mise_En_Place_Sous_Lots   { get; set; }
        public DbSet<Souche> Souches { get; set; }
        public DbSet<Lot> Lots{ get; set; }
        public DbSet<Rotation> Rotations  { get; set; }
        public DbSet<Spéculation> Spéculations  { get; set; }
        public DbSet<Antenne> Antennes { get; set; }
        public DbSet<Objectif> Objectifs { get; set; }
        public DbSet<Parentaux> Parentaux  { get; set; }
        public DbSet<Rapport_Final> Rapport_Finals  { get; set; }
        public DbSet<TypeMise_En_Place> TypeMise_En_Places { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Batiment>().HasKey(i => i.Id_batiment);
           modelBuilder.Entity<Antenne>().HasKey(i => i.IdAntenne);
           modelBuilder.Entity<Centre>().HasKey(i => i.IdCentre);
           modelBuilder.Entity<Lot>().HasKey(i => i.Idlot);
           modelBuilder.Entity<Souche>().HasKey(i => i.IdSouche);
           modelBuilder.Entity<Rotation>().HasKey(i => i.IdRotation);
            modelBuilder.Entity<Spéculation>().HasKey(i => i.IdSpéculation);
            modelBuilder.Entity<Affectation>().HasKey(i => i.Idaffectation);
            modelBuilder.Entity<Mise_En_Place_Sous_Lots>().HasKey(i => i.IdMise_En_Place_Sous_Lots);
            modelBuilder.Entity<Objectif>().HasKey(i => i.IdObjectif);
            modelBuilder.Entity<Parentaux>().HasKey(i => i.Code_parent);
            modelBuilder.Entity<Rapport_Final>().HasKey(i => i.IdRapport_final);
            modelBuilder.Entity<TypeMise_En_Place>().HasKey(i => i.IdTypeMise_En_Place);
            modelBuilder.Entity<Antenne_Spéculation>().HasKey(i => i.idAntenne_Spéculation);
            modelBuilder.Entity<Chef_Centre>().HasKey(i => i.Idchef_centre);
            modelBuilder.Entity<Controlleur>().HasKey(i => i.IdControlleur);
            modelBuilder.Entity<Couvoir>().HasKey(i => i.IdCouvoir);
            modelBuilder.Entity<Situation_Journalier_Centre>().HasKey(i => i.IdSituation_Journalier_Centre);

            modelBuilder.Entity<Rotation>()
               .HasOne(e => e.Centre)
               .WithMany(e => e.Rotation)
               .HasForeignKey(e => e.FkCentre);


            modelBuilder.Entity<Parentaux>()
          .HasOne(e => e.Couvoir)
          .WithMany(e => e.Parentaux)
          .HasForeignKey(e => e.FkCouvoir);
          

            modelBuilder.Entity<Parentaux>()
         .HasOne(e => e.Lot)
         .WithMany(e => e.Parentaux)
         .HasForeignKey(e => e.FkLot)
         ;

            modelBuilder.Entity<Parentaux>()
            .HasOne(e => e.Batiment)
            .WithMany(e => e.Parentaux)
            .HasForeignKey(e => e.FkBatiment)
            ;
            modelBuilder.Entity<Rotation>()
              .HasOne(e => e.Spéculation)
              .WithMany(e => e.Rotation)
              .HasForeignKey(e => e.FkSpéculation)
         ;
            modelBuilder.Entity<Batiment>()
              .HasOne(e => e.Centre)
              .WithMany(e => e.Batiment)
              .HasForeignKey(e => e.FkCentre)
             ;
            modelBuilder.Entity<Lot>()
              .HasOne(e => e.Souche)
              .WithMany(e => e.Lots)
              .HasForeignKey(e => e.FkSouche)
            .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Affectation>()
             .HasOne(e => e.Centre)
             .WithOne(e => e.Affectation)
             .HasForeignKey<Affectation>(e => e.Fkcentre)
             ;









        }
    }
}
