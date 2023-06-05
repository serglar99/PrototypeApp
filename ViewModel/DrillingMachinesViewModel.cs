using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Windows;

namespace PrototypeApp.ViewModel
{
    internal class DrillingMachineViewModel : MainViewModel
    {
        public static Guid Id { get; set; }

        public static string D_Name { get; set; }

        public static string Company { get; set; }

        public static string Country { get; set; }

        public static string Town { get; set; }

        public static int Cost { get; set; }

        public static int CostM { get; set; }

        public static string Date { get; set; }

        public static int Time { get; set; }

        public static double Massa { get; set; }

        public static string LBH { get; set; }

        public static int Energ { get; set; }

        public static int SumN { get; set; }

        public static int NUN { get; set; }

        public static int NGN { get; set; }

        public static string VI { get; set; }

        public static int Dmax { get; set; }

        public static int E1 { get; set; }

        public static int E2 { get; set; }

        public static int Emax { get; set; }

        private RelayCommand saveDrillingMachine;
        public RelayCommand SaveDrillingMachine
        {
            get
            {
                return saveDrillingMachine ?? (saveDrillingMachine = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                    if (D_Name == null || D_Name == "")
                    {
                        ChangeBorder(wnd, "D_NameBlock");
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
                        
                     if (LBH == null || LBH == "")
                     {
                         ChangeBorder(wnd, "VIBlock");
                     }
                    if (Cost == 0 || Dmax == 0 || CostM == 0 || Time == 0 || Massa == 0 ||  SumN == 0 || NUN == 0 || NGN == 0 || E1 == 0 || E2 == 0 || Emax == 0 || Energ == 0)
                    {
                        ShowMessageToUser("Введены неполные данные. Значения не должны быть 0");
                    }
                    else
                    {
                        strResponse = DbService.SaveDrillingMachine(Id, D_Name, Company, Country, Town, Cost, CostM, Date,Time, Massa, LBH, Energ,SumN, NUN, NGN, VI, Dmax, E1, E2, Emax);
                        UpdateDrillingMachines();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    }
                }));
            }
        }
    }
}
