using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Windows;

namespace PrototypeApp.ViewModel
{
    internal class WeldingMachineViewModel : MainViewModel
    {
        public static Guid Id { get; set; }

        public static string V_Name { get; set; }

        public static string Company { get; set; }

        public static string Country { get; set; }

        public static string Town { get; set; }

        public static int Cost { get; set; }

        public static int CostM { get; set; }

        public static string Date { get; set; }

        public static int Time { get; set; }

        public static int Massa { get; set; }

        public static int LBH { get; set; }

        public static int Pmax { get; set; }

        public static int NUN { get; set; }

        public static int NGN { get; set; }

        public static string VI { get; set; }

        public static int Arg { get; set; }

        public static int Parg { get; set; }

        public static string Specification { get; set; }

        private RelayCommand saveWeldingMachine;
        public RelayCommand SaveWeldingMachine
        {
            get
            {
                return saveWeldingMachine ?? (saveWeldingMachine = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                    if (V_Name == null || V_Name == "")
                    {
                        ChangeBorder(wnd, "V_NameBlock");
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
                    if (Specification == null || Specification == "")
                    {
                        ChangeBorder(wnd, "SpecificationBlock");
                    }
                    else
                    {
                        strResponse = DbService.SaveWeldingMachine(Id, V_Name, Company, Country, Town, Cost, CostM, Date, Time, Massa, LBH, Pmax, NUN, NGN, VI, Arg, Parg, Specification);
                        UpdateWeldingMachines();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    }
                }));
            }
        }
    }
}
