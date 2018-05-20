using System;
using System.Collections.Generic;
using AppSettingsSample.ViewModels;
using Xamarin.Forms;

namespace AppSettingsSample.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel(Navigation);
        }
    }
}
