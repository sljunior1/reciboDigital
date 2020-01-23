using ReciboDigital.Views;
using Xamarin.Forms;

namespace ReciboDigital
{
    public class Startup : Application
    {
        public Startup()
        {
            MainPage = new NavigationPage(new Comecar()) { BarBackgroundColor = Color.FromHex("#4791ea") };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
