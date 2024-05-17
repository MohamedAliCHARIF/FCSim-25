using FCSim_25.ViewModels;
using MVVMEssentials.Stores;
using MVVMEssentials.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FCSim_25
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();

            navigationStore.CurrentViewModel = new StartViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new ViewModels.MainViewModel(navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
