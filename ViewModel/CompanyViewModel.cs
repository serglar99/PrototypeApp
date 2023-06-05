using PrototypeApp.Model;
using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using System;
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Documents;

namespace PrototypeApp.ViewModel
{
    internal class CompanyViewModel : MainViewModel
    {
        public static Guid Id { get; set; }

        public static string Com_Name { get; set; }

        public static int Region { get; set; } = 1;

        public static int Shift { get; set; } = 1;

        public static int Week { get; set; } = 40;

        public static int Vprog { get; set; }

        public static string Program { get; set; }

        public static string AppProgram { get; set; }

        public static int Rm { get; set; }

        public static int CountM { get; set; }

        private RelayCommand saveCompany;

        public RelayCommand SaveCompany
        {
            get
            {
                return saveCompany ?? (saveCompany = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                    if (Com_Name == null || Com_Name == "")
                    {
                        ChangeBorder(wnd, "Com_NameBlock");
                    }
                    if (Program == null || Program == "")
                    {
                        ChangeBorder(wnd, "ProgramBlock");
                    }
                    if (AppProgram == null || AppProgram == "")
                    {
                        ChangeBorder(wnd, "AppProgramBlock");
                    }
                    if (Region == 0 || Shift == 0 || Week == 0 || Vprog == 0 || Rm == 0 || CountM == 0)
                    {
                        ShowMessageToUser("Введены неполные данные. Значения не должны быть 0");
                    }
                    else
                    {
                        strResponse = DbService.SaveCompany(Id, Com_Name, Region, Shift, Week, Vprog, Program, AppProgram, Rm, CountM);
                        UpdateCompanies();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    }
                }));
            }
        }
    }
}

