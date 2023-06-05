using PrototypeApp.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace PrototypeApp.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListView AllDrillingMachines;
        public static ListView AllBendingMachines;
        public static ListView AllWeldingMachines;
        public static ListView AllCuttingMachines;
        public static ListView AllReports;
        public static ListView AllCompanies;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            AllReports = ViewAllReports;
            AllBendingMachines = ViewAllBendingMachines;
            AllDrillingMachines = ViewAllDrillingMachines;
            AllWeldingMachines = ViewAllWeldingMachines;
            AllCuttingMachines = ViewAllCuttingMachines;
            AllCompanies = ViewAllCompanies;
        }
    }
}
