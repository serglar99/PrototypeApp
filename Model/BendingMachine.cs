using System;
using System.ComponentModel.DataAnnotations;

namespace PrototypeApp.Model
{
    public class BendingMachine
    {
        [Key]
        public Guid Id { get; set; }

        public string G_Name { get; set; } = "МГПС-25";

        public string Company { get; set; }

        public string Country { get; set; } = "Россия";

        public string Town { get; set; }

        public int Cost { get; set; }

        public int CostM { get; set; }

        public string Date { get; set; }

        public int Time { get; set; }

        public int Pkh { get; set; }

        public int Ptc { get; set; }

        public int Bmax { get; set; }

        public int Lmax { get; set; }

        public int Sod { get; set; }

        public int Sdv { get; set; }

        public int Massa { get; set; }

        public int LBH { get; set; }

        public int Energ { get; set; }

        public int NUN { get; set; }

        public int NGN { get; set; }

        public string VI { get; set; } = "Переменный";

    }
}
