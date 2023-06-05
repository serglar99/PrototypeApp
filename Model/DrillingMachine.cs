using System;
using System.ComponentModel.DataAnnotations;

namespace PrototypeApp.Model
{
    public class DrillingMachine
    {
        [Key]
        public Guid Id { get; set; }

        public string D_Name { get; set; }

        public string Company { get; set; }

        public string Country { get; set; } = "Россия";

        public string Town { get; set; }

        public int Cost { get; set; }

        public int CostM { get; set; }

        public string Date { get; set; }

        public int Time{ get; set; }

        public double Massa { get; set; }

        public string LBH { get; set; }

        public int Energ { get; set; }

        public int SumN { get; set; }

        public int NUN { get; set; }

        public int NGN { get; set; }

        public string VI { get; set; } = "Переменный";

        public int Dmax { get; set; }

        public int E1 { get; set; }

        public int E2 { get; set; }

        public int Emax { get; set; }





    }
}
