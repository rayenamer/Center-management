using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Antenne

    {   public Guid IdAntenne { get; set; }
        public int Code_Antenne   { get; set; }
        public string  Libellé_Antenne  { get; set; }
        public string Adresse_Antenne  { get; set; }
        public string Tel_Antenne { get; set; }
        public string Fax_Antenne { get; set; }

        public ICollection<Antenne_Spéculation> Antenne_Spéculation { get; set; }


    }
}
