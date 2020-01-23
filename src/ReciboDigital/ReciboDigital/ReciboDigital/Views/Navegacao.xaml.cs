
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciboDigital.Views
{
	public partial class Navegacao : NavigationPage
    {
		public Navegacao ()
		{
			InitializeComponent ();
		}
        public Navegacao(Page root) : base(root)
        {
        }
    }
}