using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Rapport_Final
    {
        public Guid IdRapport_final { get; set; }
        public int Stock_réel { get; set; }
        public int Stock_theorique { get; set; }
        public string  Explication { get; set; }
        public Rotation Rotation { get; set; }
        public Guid Fkrotation { get; set; }
    }
}
