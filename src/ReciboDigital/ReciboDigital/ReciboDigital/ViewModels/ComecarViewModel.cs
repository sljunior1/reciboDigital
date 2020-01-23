using ReciboDigital.Interfaces;
using ReciboDigital.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReciboDigital.ViewModels
{
    public class ComecarViewModel : INotifyPropertyChanged
    {
        private INavigationService _navigationService;

        public ICommand ComecarCommand { get; set; }

        public ComecarViewModel(INavigationService naviagtionService)
        {
            ComecarCommand = new Command(BtnComecar_Click);
            _navigationService = naviagtionService;
        }

        void BtnComecar_Click()
        {
            _navigationService.NavigateAsync(new Principal());
        }

        #region INotifiPropertyChanged Implement
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}