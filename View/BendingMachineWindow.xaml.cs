using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для EditPositionWindow.xaml
    /// </summary>
    public partial class BendingMachineWindow : Window
    {
        public BendingMachineWindow(BendingMachine selectedBendingMachine)
        {
            InitializeComponent();
            DataContext = new BendingMachineViewModel();
            BendingMachineViewModel.Id = selectedBendingMachine.Id;
            BendingMachineViewModel.G_Name = selectedBendingMachine.G_Name;
            BendingMachineViewModel.Company = selectedBendingMachine.Company;
            BendingMachineViewModel.Country = selectedBendingMachine.Country;
            BendingMachineViewModel.Town = selectedBendingMachine.Town;
            BendingMachineViewModel.Cost = selectedBendingMachine.Cost;
            BendingMachineViewModel.CostM = selectedBendingMachine.CostM;
            BendingMachineViewModel.Date = selectedBendingMachine.Date;
            BendingMachineViewModel.Time = selectedBendingMachine.Time;
            BendingMachineViewModel.Pkh= selectedBendingMachine.Pkh;
            BendingMachineViewModel.Ptc = selectedBendingMachine.Ptc;
            BendingMachineViewModel.Bmax = selectedBendingMachine.Bmax;
            BendingMachineViewModel.Lmax = selectedBendingMachine.Lmax;
            BendingMachineViewModel.Sod = selectedBendingMachine.Sod;
            BendingMachineViewModel.Sdv = selectedBendingMachine.Sdv;
            BendingMachineViewModel.Massa = selectedBendingMachine.Massa;
            BendingMachineViewModel.LBH = selectedBendingMachine.LBH;
            BendingMachineViewModel.Energ = selectedBendingMachine.Energ;
            BendingMachineViewModel.NUN = selectedBendingMachine.NUN;
            BendingMachineViewModel.NGN = selectedBendingMachine.NGN;
            BendingMachineViewModel.VI = selectedBendingMachine.VI;
        }

        private void   PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
