using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrototypeApp.Model
{
    public class WeldingMachine
    {
        [Key]
        public Guid Id { get; set; }

        public string V_Name { get; set; }

        public string Company { get; set; }

        public string Country { get; set; } = "Россия";

        public string Town { get; set; }

        public int Cost { get; set; }

        public int CostM { get; set; }

        public string Date { get; set; }

        public int Time { get; set; }

        public int Massa { get; set; }

        public int LBH { get; set; }

        public int Pmax { get; set; }

        public int NUN { get; set; }

        public int NGN { get; set; }

        public string VI { get; set; } = "Переменный";

        public int Arg { get; set; }

        public int Parg { get; set; }

        public string Specification { get; set; }
    }
}
