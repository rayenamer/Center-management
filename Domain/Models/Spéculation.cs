using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Spéculation
    {
        public Guid IdSpéculation { get; set; }
        public string Libelle_spec { get; set; }
        public int  Code_spec { get; set; }
        public ICollection<Rotation> Rotation { get; set; }
        public ICollection<Antenne_Spéculation> Antenne_Spéculation { get; set; }

        public ICollection<Objectif> Objectif { get; set; }
        public ICollection<Parentaux> Parentaux  { get; set; }

    }
}
