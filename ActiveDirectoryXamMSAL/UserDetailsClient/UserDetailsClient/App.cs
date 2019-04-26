using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

//Reference URL https://www.kompozure.com/blog/azure-ad-v2-and-msal-from-developers-point-of-view/
namespace UserDetailsClient
{
    public class App : Application
    {
        //https://zure.com/blog/azure-ad-v2-and-msal-from-developers-point-of-view/

        public static PublicClientApplication PCA = null;

        /// <summary>
        /// The ClientID is the Application ID found in the portal (https://apps.dev.microsoft.com). 
        /// You can use the below id however if you create an app of your own you should replace the value here.
        /// </summary>
        public static string ClientID = "c36b3df8-0657-40fa-a285-15b30f9de123"; //XamarinAuthV2 personal
        //public static string ClientID = "5e774379-57d0-460e-8057-2bd8f5461bbd"; //XamarinAuthV1 personal

        public static string[] Scopes = { "User.Read" };
        public static string Username = string.Empty;

        public static UIParent UiParent { get; set; }

        public App()
		{
            PCA = new PublicClientApplication(ClientID)//, "https://login.microsoftonline.com/918079db-c902-4e29-b22c-9764410d0375/v2.0")
            {
                RedirectUri = $"msal{ClientID}://auth"
            };

            MainPage = new UserDetailsClient.MainPage();
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
