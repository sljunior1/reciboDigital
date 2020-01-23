using ReciboDigital.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Vizualizar : ContentPage
	{
		public Vizualizar()
		{
			InitializeComponent();
            this.BindingContext = new VisualizarViewModel();
        }
	}
}