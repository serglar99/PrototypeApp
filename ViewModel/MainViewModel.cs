using PrototypeApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PrototypeApp.ViewModel.Commands;
using PrototypeApp.Services;
using PrototypeApp.Model;

namespace PrototypeApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region lists
        private List<Report> allReports = DbService.GetAllReports();
        public List<Report> AllReports
        {
            get 
            { 
                return allReports; 
            }
            private set
            {
                allReports = value;
                NotifyPropertyChanged("AllReports");
            }
        }

        private List<BendingMachine> allBendingMachines = DbService.GetAllBendingMachines();
        public List<BendingMachine> AllBendingMachines
        {
            get
            {
                return allBendingMachines;
            }
            private set
            {
                allBendingMachines = value;
                NotifyPropertyChanged("AllBendingMachines");
            }
        }

        private List<DrillingMachine> allDrillingMachines = DbService.GetAllDrillingMachines();
        public List<DrillingMachine> AllDrillingMachines
        {
            get
            {
                return allDrillingMachines;
            }
            private set
            {
                allDrillingMachines = value;
                NotifyPropertyChanged("AllDrillingMachines");
            }
        }

        private List<CuttingMachine> allCuttingMachines = DbService.GetAllCuttingMachines();
        public List<CuttingMachine> AllCuttingMachines
        {
            get
            {
                return allCuttingMachines;
            }
            private set
            {
                allCuttingMachines = value;
                NotifyPropertyChanged("AllCuttingMachines");
            }
        }

        private List<WeldingMachine> allWeldingMachines = DbService.GetAllWeldingMachines();
        public List<WeldingMachine> AllWeldingMachines
        {
            get
            {
                return allWeldingMachines;
            }
            private set
            {
                allWeldingMachines = value;
                NotifyPropertyChanged("AllWeldingMachines");
            }
        }

        private List<Company> allCompanies = DbService.GetAllCompanies();
        public List<Company> AllCompanies
        {
            get
            {
                return allCompanies;
            }
            private set
            {
                allCompanies = value;
                NotifyPropertyChanged("AllCompanies");
            }
        }
        #endregion

        #region selected items
        public TabItem SelectedTabItem { get; set; }
        public static DrillingMachine SelectedDrillingMachine { get; set; }

        public static WeldingMachine SelectedWeldingMachine { get; set; }

        public static CuttingMachine SelectedCuttingMachine { get; set; }
        public static BendingMachine SelectedBendingMachine { get; set; }
        public static Company SelectedCompany { get; set; }
        public static Report SelectedReport { get; set; }
        #endregion

        #region context menu
        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? (deleteItem = new RelayCommand(obj =>
                {
                    string strResponse = "Ничего не выбрано";

                    if(SelectedTabItem.Name == "DrillingMachinesTab" && SelectedDrillingMachine != null)
                    {
                        strResponse = DbService.DeleteDrillingMachine(SelectedDrillingMachine);
                        UpdateDrillingMachines();
                    }

                    if (SelectedTabItem.Name == "BendingMachinesTab" && SelectedBendingMachine != null)
                    {
                        strResponse = DbService.DeleteBendingMachine(SelectedBendingMachine);
                        UpdateBendingMachines();
                    }

                    if (SelectedTabItem.Name == "CuttingMachinesTab" && SelectedCuttingMachine != null)
                    {
                        strResponse = DbService.DeleteCuttingMachine(SelectedCuttingMachine);
                        UpdateCuttingMachines();
                    }

                    if (SelectedTabItem.Name == "WeldingMachinesTab" && SelectedWeldingMachine != null)
                    {
                        strResponse = DbService.DeleteWeldingMachine(SelectedWeldingMachine);
                        UpdateWeldingMachines();
                    }
                    if (SelectedTabItem.Name == "CompaniesTab" && SelectedCompany != null)
                    {
                        strResponse = DbService.DeleteCompany(SelectedCompany);
                        UpdateCompanies();
                    }
            

                    ShowMessageToUser(strResponse);
                }));
            }
        }

        private RelayCommand exportItem;
        public RelayCommand ExportItem
        {
            get
            {
                return exportItem ?? (exportItem = new RelayCommand(obj =>
                {
                    string strResponse = "Ничего не выбрано";

                    if (SelectedTabItem.Name == "ReportTab" && SelectedReport != null)
                    {
                        Report report = SelectedReport;
                        strResponse = PdfService.EditHtmlTemplate(report);
                    }

                    ShowMessageToUser(strResponse);
                }));
            }
        }
        #endregion

        #region openWindows
        private RelayCommand openAddNewReportWnd;
        public RelayCommand OpenAddNewReportWnd
        {
            get
            {
                return openAddNewReportWnd ?? (openAddNewReportWnd = new RelayCommand(obj =>
                {
                    OpenAddReportWindowMethod();
                }));
            }
        }

        private RelayCommand openAddItemWnd;
        public RelayCommand OpenAddItemWnd
        {
            get
            {
                return openAddItemWnd ?? (openAddItemWnd = new RelayCommand(obj =>
                {

                    if (SelectedTabItem.Name == "DrillingMachinesTab")
                    {
                        OpenAddDrillingMachineWindowMethod();
                    }
                   
                    if (SelectedTabItem.Name == "WeldingMachinesTab")
                    {
                        OpenAddWeldingMachineWindowMethod();
                    }
                    if (SelectedTabItem.Name == "BendingMachinesTab")
                    {
                        OpenAddBendingMachineWindowMethod();
                    }
                    if (SelectedTabItem.Name == "CuttingMachinesTab")
                    {
                        OpenAddCuttingMachineWindowMethod();
                    }
                    if (SelectedTabItem.Name == "CompaniesTab")
                    {
                        OpenAddCompanyWindowMethod();
                    }
                }));
            }
        }

        private RelayCommand openEditItemWnd;
        public RelayCommand OpenEditItemWnd
        {
            get
            {
                return openEditItemWnd ?? (openEditItemWnd =  new RelayCommand(obj =>
                {
                    string strResponse = "Ничего не выбрано";

                    if (SelectedDrillingMachine == null && SelectedBendingMachine == null && SelectedCuttingMachine == null && SelectedWeldingMachine == null && SelectedCompany == null)
                    {
                        ShowMessageToUser(strResponse);
                    }
                    if (SelectedTabItem.Name == "DrillingMachinesTab" && SelectedDrillingMachine != null)
                    {
                        OpenEditDrillingMachineWindowMethod(SelectedDrillingMachine);
                    }
                    if (SelectedTabItem.Name == "BendingMachinesTab" && SelectedBendingMachine != null)
                    {
                        OpenEditBendingMachineWindowMethod(SelectedBendingMachine);
                    }
                    if (SelectedTabItem.Name == "CuttingMachinesTab" && SelectedCuttingMachine != null)
                    {
                        OpenEditCuttingMachineWindowMethod(SelectedCuttingMachine);
                    }
                    if (SelectedTabItem.Name == "WeldingMachinesTab" && SelectedWeldingMachine != null)
                    {
                        OpenEditWeldingMachineWindowMethod(SelectedWeldingMachine);
                    }
                    if (SelectedTabItem.Name == "CompaniesTab" && SelectedCompany != null)
                    {
                        OpenEditCompanyWindowMethod(SelectedCompany);
                    }
                   
                }));
            }
        }
        #endregion

        #region windows open

        private void OpenAddReportWindowMethod()
        {
            AddNewReportWindow newReportWindow = new AddNewReportWindow();
            ShowWindow(newReportWindow);
        }

        private void OpenAddBendingMachineWindowMethod()
        {
            BendingMachine emptyModel = new BendingMachine();
            BendingMachineWindow bendingMachineWindow = new BendingMachineWindow(emptyModel);
            ShowWindow(bendingMachineWindow);
        }

        private void OpenAddDrillingMachineWindowMethod()
        {
            DrillingMachine emptyModel = new DrillingMachine();
            DrillingMachineWindow drillingMachineWindow = new DrillingMachineWindow(emptyModel);
            ShowWindow(drillingMachineWindow);
        }
        private void OpenAddCuttingMachineWindowMethod()
        {
            CuttingMachine emptyModel = new CuttingMachine();
            CuttingMachineWindow cuttingMachineWindow = new CuttingMachineWindow(emptyModel);
            ShowWindow(cuttingMachineWindow);
        }
        private void OpenAddWeldingMachineWindowMethod()
        {
            WeldingMachine emptyModel = new WeldingMachine();
            WeldingMachineWindow weldingMachineWindow = new WeldingMachineWindow(emptyModel);
            ShowWindow(weldingMachineWindow);
        }
        private void OpenAddCompanyWindowMethod()
        {
            Company emptyModel = new Company();
            CompanyWindow companyWindow = new CompanyWindow(emptyModel);
            ShowWindow(companyWindow);
        }
        private void OpenEditBendingMachineWindowMethod(BendingMachine bendingMachine)
        {
            BendingMachineWindow bendingMachineWindow = new BendingMachineWindow(bendingMachine);
            ShowWindow(bendingMachineWindow);
        }
        private void OpenEditWeldingMachineWindowMethod(WeldingMachine weldingMachine)
        {
            WeldingMachineWindow weldingMachineWindow = new WeldingMachineWindow(weldingMachine);
            ShowWindow(weldingMachineWindow);
        }
        private void OpenEditCuttingMachineWindowMethod(CuttingMachine cuttingMachine)
        {
            CuttingMachineWindow cuttingMachineWindow = new CuttingMachineWindow(cuttingMachine);
            ShowWindow(cuttingMachineWindow);
        }

        private void OpenEditDrillingMachineWindowMethod(DrillingMachine drillingMachine)
        {
            DrillingMachineWindow drillingMachineWindow = new DrillingMachineWindow(drillingMachine);
            ShowWindow(drillingMachineWindow);
        }
        private void OpenEditCompanyWindowMethod(Company company)
        {
            CompanyWindow companyWindow = new CompanyWindow(company);
            ShowWindow(companyWindow);
        }
        private void ShowWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        protected void ChangeBorder(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        protected void UpdateReports()
        {
            allReports = DbService.GetAllReports();
            MainWindow.AllReports.ItemsSource = null;
            MainWindow.AllReports.Items.Clear();
            MainWindow.AllReports.ItemsSource = allReports;
            MainWindow.AllReports.Items.Refresh();
        }

        protected void UpdateBendingMachines()
        {
            allBendingMachines = DbService.GetAllBendingMachines();
            MainWindow.AllBendingMachines.ItemsSource = null;
            MainWindow.AllBendingMachines.Items.Clear();
            MainWindow.AllBendingMachines.ItemsSource = allBendingMachines;
            MainWindow.AllBendingMachines.Items.Refresh();
        }

        protected void UpdateDrillingMachines()
        {
            allDrillingMachines = DbService.GetAllDrillingMachines();
            MainWindow.AllDrillingMachines.ItemsSource = null;
            MainWindow.AllDrillingMachines.Items.Clear();
            MainWindow.AllDrillingMachines.ItemsSource = allDrillingMachines;
            MainWindow.AllDrillingMachines.Items.Refresh();
        }
        protected void UpdateCuttingMachines()
        {
            allCuttingMachines = DbService.GetAllCuttingMachines();
            MainWindow.AllCuttingMachines.ItemsSource = null;
            MainWindow.AllCuttingMachines.Items.Clear();
            MainWindow.AllCuttingMachines.ItemsSource = allCuttingMachines;
            MainWindow.AllCuttingMachines.Items.Refresh();
        }
        protected void UpdateWeldingMachines()
        {
            allWeldingMachines = DbService.GetAllWeldingMachines();
            MainWindow.AllWeldingMachines.ItemsSource = null;
            MainWindow.AllWeldingMachines.Items.Clear();
            MainWindow.AllWeldingMachines.ItemsSource = allWeldingMachines;
            MainWindow.AllWeldingMachines.Items.Refresh();
        }
        protected void UpdateCompanies()
        {
            allCompanies = DbService.GetAllCompanies();
            MainWindow.AllCompanies.ItemsSource = null;
            MainWindow.AllCompanies.Items.Clear();
            MainWindow.AllCompanies.ItemsSource = allCompanies;
            MainWindow.AllCompanies.Items.Refresh();
        }

        protected void ShowMessageToUser(string message)
        {
            MessageView messageView = new MessageView(message);
            ShowWindow(messageView);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
