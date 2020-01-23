using ReciboDigital.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent();
            this.BindingContext = new PrincipalViewModel();
		}
	}
}