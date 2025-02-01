using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Batiment
    {
        public Guid Id_batiment { get; set; }
        public int Superficie { get; set; }
        public int Capacité { get; set; }
        public int Code_batiment { get; set; }
        public Centre Centre { get; set; }
              
        public Guid FkCentre { get; set; }
        public ICollection<Parentaux> Parentaux { get; set; }




    }
}
