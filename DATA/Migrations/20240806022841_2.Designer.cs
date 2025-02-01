﻿// <auto-generated />
using System;
using DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATA.Migrations
{
    [DbContext(typeof(CentreDbContext))]
    [Migration("20240806022841_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Affectation", b =>
                {
                    b.Property<Guid>("Idaffectation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Chef_CentreIdchef_centre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ControlleurIdControlleur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkControlleur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Fkcentre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Fkchef_centre")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Idaffectation");

                    b.HasIndex("Chef_CentreIdchef_centre");

                    b.HasIndex("ControlleurIdControlleur");

                    b.HasIndex("Fkcentre")
                        .IsUnique();

                    b.ToTable("Affectations");
                });

            modelBuilder.Entity("Domain.Models.Antenne", b =>
                {
                    b.Property<Guid>("IdAntenne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresse_Antenne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code_Antenne")
                        .HasColumnType("int");

                    b.Property<string>("Fax_Antenne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libellé_Antenne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel_Antenne")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAntenne");

                    b.ToTable("Antennes");
                });

            modelBuilder.Entity("Domain.Models.Antenne_Spéculation", b =>
                {
                    b.Property<Guid>("idAntenne_Spéculation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AntenneIdAntenne")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkAntenne")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SpéculationIdSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("idAntenne_Spéculation");

                    b.HasIndex("AntenneIdAntenne");

                    b.HasIndex("SpéculationIdSpéculation");

                    b.ToTable("Antenne_Spéculation");
                });

            modelBuilder.Entity("Domain.Models.Batiment", b =>
                {
                    b.Property<Guid>("Id_batiment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacité")
                        .HasColumnType("int");

                    b.Property<int>("Code_batiment")
                        .HasColumnType("int");

                    b.Property<Guid>("FkCentre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Superficie")
                        .HasColumnType("int");

                    b.HasKey("Id_batiment");

                    b.HasIndex("FkCentre");

                    b.ToTable("Batiments");
                });

            modelBuilder.Entity("Domain.Models.Centre", b =>
                {
                    b.Property<Guid>("IdCentre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress_centre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AntenneIdAntenne")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Capacité_silos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chef_centre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code_centre")
                        .HasColumnType("int");

                    b.Property<string>("Controlleur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faxcentre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FkAffectation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkAntenne")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkSituation_Journalier_Centre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Libellé_centre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local_centre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nombre_batiment")
                        .HasColumnType("int");

                    b.Property<Guid?>("Situation_Journalier_CentreIdSituation_Journalier_Centre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Superficie_utile")
                        .HasColumnType("int");

                    b.Property<string>("Tel_centre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCentre");

                    b.HasIndex("AntenneIdAntenne");

                    b.HasIndex("Situation_Journalier_CentreIdSituation_Journalier_Centre");

                    b.ToTable("Centres");
                });

            modelBuilder.Entity("Domain.Models.Chef_Centre", b =>
                {
                    b.Property<Guid>("Idchef_centre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomchef_centre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idchef_centre");

                    b.ToTable("Chef_Centre");
                });

            modelBuilder.Entity("Domain.Models.Controlleur", b =>
                {
                    b.Property<Guid>("IdControlleur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomControlleur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdControlleur");

                    b.ToTable("Controlleur");
                });

            modelBuilder.Entity("Domain.Models.Couvoir", b =>
                {
                    b.Property<Guid>("IdCouvoir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresse_Couvoir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code_Couvoir")
                        .HasColumnType("int");

                    b.Property<string>("Fax_Couvoir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libellé_Couvoir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel_Couvoir")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCouvoir");

                    b.ToTable("Couvoir");
                });

            modelBuilder.Entity("Domain.Models.Lot", b =>
                {
                    b.Property<Guid>("Idlot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date_debut_lot")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FkSouche")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Num_lot")
                        .HasColumnType("int");

                    b.HasKey("Idlot");

                    b.HasIndex("FkSouche");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("Domain.Models.Mise_En_Place_Sous_Lots", b =>
                {
                    b.Property<Guid>("IdMise_En_Place_Sous_Lots")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BatimentId_batiment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Mise_En_Place")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_d_eclosion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Effective_Entree")
                        .HasColumnType("int");

                    b.Property<int>("Effective_Entree_femelle")
                        .HasColumnType("int");

                    b.Property<int>("Effective_Entree_male")
                        .HasColumnType("int");

                    b.Property<int>("Effective_départ")
                        .HasColumnType("int");

                    b.Property<int>("Effective_départ_femelle")
                        .HasColumnType("int");

                    b.Property<int>("Effective_départ_male")
                        .HasColumnType("int");

                    b.Property<Guid>("FkBatiment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkLot")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkTypeMise_En_Place")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LotIdlot")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Nbr_sous_lot")
                        .HasColumnType("int");

                    b.Property<Guid?>("TypeMise_En_PlaceIdTypeMise_En_Place")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMise_En_Place_Sous_Lots");

                    b.HasIndex("BatimentId_batiment");

                    b.HasIndex("LotIdlot");

                    b.HasIndex("TypeMise_En_PlaceIdTypeMise_En_Place");

                    b.ToTable("Mise_En_Place_Sous_Lots");
                });

            modelBuilder.Entity("Domain.Models.Objectif", b =>
                {
                    b.Property<Guid>("IdObjectif")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Code_souche")
                        .HasColumnType("int");

                    b.Property<int>("Fertilité")
                        .HasColumnType("int");

                    b.Property<Guid>("FkSouche")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Libellé_Souche")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prc_Mortalité")
                        .HasColumnType("int");

                    b.Property<int>("Prc_Ponte")
                        .HasColumnType("int");

                    b.Property<int>("Prc_Prod")
                        .HasColumnType("int");

                    b.Property<Guid?>("SoucheIdSouche")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SpéculationIdSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdObjectif");

                    b.HasIndex("SoucheIdSouche");

                    b.HasIndex("SpéculationIdSpéculation");

                    b.ToTable("Objectifs");
                });

            modelBuilder.Entity("Domain.Models.Parentaux", b =>
                {
                    b.Property<Guid>("Code_parent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkBatiment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkCouvoir")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkLot")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Libellé_Parent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpéculationIdSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Code_parent");

                    b.HasIndex("FkBatiment");

                    b.HasIndex("FkCouvoir");

                    b.HasIndex("FkLot");

                    b.HasIndex("SpéculationIdSpéculation");

                    b.ToTable("Parentaux");
                });

            modelBuilder.Entity("Domain.Models.Rapport_Final", b =>
                {
                    b.Property<Guid>("IdRapport_final")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Explication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Fkrotation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RotationIdRotation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Stock_réel")
                        .HasColumnType("int");

                    b.Property<int>("Stock_theorique")
                        .HasColumnType("int");

                    b.HasKey("IdRapport_final");

                    b.HasIndex("RotationIdRotation");

                    b.ToTable("Rapport_Finals");
                });

            modelBuilder.Entity("Domain.Models.Rotation", b =>
                {
                    b.Property<Guid>("IdRotation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date_début_Rotation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_fin_Rotation")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FkCentre")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkSpéculation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Numéro_Rotation")
                        .HasColumnType("int");

                    b.HasKey("IdRotation");

                    b.HasIndex("FkCentre");

                    b.HasIndex("FkSpéculation");

                    b.ToTable("Rotations");
                });

            modelBuilder.Entity("Domain.Models.Situation_Journalier_Centre", b =>
                {
                    b.Property<Guid>("IdSituation_Journalier_Centre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Laitiere")
                        .HasColumnType("int");

                    b.Property<int>("Mortalité_Male")
                        .HasColumnType("int");

                    b.Property<int>("Mortalité_femelle")
                        .HasColumnType("int");

                    b.Property<int>("Ouvrier")
                        .HasColumnType("int");

                    b.Property<int>("Température")
                        .HasColumnType("int");

                    b.HasKey("IdSituation_Journalier_Centre");

                    b.ToTable("Situation_Journalier_Centre");
                });

            modelBuilder.Entity("Domain.Models.Souche", b =>
                {
                    b.Property<Guid>("IdSouche")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code_souche")
                        .HasColumnType("int");

                    b.Property<Guid>("FkParentaux")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Libellé_Souche")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentauxCode_parent")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSouche");

                    b.HasIndex("ParentauxCode_parent");

                    b.ToTable("Souches");
                });

            modelBuilder.Entity("Domain.Models.Spéculation", b =>
                {
                    b.Property<Guid>("IdSpéculation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code_spec")
                        .HasColumnType("int");

                    b.Property<string>("Libelle_spec")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSpéculation");

                    b.ToTable("Spéculations");
                });

            modelBuilder.Entity("Domain.Models.TypeMise_En_Place", b =>
                {
                    b.Property<Guid>("IdTypeMise_En_Place")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTypeMise_En_Place");

                    b.ToTable("TypeMise_En_Places");
                });

            modelBuilder.Entity("Domain.Models.Affectation", b =>
                {
                    b.HasOne("Domain.Models.Chef_Centre", "Chef_Centre")
                        .WithMany("Affectation")
                        .HasForeignKey("Chef_CentreIdchef_centre");

                    b.HasOne("Domain.Models.Controlleur", "Controlleur")
                        .WithMany("Affectation")
                        .HasForeignKey("ControlleurIdControlleur");

                    b.HasOne("Domain.Models.Centre", "Centre")
                        .WithOne("Affectation")
                        .HasForeignKey("Domain.Models.Affectation", "Fkcentre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Antenne_Spéculation", b =>
                {
                    b.HasOne("Domain.Models.Antenne", "Antenne")
                        .WithMany("Antenne_Spéculation")
                        .HasForeignKey("AntenneIdAntenne");

                    b.HasOne("Domain.Models.Spéculation", "Spéculation")
                        .WithMany("Antenne_Spéculation")
                        .HasForeignKey("SpéculationIdSpéculation");
                });

            modelBuilder.Entity("Domain.Models.Batiment", b =>
                {
                    b.HasOne("Domain.Models.Centre", "Centre")
                        .WithMany("Batiment")
                        .HasForeignKey("FkCentre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Centre", b =>
                {
                    b.HasOne("Domain.Models.Antenne", "Antenne")
                        .WithMany()
                        .HasForeignKey("AntenneIdAntenne");

                    b.HasOne("Domain.Models.Situation_Journalier_Centre", "Situation_Journalier_Centre")
                        .WithMany()
                        .HasForeignKey("Situation_Journalier_CentreIdSituation_Journalier_Centre");
                });

            modelBuilder.Entity("Domain.Models.Lot", b =>
                {
                    b.HasOne("Domain.Models.Souche", "Souche")
                        .WithMany("Lots")
                        .HasForeignKey("FkSouche")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Mise_En_Place_Sous_Lots", b =>
                {
                    b.HasOne("Domain.Models.Batiment", "Batiment")
                        .WithMany()
                        .HasForeignKey("BatimentId_batiment");

                    b.HasOne("Domain.Models.Lot", "Lot")
                        .WithMany()
                        .HasForeignKey("LotIdlot");

                    b.HasOne("Domain.Models.TypeMise_En_Place", "TypeMise_En_Place")
                        .WithMany()
                        .HasForeignKey("TypeMise_En_PlaceIdTypeMise_En_Place");
                });

            modelBuilder.Entity("Domain.Models.Objectif", b =>
                {
                    b.HasOne("Domain.Models.Souche", "Souche")
                        .WithMany("Objectif")
                        .HasForeignKey("SoucheIdSouche");

                    b.HasOne("Domain.Models.Spéculation", "Spéculation")
                        .WithMany("Objectif")
                        .HasForeignKey("SpéculationIdSpéculation");
                });

            modelBuilder.Entity("Domain.Models.Parentaux", b =>
                {
                    b.HasOne("Domain.Models.Batiment", "Batiment")
                        .WithMany("Parentaux")
                        .HasForeignKey("FkBatiment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Couvoir", "Couvoir")
                        .WithMany("Parentaux")
                        .HasForeignKey("FkCouvoir")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Lot", "Lot")
                        .WithMany("Parentaux")
                        .HasForeignKey("FkLot")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Spéculation", null)
                        .WithMany("Parentaux")
                        .HasForeignKey("SpéculationIdSpéculation");
                });

            modelBuilder.Entity("Domain.Models.Rapport_Final", b =>
                {
                    b.HasOne("Domain.Models.Rotation", "Rotation")
                        .WithMany("Rapport_Final")
                        .HasForeignKey("RotationIdRotation");
                });

            modelBuilder.Entity("Domain.Models.Rotation", b =>
                {
                    b.HasOne("Domain.Models.Centre", "Centre")
                        .WithMany("Rotation")
                        .HasForeignKey("FkCentre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Spéculation", "Spéculation")
                        .WithMany("Rotation")
                        .HasForeignKey("FkSpéculation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Souche", b =>
                {
                    b.HasOne("Domain.Models.Parentaux", "Parentaux")
                        .WithMany()
                        .HasForeignKey("ParentauxCode_parent");
                });
#pragma warning restore 612, 618
        }
    }
}
