using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReciboDigital.Interfaces
{
    public interface INavigationService
    {
        Task NavigateAsync(Page page);
        Task NavigateBack();
    }
}
