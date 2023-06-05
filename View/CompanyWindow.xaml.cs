using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для CompanyWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {
        public CompanyWindow(Company selectedCompany)
        {
            InitializeComponent();
            DataContext = new CompanyViewModel();
            CompanyViewModel.Id= selectedCompany.Id;
            CompanyViewModel.Com_Name = selectedCompany.Com_Name;
            CompanyViewModel.Region = selectedCompany.Region;
            CompanyViewModel.Shift = selectedCompany.Shift;
            CompanyViewModel.Week = selectedCompany.Week;
            CompanyViewModel.Vprog = selectedCompany.Vprog;
            CompanyViewModel.Program = selectedCompany.Program;
            CompanyViewModel.AppProgram = selectedCompany.AppProgram;
            CompanyViewModel.Rm = selectedCompany.Rm;
            CompanyViewModel.CountM = selectedCompany.CountM;
        }
    }
}
