using PrototypeApp.ViewModel;
using PrototypeApp.Model;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    public partial class AddNewReportWindow : Window
    {
        public AddNewReportWindow()
        {
            InitializeComponent();
            DataContext = new ReportViewModel();
        }

        private void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
