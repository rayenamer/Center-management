using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Centre

    {
        public Guid IdCentre { get; set; }
        public int Code_centre { get; set; }
        public string Libellé_centre { get; set; }
        public int Nombre_batiment { get; set; }
        public int Superficie_utile { get; set; }
        public string Capacité_silos {get; set; }
        public string Adress_centre { get; set; }
        public string Local_centre { get; set; }
        public string Tel_centre { get; set; }
        public string Faxcentre{ get; set; }
        public string Chef_centre { get; set; }
        public string Controlleur { get; set; }

        public Antenne Antenne { get; set; }

        public Guid FkAntenne { get; set; }
        

        public Situation_Journalier_Centre Situation_Journalier_Centre { get; set; }
        public Guid FkSituation_Journalier_Centre { get; set; }
        public ICollection<Rotation> Rotation { get; set; }
        public ICollection<Batiment> Batiment  { get; set; }

        public Affectation Affectation { get; set; }

        public Guid FkAffectation { get; set; }
      
    }
}
