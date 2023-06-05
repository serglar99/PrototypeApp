using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PrototypeApp.Model
{
    public class Settings
    {
        [Key]

        public double Ks { get; set; } = 1;

        public int F { get; set; } = 250;

        public int G { get; set; } = 35;

        public int Mb { get; set; } = 25;

        public double Pb { get; set; } = 1.2;

        public double Kzb { get; set; } = 0.6;

        public double Kbpod { get; set; } = 1.05;

        public double Pd { get; set; } = 2;

        public double Kzd { get; set; } = 0.6;

        public double Kdpod { get; set; } = 1.05;

        public double Kzc { get; set; } = 0.6; 

        public double Kcpod { get; set; } = 1.05;

        public int Isv { get; set; } = 150;

        public double An { get; set; } = 2; 

        public double Kzw { get; set; } = 0.5;

        public double Kn { get; set; } = 50;
        
    }
}
