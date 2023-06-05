using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для EditPositionWindow.xaml
    /// </summary>
    public partial class DrillingMachineWindow : Window
    {
        public DrillingMachineWindow(DrillingMachine selectedDrillingMachine)
        {
            InitializeComponent();
            DataContext = new DrillingMachineViewModel();
            DrillingMachineViewModel.Id = selectedDrillingMachine.Id;
            DrillingMachineViewModel.D_Name = selectedDrillingMachine.D_Name;
            DrillingMachineViewModel.Company = selectedDrillingMachine.Company;
            DrillingMachineViewModel.Country = selectedDrillingMachine.Country;
            DrillingMachineViewModel.Town = selectedDrillingMachine.Town;
            DrillingMachineViewModel.Cost = selectedDrillingMachine.Cost;
            DrillingMachineViewModel.CostM = selectedDrillingMachine.CostM;
            DrillingMachineViewModel.Date = selectedDrillingMachine.Date;
            DrillingMachineViewModel.Time = selectedDrillingMachine.Time;
            DrillingMachineViewModel.Massa = selectedDrillingMachine.Massa;
            DrillingMachineViewModel.LBH = selectedDrillingMachine.LBH;
            DrillingMachineViewModel.Energ = selectedDrillingMachine.Energ;
            DrillingMachineViewModel.SumN = selectedDrillingMachine.SumN;
            DrillingMachineViewModel.NUN = selectedDrillingMachine.NUN;
            DrillingMachineViewModel.NGN = selectedDrillingMachine.NGN;
            DrillingMachineViewModel.VI = selectedDrillingMachine.VI;
            DrillingMachineViewModel.Dmax = selectedDrillingMachine.Dmax;
            DrillingMachineViewModel.E1 = selectedDrillingMachine.E1;
            DrillingMachineViewModel.E2 = selectedDrillingMachine.E2;
            DrillingMachineViewModel.Emax = selectedDrillingMachine.Emax;
           
        }

        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
