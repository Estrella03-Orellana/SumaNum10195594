using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNum10195594.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double total;

        [ObservableProperty]
        private double numero1;

        [ObservableProperty]
        private double numero2;

        [RelayCommand]
        public void SumaTotal()
        {
            Total = Numero1 + Numero2;
        }
    }
}
