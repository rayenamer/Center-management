using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public  class Souche
    {

        public Guid IdSouche { get; set; }
        public int Code_souche  { get; set; }
        public string Libellé_Souche  { get; set; }
        public  Parentaux Parentaux { get; set; }
        public Guid FkParentaux { get; set; }
        public ICollection<Lot> Lots  { get; set; }

        public ICollection<Objectif> Objectif  { get; set; }
        
    }
}
