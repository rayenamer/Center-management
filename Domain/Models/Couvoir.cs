using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Couvoir

    {
        public Guid IdCouvoir { get; set; }
        public int Code_Couvoir  { get; set; }
        public string  Libellé_Couvoir { get; set; }
        public string Adresse_Couvoir { get; set; }
        public string Tel_Couvoir { get; set; }
        public string Fax_Couvoir { get; set; }
        public ICollection<Parentaux> Parentaux { get; set; }

    }
}
