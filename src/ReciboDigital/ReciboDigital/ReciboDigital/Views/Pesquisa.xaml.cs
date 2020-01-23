using ReciboDigital.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pesquisa : ContentPage
	{
		public Pesquisa()
		{
			InitializeComponent();
            this.BindingContext = new PesquisaViewModel();
        }
	}
}