using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Mise_En_Place_Sous_Lots
    {
        public Guid IdMise_En_Place_Sous_Lots { get; set; }
        public int Effective_départ_femelle { get; set; }
        public int Nbr_sous_lot { get; set; }
        public int Effective_départ { get; set; }
        public int Effective_Entree_male  { get; set; }
        public int Effective_Entree{ get; set; }
        public int Effective_Entree_femelle { get; set; }
        public int Effective_départ_male { get; set; }
        public DateTime Date_Mise_En_Place  { get; set; }
        public DateTime Date_d_eclosion { get; set; }
        public string Commentaire  { get; set; }

     
        
        public Guid FkTypeMise_En_Place  { get; set; }
        public TypeMise_En_Place TypeMise_En_Place { get; set; }

        public Guid FkLot { get; set; }
        public Lot Lot  { get; set; }

        public Guid FkBatiment { get; set; }
        public Batiment Batiment { get; set; }
    }
}

