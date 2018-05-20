using System;
using System.Collections.Generic;
using AppSettingsSample.ViewModels;
using Xamarin.Forms;

namespace AppSettingsSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel(Navigation);
        }
    }
}
