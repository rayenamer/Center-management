using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Controlleur
    {
        public Guid IdControlleur { get; set; }
        public string Cin { get; set; }
        public string NomControlleur { get; set; }
        public ICollection<Affectation> Affectation   { get; set; }
    }
}
