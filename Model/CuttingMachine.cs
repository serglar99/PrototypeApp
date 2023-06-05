using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrototypeApp.Model
{
    public class CuttingMachine
    {
        [Key]
        public Guid Id { get; set; }

        public string C_Name { get; set; }

        public string Company { get; set; }

        public string Country { get; set; } = "Россия";

        public string Town { get; set; }

        public int Cost { get; set; }

        public int CostM { get; set; }

        public string Date { get; set; }

        public int Time { get; set; }

        public int L { get; set; }

        public int B { get; set; }

        public int Vmax { get; set; }

        public int Vtra { get; set; }

        public int Abr { get; set; }

        public int Vs { get; set; }

        public int Massa { get; set; }

        public int Energ { get; set; }

        public int NUN { get; set; }

        public int NGN { get; set; }

        public string VI { get; set; } = "Переменный";

        public string AbrM { get; set; }

        public int Ppump { get; set; }

        public int Pnom { get; set; }


    }
}
