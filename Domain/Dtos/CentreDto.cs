using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
    public class CentreDto
    {
        public Guid IdCentre { get; set; }
        public int Code_centre { get; set; }
        public string Libellé_centre { get; set; }
      
        public int Nombre_batiment { get; set; }
        public int Superficie_utile { get; set; }
        public string Capacité_silos { get; set; }
        public string Adress_centre { get; set; }
        public string Local_centre { get; set; }
        public string Tel_centre { get; set; }
        public string Faxcentre { get; set; }
        public string Chef_centre { get; set; }
        public string Controlleur { get; set; }
 

    }
}
