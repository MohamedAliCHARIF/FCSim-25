using FCSim_25.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.Stores;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FCSim_25.ViewModels
{
    class StartViewModel : ViewModelBase
    {
        public ICommand NavigateStartCommand { get; }

        public StartViewModel(NavigationStore navigationStore)
        {
            NavigateStartCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore)));
        }
    }
}
