using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Antenne_Spéculation


    {
        public Guid  idAntenne_Spéculation { get; set; }

        public Antenne Antenne { get; set; }

        public Guid FkAntenne { get; set; }

        public Spéculation Spéculation { get; set; }

        public Guid FkSpéculation { get; set; }
    }
}
