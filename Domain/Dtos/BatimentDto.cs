using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    public class BatimentDto
    {
        public Guid Id_batiment { get; set; }
        public int Superficie { get; set; }
        public int Capacité { get; set; }
        public int Code_batiment { get; set; }

        public string Libellé_centre { get; set; }

        public Guid FkCentre { get; set; }
    }
}
