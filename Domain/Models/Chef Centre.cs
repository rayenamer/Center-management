using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Chef_Centre
    {
        public Guid Idchef_centre  { get; set; }
        public string Cin { get; set; }
        public string Nomchef_centre { get; set; }
        public ICollection<Affectation> Affectation   { get; set; }
       
    }
}
