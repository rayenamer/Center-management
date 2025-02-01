using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public  class Lot 
    {
        public DateTime Date_debut_lot  { get; set; }
        
        public Guid Idlot { get; set; }
        public int Num_lot{ get; set; }
        
    
        public Guid FkSouche { get; set; }
        public Souche Souche { get; set; }

        public ICollection<Parentaux> Parentaux { get; set; }


    }
}
