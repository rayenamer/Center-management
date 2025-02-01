using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Affectation
    {
        public Guid Idaffectation { get; set; }


        public Chef_Centre Chef_Centre { get; set; }
        public Guid Fkchef_centre { get; set; }

        public Controlleur Controlleur { get; set; }
        public Guid FkControlleur { get; set; }

        public Centre Centre { get; set; }

        public Guid Fkcentre { get; set; }
    }
}
