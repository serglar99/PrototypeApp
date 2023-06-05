using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для CuttingMachineWindow.xaml
    /// </summary>
    public partial class CuttingMachineWindow : Window
    {
        public CuttingMachineWindow(CuttingMachine selectedCuttingMachine)
        {
            InitializeComponent();
            DataContext = new CuttingMachineViewModel();
            CuttingMachineViewModel.Id = selectedCuttingMachine.Id;
            CuttingMachineViewModel.C_Name = selectedCuttingMachine.C_Name;
            CuttingMachineViewModel.Company = selectedCuttingMachine.Company;
            CuttingMachineViewModel.Country = selectedCuttingMachine.Country;
            CuttingMachineViewModel.Town = selectedCuttingMachine.Town;
            CuttingMachineViewModel.Cost = selectedCuttingMachine.Cost;
            CuttingMachineViewModel.CostM = selectedCuttingMachine.CostM;
            CuttingMachineViewModel.Date = selectedCuttingMachine.Date;
            CuttingMachineViewModel.Time = selectedCuttingMachine.Time;
            CuttingMachineViewModel.L = selectedCuttingMachine.L;
            CuttingMachineViewModel.B = selectedCuttingMachine.B;
            CuttingMachineViewModel.Vmax = selectedCuttingMachine.Vmax;
            CuttingMachineViewModel.Vtra = selectedCuttingMachine.Vtra;
            CuttingMachineViewModel.Abr = selectedCuttingMachine.Abr;
            CuttingMachineViewModel.Vs = selectedCuttingMachine.Vs;
            CuttingMachineViewModel.Massa = selectedCuttingMachine.Massa;
            CuttingMachineViewModel.Energ = selectedCuttingMachine.Energ;
            CuttingMachineViewModel.NUN = selectedCuttingMachine.NUN;
            CuttingMachineViewModel.NGN = selectedCuttingMachine.NGN;
            CuttingMachineViewModel.VI = selectedCuttingMachine.VI;
            CuttingMachineViewModel.AbrM = selectedCuttingMachine.AbrM;
            CuttingMachineViewModel.Ppump = selectedCuttingMachine.Ppump;
            CuttingMachineViewModel.Pnom = selectedCuttingMachine.Pnom;
        }
        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

}
