using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Parentaux
    {
        public Guid Code_parent { get; set; }
        public string  Libellé_Parent { get; set; }
        public Batiment Batiment { get; set; }
        public Guid FkBatiment { get; set; }

        public Lot Lot{ get; set; }
        public Guid FkLot { get; set; }

        public Couvoir Couvoir { get; set; }
        public Guid FkCouvoir { get; set; }

    }
} 
