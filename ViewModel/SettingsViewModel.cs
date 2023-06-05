using PrototypeApp.Model;
using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Documents;
namespace PrototypeApp.ViewModel
{
    internal class SettingsViewModel : MainViewModel
    {
        public static double Ks { get; set; }

        public static int F { get; set; }

        public static double G { get; set; }

        public static int Mb { get; set; }

        public static double Pb { get; set; }

        public static double Kzb { get; set; }

        public static double Kbpod { get; set; }

        public static double Pd { get; set; }

        public static double Kzd { get; set; }

        public static double Kdpod { get; set; }

        public static double Kzc { get; set; }

        public static double Kcpod { get; set; }

        public static int Isv { get; set; }

        public static double An { get; set; }

        public static double Kzw { get; set; }

        public static double Kn { get; set; }

        private RelayCommand addSettings;

    }
}
