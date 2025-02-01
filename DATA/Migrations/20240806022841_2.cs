using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antennes",
                columns: table => new
                {
                    IdAntenne = table.Column<Guid>(nullable: false),
                    Code_Antenne = table.Column<int>(nullable: false),
                    Libellé_Antenne = table.Column<string>(nullable: true),
                    Adresse_Antenne = table.Column<string>(nullable: true),
                    Tel_Antenne = table.Column<string>(nullable: true),
                    Fax_Antenne = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antennes", x => x.IdAntenne);
                });

            migrationBuilder.CreateTable(
                name: "Chef_Centre",
                columns: table => new
                {
                    Idchef_centre = table.Column<Guid>(nullable: false),
                    Cin = table.Column<string>(nullable: true),
                    Nomchef_centre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chef_Centre", x => x.Idchef_centre);
                });

            migrationBuilder.CreateTable(
                name: "Controlleur",
                columns: table => new
                {
                    IdControlleur = table.Column<Guid>(nullable: false),
                    Cin = table.Column<string>(nullable: true),
                    NomControlleur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controlleur", x => x.IdControlleur);
                });

            migrationBuilder.CreateTable(
                name: "Couvoir",
                columns: table => new
                {
                    IdCouvoir = table.Column<Guid>(nullable: false),
                    Code_Couvoir = table.Column<int>(nullable: false),
                    Libellé_Couvoir = table.Column<string>(nullable: true),
                    Adresse_Couvoir = table.Column<string>(nullable: true),
                    Tel_Couvoir = table.Column<string>(nullable: true),
                    Fax_Couvoir = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couvoir", x => x.IdCouvoir);
                });

            migrationBuilder.CreateTable(
                name: "Situation_Journalier_Centre",
                columns: table => new
                {
                    IdSituation_Journalier_Centre = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Température = table.Column<int>(nullable: false),
                    Laitiere = table.Column<int>(nullable: false),
                    Ouvrier = table.Column<int>(nullable: false),
                    Mortalité_femelle = table.Column<int>(nullable: false),
                    Mortalité_Male = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situation_Journalier_Centre", x => x.IdSituation_Journalier_Centre);
                });

            migrationBuilder.CreateTable(
                name: "Spéculations",
                columns: table => new
                {
                    IdSpéculation = table.Column<Guid>(nullable: false),
                    Libelle_spec = table.Column<string>(nullable: true),
                    Code_spec = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spéculations", x => x.IdSpéculation);
                });

            migrationBuilder.CreateTable(
                name: "TypeMise_En_Places",
                columns: table => new
                {
                    IdTypeMise_En_Place = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeMise_En_Places", x => x.IdTypeMise_En_Place);
                });

            migrationBuilder.CreateTable(
                name: "Centres",
                columns: table => new
                {
                    IdCentre = table.Column<Guid>(nullable: false),
                    Code_centre = table.Column<int>(nullable: false),
                    Libellé_centre = table.Column<string>(nullable: true),
                    Nombre_batiment = table.Column<int>(nullable: false),
                    Superficie_utile = table.Column<int>(nullable: false),
                    Capacité_silos = table.Column<string>(nullable: true),
                    Adress_centre = table.Column<string>(nullable: true),
                    Local_centre = table.Column<string>(nullable: true),
                    Tel_centre = table.Column<string>(nullable: true),
                    Faxcentre = table.Column<string>(nullable: true),
                    Chef_centre = table.Column<string>(nullable: true),
                    Controlleur = table.Column<string>(nullable: true),
                    AntenneIdAntenne = table.Column<Guid>(nullable: true),
                    FkAntenne = table.Column<Guid>(nullable: false),
                    Situation_Journalier_CentreIdSituation_Journalier_Centre = table.Column<Guid>(nullable: true),
                    FkSituation_Journalier_Centre = table.Column<Guid>(nullable: false),
                    FkAffectation = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centres", x => x.IdCentre);
                    table.ForeignKey(
                        name: "FK_Centres_Antennes_AntenneIdAntenne",
                        column: x => x.AntenneIdAntenne,
                        principalTable: "Antennes",
                        principalColumn: "IdAntenne",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Centres_Situation_Journalier_Centre_Situation_Journalier_CentreIdSituation_Journalier_Centre",
                        column: x => x.Situation_Journalier_CentreIdSituation_Journalier_Centre,
                        principalTable: "Situation_Journalier_Centre",
                        principalColumn: "IdSituation_Journalier_Centre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Antenne_Spéculation",
                columns: table => new
                {
                    idAntenne_Spéculation = table.Column<Guid>(nullable: false),
                    AntenneIdAntenne = table.Column<Guid>(nullable: true),
                    FkAntenne = table.Column<Guid>(nullable: false),
                    SpéculationIdSpéculation = table.Column<Guid>(nullable: true),
                    FkSpéculation = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antenne_Spéculation", x => x.idAntenne_Spéculation);
                    table.ForeignKey(
                        name: "FK_Antenne_Spéculation_Antennes_AntenneIdAntenne",
                        column: x => x.AntenneIdAntenne,
                        principalTable: "Antennes",
                        principalColumn: "IdAntenne",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Antenne_Spéculation_Spéculations_SpéculationIdSpéculation",
                        column: x => x.SpéculationIdSpéculation,
                        principalTable: "Spéculations",
                        principalColumn: "IdSpéculation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Idaffectation = table.Column<Guid>(nullable: false),
                    Chef_CentreIdchef_centre = table.Column<Guid>(nullable: true),
                    Fkchef_centre = table.Column<Guid>(nullable: false),
                    ControlleurIdControlleur = table.Column<Guid>(nullable: true),
                    FkControlleur = table.Column<Guid>(nullable: false),
                    Fkcentre = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Idaffectation);
                    table.ForeignKey(
                        name: "FK_Affectations_Chef_Centre_Chef_CentreIdchef_centre",
                        column: x => x.Chef_CentreIdchef_centre,
                        principalTable: "Chef_Centre",
                        principalColumn: "Idchef_centre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Affectations_Controlleur_ControlleurIdControlleur",
                        column: x => x.ControlleurIdControlleur,
                        principalTable: "Controlleur",
                        principalColumn: "IdControlleur",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Affectations_Centres_Fkcentre",
                        column: x => x.Fkcentre,
                        principalTable: "Centres",
                        principalColumn: "IdCentre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Batiments",
                columns: table => new
                {
                    Id_batiment = table.Column<Guid>(nullable: false),
                    Superficie = table.Column<int>(nullable: false),
                    Capacité = table.Column<int>(nullable: false),
                    Code_batiment = table.Column<int>(nullable: false),
                    FkCentre = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batiments", x => x.Id_batiment);
                    table.ForeignKey(
                        name: "FK_Batiments_Centres_FkCentre",
                        column: x => x.FkCentre,
                        principalTable: "Centres",
                        principalColumn: "IdCentre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rotations",
                columns: table => new
                {
                    IdRotation = table.Column<Guid>(nullable: false),
                    Numéro_Rotation = table.Column<int>(nullable: false),
                    Date_fin_Rotation = table.Column<DateTime>(nullable: false),
                    Date_début_Rotation = table.Column<DateTime>(nullable: false),
                    FkSpéculation = table.Column<Guid>(nullable: false),
                    FkCentre = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotations", x => x.IdRotation);
                    table.ForeignKey(
                        name: "FK_Rotations_Centres_FkCentre",
                        column: x => x.FkCentre,
                        principalTable: "Centres",
                        principalColumn: "IdCentre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rotations_Spéculations_FkSpéculation",
                        column: x => x.FkSpéculation,
                        principalTable: "Spéculations",
                        principalColumn: "IdSpéculation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rapport_Finals",
                columns: table => new
                {
                    IdRapport_final = table.Column<Guid>(nullable: false),
                    Stock_réel = table.Column<int>(nullable: false),
                    Stock_theorique = table.Column<int>(nullable: false),
                    Explication = table.Column<string>(nullable: true),
                    RotationIdRotation = table.Column<Guid>(nullable: true),
                    Fkrotation = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapport_Finals", x => x.IdRapport_final);
                    table.ForeignKey(
                        name: "FK_Rapport_Finals_Rotations_RotationIdRotation",
                        column: x => x.RotationIdRotation,
                        principalTable: "Rotations",
                        principalColumn: "IdRotation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mise_En_Place_Sous_Lots",
                columns: table => new
                {
                    IdMise_En_Place_Sous_Lots = table.Column<Guid>(nullable: false),
                    Effective_départ_femelle = table.Column<int>(nullable: false),
                    Nbr_sous_lot = table.Column<int>(nullable: false),
                    Effective_départ = table.Column<int>(nullable: false),
                    Effective_Entree_male = table.Column<int>(nullable: false),
                    Effective_Entree = table.Column<int>(nullable: false),
                    Effective_Entree_femelle = table.Column<int>(nullable: false),
                    Effective_départ_male = table.Column<int>(nullable: false),
                    Date_Mise_En_Place = table.Column<DateTime>(nullable: false),
                    Date_d_eclosion = table.Column<DateTime>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true),
                    FkTypeMise_En_Place = table.Column<Guid>(nullable: false),
                    TypeMise_En_PlaceIdTypeMise_En_Place = table.Column<Guid>(nullable: true),
                    FkLot = table.Column<Guid>(nullable: false),
                    LotIdlot = table.Column<Guid>(nullable: true),
                    FkBatiment = table.Column<Guid>(nullable: false),
                    BatimentId_batiment = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mise_En_Place_Sous_Lots", x => x.IdMise_En_Place_Sous_Lots);
                    table.ForeignKey(
                        name: "FK_Mise_En_Place_Sous_Lots_Batiments_BatimentId_batiment",
                        column: x => x.BatimentId_batiment,
                        principalTable: "Batiments",
                        principalColumn: "Id_batiment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mise_En_Place_Sous_Lots_TypeMise_En_Places_TypeMise_En_PlaceIdTypeMise_En_Place",
                        column: x => x.TypeMise_En_PlaceIdTypeMise_En_Place,
                        principalTable: "TypeMise_En_Places",
                        principalColumn: "IdTypeMise_En_Place",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parentaux",
                columns: table => new
                {
                    Code_parent = table.Column<Guid>(nullable: false),
                    Libellé_Parent = table.Column<string>(nullable: true),
                    FkBatiment = table.Column<Guid>(nullable: false),
                    FkLot = table.Column<Guid>(nullable: false),
                    FkCouvoir = table.Column<Guid>(nullable: false),
                    SpéculationIdSpéculation = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parentaux", x => x.Code_parent);
                    table.ForeignKey(
                        name: "FK_Parentaux_Batiments_FkBatiment",
                        column: x => x.FkBatiment,
                        principalTable: "Batiments",
                        principalColumn: "Id_batiment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parentaux_Couvoir_FkCouvoir",
                        column: x => x.FkCouvoir,
                        principalTable: "Couvoir",
                        principalColumn: "IdCouvoir",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parentaux_Spéculations_SpéculationIdSpéculation",
                        column: x => x.SpéculationIdSpéculation,
                        principalTable: "Spéculations",
                        principalColumn: "IdSpéculation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Souches",
                columns: table => new
                {
                    IdSouche = table.Column<Guid>(nullable: false),
                    Code_souche = table.Column<int>(nullable: false),
                    Libellé_Souche = table.Column<string>(nullable: true),
                    ParentauxCode_parent = table.Column<Guid>(nullable: true),
                    FkParentaux = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Souches", x => x.IdSouche);
                    table.ForeignKey(
                        name: "FK_Souches_Parentaux_ParentauxCode_parent",
                        column: x => x.ParentauxCode_parent,
                        principalTable: "Parentaux",
                        principalColumn: "Code_parent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    Idlot = table.Column<Guid>(nullable: false),
                    Date_debut_lot = table.Column<DateTime>(nullable: false),
                    Num_lot = table.Column<int>(nullable: false),
                    FkSouche = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.Idlot);
                    table.ForeignKey(
                        name: "FK_Lots_Souches_FkSouche",
                        column: x => x.FkSouche,
                        principalTable: "Souches",
                        principalColumn: "IdSouche",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Objectifs",
                columns: table => new
                {
                    IdObjectif = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Libellé_Souche = table.Column<string>(nullable: true),
                    Prc_Prod = table.Column<int>(nullable: false),
                    Prc_Mortalité = table.Column<int>(nullable: false),
                    Prc_Ponte = table.Column<int>(nullable: false),
                    Fertilité = table.Column<int>(nullable: false),
                    Code_souche = table.Column<int>(nullable: false),
                    FkSouche = table.Column<Guid>(nullable: false),
                    SoucheIdSouche = table.Column<Guid>(nullable: true),
                    SpéculationIdSpéculation = table.Column<Guid>(nullable: true),
                    FkSpéculation = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectifs", x => x.IdObjectif);
                    table.ForeignKey(
                        name: "FK_Objectifs_Souches_SoucheIdSouche",
                        column: x => x.SoucheIdSouche,
                        principalTable: "Souches",
                        principalColumn: "IdSouche",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Objectifs_Spéculations_SpéculationIdSpéculation",
                        column: x => x.SpéculationIdSpéculation,
                        principalTable: "Spéculations",
                        principalColumn: "IdSpéculation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_Chef_CentreIdchef_centre",
                table: "Affectations",
                column: "Chef_CentreIdchef_centre");

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_ControlleurIdControlleur",
                table: "Affectations",
                column: "ControlleurIdControlleur");

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_Fkcentre",
                table: "Affectations",
                column: "Fkcentre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Antenne_Spéculation_AntenneIdAntenne",
                table: "Antenne_Spéculation",
                column: "AntenneIdAntenne");

            migrationBuilder.CreateIndex(
                name: "IX_Antenne_Spéculation_SpéculationIdSpéculation",
                table: "Antenne_Spéculation",
                column: "SpéculationIdSpéculation");

            migrationBuilder.CreateIndex(
                name: "IX_Batiments_FkCentre",
                table: "Batiments",
                column: "FkCentre");

            migrationBuilder.CreateIndex(
                name: "IX_Centres_AntenneIdAntenne",
                table: "Centres",
                column: "AntenneIdAntenne");

            migrationBuilder.CreateIndex(
                name: "IX_Centres_Situation_Journalier_CentreIdSituation_Journalier_Centre",
                table: "Centres",
                column: "Situation_Journalier_CentreIdSituation_Journalier_Centre");

            migrationBuilder.CreateIndex(
                name: "IX_Lots_FkSouche",
                table: "Lots",
                column: "FkSouche");

            migrationBuilder.CreateIndex(
                name: "IX_Mise_En_Place_Sous_Lots_BatimentId_batiment",
                table: "Mise_En_Place_Sous_Lots",
                column: "BatimentId_batiment");

            migrationBuilder.CreateIndex(
                name: "IX_Mise_En_Place_Sous_Lots_LotIdlot",
                table: "Mise_En_Place_Sous_Lots",
                column: "LotIdlot");

            migrationBuilder.CreateIndex(
                name: "IX_Mise_En_Place_Sous_Lots_TypeMise_En_PlaceIdTypeMise_En_Place",
                table: "Mise_En_Place_Sous_Lots",
                column: "TypeMise_En_PlaceIdTypeMise_En_Place");

            migrationBuilder.CreateIndex(
                name: "IX_Objectifs_SoucheIdSouche",
                table: "Objectifs",
                column: "SoucheIdSouche");

            migrationBuilder.CreateIndex(
                name: "IX_Objectifs_SpéculationIdSpéculation",
                table: "Objectifs",
                column: "SpéculationIdSpéculation");

            migrationBuilder.CreateIndex(
                name: "IX_Parentaux_FkBatiment",
                table: "Parentaux",
                column: "FkBatiment");

            migrationBuilder.CreateIndex(
                name: "IX_Parentaux_FkCouvoir",
                table: "Parentaux",
                column: "FkCouvoir");

            migrationBuilder.CreateIndex(
                name: "IX_Parentaux_FkLot",
                table: "Parentaux",
                column: "FkLot");

            migrationBuilder.CreateIndex(
                name: "IX_Parentaux_SpéculationIdSpéculation",
                table: "Parentaux",
                column: "SpéculationIdSpéculation");

            migrationBuilder.CreateIndex(
                name: "IX_Rapport_Finals_RotationIdRotation",
                table: "Rapport_Finals",
                column: "RotationIdRotation");

            migrationBuilder.CreateIndex(
                name: "IX_Rotations_FkCentre",
                table: "Rotations",
                column: "FkCentre");

            migrationBuilder.CreateIndex(
                name: "IX_Rotations_FkSpéculation",
                table: "Rotations",
                column: "FkSpéculation");

            migrationBuilder.CreateIndex(
                name: "IX_Souches_ParentauxCode_parent",
                table: "Souches",
                column: "ParentauxCode_parent");

            migrationBuilder.AddForeignKey(
                name: "FK_Mise_En_Place_Sous_Lots_Lots_LotIdlot",
                table: "Mise_En_Place_Sous_Lots",
                column: "LotIdlot",
                principalTable: "Lots",
                principalColumn: "Idlot",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parentaux_Lots_FkLot",
                table: "Parentaux",
                column: "FkLot",
                principalTable: "Lots",
                principalColumn: "Idlot",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batiments_Centres_FkCentre",
                table: "Batiments");

            migrationBuilder.DropForeignKey(
                name: "FK_Parentaux_Spéculations_SpéculationIdSpéculation",
                table: "Parentaux");

            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Souches_FkSouche",
                table: "Lots");

            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Antenne_Spéculation");

            migrationBuilder.DropTable(
                name: "Mise_En_Place_Sous_Lots");

            migrationBuilder.DropTable(
                name: "Objectifs");

            migrationBuilder.DropTable(
                name: "Rapport_Finals");

            migrationBuilder.DropTable(
                name: "Chef_Centre");

            migrationBuilder.DropTable(
                name: "Controlleur");

            migrationBuilder.DropTable(
                name: "TypeMise_En_Places");

            migrationBuilder.DropTable(
                name: "Rotations");

            migrationBuilder.DropTable(
                name: "Centres");

            migrationBuilder.DropTable(
                name: "Antennes");

            migrationBuilder.DropTable(
                name: "Situation_Journalier_Centre");

            migrationBuilder.DropTable(
                name: "Spéculations");

            migrationBuilder.DropTable(
                name: "Souches");

            migrationBuilder.DropTable(
                name: "Parentaux");

            migrationBuilder.DropTable(
                name: "Batiments");

            migrationBuilder.DropTable(
                name: "Couvoir");

            migrationBuilder.DropTable(
                name: "Lots");
        }
    }
}
