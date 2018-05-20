using AppSettingsSample.Helpers;
using AppSettingsSample.Views;
using Xamarin.Forms;

namespace AppSettingsSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            OnAppStart();
        }

        public void OnAppStart()
        {
            if (string.IsNullOrEmpty(UserSettings.UserName) && string.IsNullOrEmpty(UserSettings.Password))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new HomePage());
            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
