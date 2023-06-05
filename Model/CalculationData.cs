using System;

namespace PrototypeApp.Model
{
    public class CalculationData
    {
        public int workingDaysInYear { get; set; } = 250;

        public double CuttListAmount { get; set; } = 1.2;

        public double changeRatio {get; set; } = 1;

        public double CuttMachineLoadRatio { get; set; } = 0.6;

        public double maintenanceRatio { get; set; } = 1.05;

        public int bend_G { get; set; } = 35;

        public int bend_Massa { get; set; } = 25;

        public int drill_G { get; set; } = 45;

        public int drill_Massa { get; set; } = 25;
    }
}
