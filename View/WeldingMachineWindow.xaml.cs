using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;


namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для WeldiingMachineWindow.xaml
    /// </summary>
    public partial class WeldingMachineWindow : Window
    {
        public WeldingMachineWindow(WeldingMachine selectedWeldingMachine)
        {
            InitializeComponent();
            DataContext = new WeldingMachineViewModel();
            WeldingMachineViewModel.Id = selectedWeldingMachine.Id;
            WeldingMachineViewModel.V_Name = selectedWeldingMachine.V_Name;
            WeldingMachineViewModel.Company = selectedWeldingMachine.Company;
            WeldingMachineViewModel.Country = selectedWeldingMachine.Country;
            WeldingMachineViewModel.Town = selectedWeldingMachine.Town;
            WeldingMachineViewModel.Cost = selectedWeldingMachine.Cost;
            WeldingMachineViewModel.CostM = selectedWeldingMachine.CostM;
            WeldingMachineViewModel.Date = selectedWeldingMachine.Date;
            WeldingMachineViewModel.Time = selectedWeldingMachine.Time;
            WeldingMachineViewModel.Massa = selectedWeldingMachine.Massa;
            WeldingMachineViewModel.LBH = selectedWeldingMachine.LBH;
            WeldingMachineViewModel.Pmax = selectedWeldingMachine.Pmax;
            WeldingMachineViewModel.NUN = selectedWeldingMachine.NUN;
            WeldingMachineViewModel.NGN = selectedWeldingMachine.NGN;
            WeldingMachineViewModel.VI = selectedWeldingMachine.VI;
            WeldingMachineViewModel.Arg = selectedWeldingMachine.Arg;
            WeldingMachineViewModel.Parg = selectedWeldingMachine.Parg;
            WeldingMachineViewModel.Specification = selectedWeldingMachine.Specification;
        }
        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
