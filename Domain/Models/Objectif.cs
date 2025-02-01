using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Objectif
    {
        public Guid IdObjectif { get; set; }

        public int Age { get; set; }
        public string Libellé_Souche { get; set; }
        public int Prc_Prod  { get; set; }
        public int Prc_Mortalité { get; set; }
        public int Prc_Ponte { get; set; }
        public int Fertilité { get; set; }
        public int Code_souche { get; set; }
        public Guid FkSouche { get; set; }
        public Souche Souche { get; set; }
        public Spéculation Spéculation { get; set; }
        public Guid FkSpéculation  { get; set; }
    }
}
