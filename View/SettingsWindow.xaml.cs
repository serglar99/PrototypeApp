using PrototypeApp.Model;
using PrototypeApp.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace PrototypeApp.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
         public SettingsWindow(Settings selectedSetting)
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
            SettingsViewModel.Ks = selectedSetting.Ks;
            SettingsViewModel.F = selectedSetting.F;
            SettingsViewModel.G = selectedSetting.G;
            SettingsViewModel.Mb = selectedSetting.Mb;
            SettingsViewModel.Pb = selectedSetting.Pb;
            SettingsViewModel.Kzb= selectedSetting.Kzb;
            SettingsViewModel.Kbpod = selectedSetting.Kbpod;
            SettingsViewModel.Pd = selectedSetting.Pd;
            SettingsViewModel.Kzd = selectedSetting.Kzd;
            SettingsViewModel.Kdpod = SettingsViewModel.Kdpod;
            SettingsViewModel.Kzc = SettingsViewModel.Kzc;
            SettingsViewModel.Kcpod = SettingsViewModel.Kcpod;
            SettingsViewModel.Isv = selectedSetting.Isv;
            SettingsViewModel.An = selectedSetting.An;
            SettingsViewModel.Kzw = selectedSetting.Kzw;
            SettingsViewModel.Kn = selectedSetting.Kn;       
        }
    }
}
