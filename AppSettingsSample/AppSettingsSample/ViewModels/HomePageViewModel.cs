using System.Threading.Tasks;
using System.Windows.Input;
using AppSettingsSample.Helpers;
using AppSettingsSample.Views;
using Xamarin.Forms;

namespace AppSettingsSample.ViewModels
{
    public class HomePageViewModel: BasePageViewModel {
        public ICommand LogoutCommand { get; private set; }
        public HomePageViewModel(INavigation navigation) {
            _navigation = navigation;
            LogoutCommand = new Command(() =>  ResetUserInfo()); 
        }

        void ResetUserInfo()
        {
            _navigation.PushAsync(new LoginPage());
            UserSettings.ClearAllData();
        }
    }
}

