using ReciboDigital.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Emitente : ContentPage
	{
		public Emitente()
		{
			InitializeComponent();
            this.BindingContext = new EmitenteViewModel();
		}
	}
}