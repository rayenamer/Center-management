using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Situation_Journalier_Centre

    {

        public Guid IdSituation_Journalier_Centre { get; set; }
        public int Age { get; set; }
        public int Température { get; set; }
        public int Laitiere { get; set; }
        public int Ouvrier { get; set; }

        public int Mortalité_femelle { get; set; }
        public int Mortalité_Male { get; set; }

    }
}
