using ReciboDigital.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Recebedor : ContentPage
	{
		public Recebedor()
		{
			InitializeComponent();
            this.BindingContext = new RecebedorViewModel();
        }
	}
}