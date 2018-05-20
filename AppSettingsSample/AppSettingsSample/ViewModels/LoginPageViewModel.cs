using System.Threading.Tasks;
using System.Windows.Input;
using AppSettingsSample.Views;
using Xamarin.Forms;

namespace AppSettingsSample.ViewModels
{
    public class LoginPageViewModel : BasePageViewModel {

        public ICommand LoginCommand { get; private set; }

        public LoginPageViewModel(INavigation navigation){
            _navigation = navigation;

            LoginCommand = new Command(() =>  UpdateUserInfo()); 
        }

        void UpdateUserInfo() {
            _navigation.PushAsync(new HomePage());
        }
    }
}
