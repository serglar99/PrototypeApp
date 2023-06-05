using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrototypeApp.Model
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string Com_Name { get; set; }

        public int Region { get; set; } = 1;

        public int Shift { get; set; } = 1;

        public int Week { get; set; } = 40;

        public int Vprog { get; set; }

        public string Program { get; set; }

        public string AppProgram { get; set; }

        public int Rm { get; set; }

        public int CountM { get; set; }

    }
}
