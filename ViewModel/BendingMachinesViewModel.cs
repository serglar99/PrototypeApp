using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Windows;
using System.Windows.Documents;

namespace PrototypeApp.ViewModel
{
    internal class BendingMachineViewModel : MainViewModel
    {
        public static Guid Id { get; set; }

        public static string G_Name { get; set; }

        public static string Company { get; set; }

        public static string Country { get; set; }

        public static string Town { get; set; }

        public static int Cost { get; set; }

        public static int CostM { get; set; }

        public static string Date { get; set; }

        public static int Time { get; set; }

        public static int Pkh { get; set; }

        public static int Ptc { get; set; }

        public static int Bmax { get; set; }

        public static int Lmax { get; set; }

        public static int Sod { get; set; }

        public static int Sdv { get; set; }

        public static int Massa { get; set; }

        public static int LBH { get; set; }

        public static int Energ { get; set; }

        public static int NUN { get; set; }

        public static int NGN { get; set; }

        public static string VI { get; set; }

        private RelayCommand saveBendingMachine;
        public RelayCommand SaveBendingMachine
        {
            get
            {
                return saveBendingMachine ?? (saveBendingMachine = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                    if (G_Name == null || G_Name =="") 
                    {
                        ChangeBorder(wnd, "G_NameBlock");
                    }
                    if (Company == null || Company == "")
                    {
                        ChangeBorder(wnd, "CompanyBlock");
                    }
                    if (Country == null || Country == "")
                    {
                        ChangeBorder(wnd, "CountryBlock");
                    }
                    if (Town == null || Town == "")
                    {
                        ChangeBorder(wnd, "TownBlock");
                    }
                    if (VI == null || VI == "")
                    {
                        ChangeBorder(wnd, "VIBlock");
                    }
                    
                    else 
                    {
                        strResponse = DbService.SaveBendingMachine(Id, G_Name, Country, Company, Town, Cost, CostM, Date, Time, Pkh, Ptc, Bmax, Lmax, Sod, Sdv, Massa, LBH, Energ, NUN, NGN, VI);
                        UpdateBendingMachines();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    }
                }));
            }
        }
    }
}
