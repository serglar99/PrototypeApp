using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Windows;

namespace PrototypeApp.ViewModel
{
    internal class CuttingMachineViewModel : MainViewModel
    {
        public static Guid Id { get; set; }

        public static string C_Name { get; set; }

        public static string Company { get; set; }

        public static string Country { get; set; }

        public static string Town { get; set; }

        public static int Cost { get; set; }

        public static int CostM { get; set; }

        public static string Date { get; set; }

        public static int Time { get; set; }

        public static int L { get; set; }

        public static int B { get; set; }

        public static int Vmax { get; set; }

        public static int Vtra { get; set; }

        public static int Abr { get; set; }

        public static int Vs { get; set; }

        public static int Massa { get; set; }

        public static int Energ { get; set; }

        public static int NUN { get; set; }

        public static int NGN { get; set; }

        public static string VI { get; set; }

        public static string AbrM { get; set; }

        public static int Ppump { get; set; }

        public static int Pnom { get; set; }

        private RelayCommand saveCuttingMachine;
        public RelayCommand SaveCuttingMachine
        {
            get
            {
                return saveCuttingMachine ?? (saveCuttingMachine = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                    if (C_Name == null || C_Name == "")
                    {
                        ChangeBorder(wnd, "C_NameBlock");
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
                    if (AbrM == null || AbrM == "") 
                    {
                        ChangeBorder(wnd, "AbrMBlock");
                    }
                    if (Cost == 0 || CostM == 0 || Time == 0 || Massa == 0 || L == 0 || B == 0 || Vmax == 0 || Vtra == 0 || Abr == 0 || Vs == 0 || NUN == 0 || NGN == 0 || Ppump == 0 || Pnom == 0 || Energ == 0)
                    {
                        ShowMessageToUser("Введены неполные данные. Значения не должны быть 0");
                    }
                    else
                    {
                        strResponse = DbService.SaveCuttingMachine(Id, C_Name, Company, Country, Town, Cost, CostM, Date, Time, L, B, Vmax, Vtra, Abr, Vs, Massa, Energ, NUN, NGN, VI, AbrM, Ppump, Pnom);
                        UpdateCuttingMachines();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    }
                }));
            }
        }
    }
}
