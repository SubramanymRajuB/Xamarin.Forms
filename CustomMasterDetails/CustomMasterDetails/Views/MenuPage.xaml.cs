using System;
using System.Collections.Generic;
using CustomMasterDetails.Model;
using Xamarin.Forms;

namespace CustomMasterDetails.Views
{
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<MenuItems> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            menuItems = new List<MenuItems>
            {
                new MenuItems {Id = MenuItemType.Community, Title="Give Feedback", Image="givefeedback.png"},
                new MenuItems {Id = MenuItemType.Messages, Title="Messages", Image="message.png"},
                new MenuItems {Id = MenuItemType.Settings, Title="Settings", Image="settings.png"},
                new MenuItems {Id = MenuItemType.Logout, Title="Log Out", Image="logout.png"}
            };
            menuList.ItemsSource = menuItems;

            menuList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;
                (Application.Current.MainPage as MasterDetailPage).IsPresented = false;
                menuList.SelectedItem = null;
            };
        }
    }
}
