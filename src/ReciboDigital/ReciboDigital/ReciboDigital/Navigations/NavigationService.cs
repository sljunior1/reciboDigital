using ReciboDigital.Interfaces;
using ReciboDigital.Views;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReciboDigital.Navigations
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateAsync(Page page)
        {
            var currentPage = GetCurrentPage();
            if (currentPage?.Parent is NavigationPage)
                await currentPage.Navigation.PushAsync(page);
            else
                await currentPage.Navigation.PushModalAsync(page);
        }

        public Task NavigateBack()
        {
            throw new NotImplementedException();
        }

        private Page GetCurrentPage()
        {
            var currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

            return currentPage;
        }
    }
}
