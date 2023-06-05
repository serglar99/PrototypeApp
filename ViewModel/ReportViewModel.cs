using PrototypeApp.Services;
using PrototypeApp.ViewModel.Commands;
using PrototypeApp.Model;
using System;
using System.Windows;

namespace PrototypeApp.ViewModel
{
    internal class ReportViewModel : MainViewModel
    {
        public int BendingMachinesAmount { get; set; }

        public int DrillingMachinesAmount { get; set; }

        public int CuttingMachinesAmount { get; set; }

        public int WeldingMachinesAmount { get; set; }

        public DateTime ReportCreatedAt { get; set; }

        public Guid DrillingMachineId { get; set; }
        public Guid CuttingMachineId { get; set; }
        public Guid WeldingMachineId { get; set; }
        public Guid BendingMachineId { get; set; }
        public Guid SelectedCompany { get; set; }

        private RelayCommand addNewReport;
        public RelayCommand AddNewReport
        {
            get
            {
                return addNewReport ?? (addNewReport = new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string strResponse = "";
                
                        strResponse = DbService.CreateReport(SelectedCompany);
                        UpdateReports();

                        ShowMessageToUser(strResponse);
                        wnd.Close();
                    
                }));
            }
        }
    }
}
