using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Rotation
    {
        public Guid IdRotation { get; set; }
        public int Numéro_Rotation { get; set; }
        public DateTime Date_fin_Rotation { get; set; }
        public DateTime Date_début_Rotation { get; set; }
        public Spéculation Spéculation { get; set; }
        public Guid FkSpéculation { get; set; }

        public Centre Centre  { get; set; }
        public Guid FkCentre  { get; set; }

        public ICollection<Rapport_Final> Rapport_Final  { get; set; }
    }
}
