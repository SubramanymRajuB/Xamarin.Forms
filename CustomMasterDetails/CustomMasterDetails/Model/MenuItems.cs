using System;
namespace CustomMasterDetails.Model
{
    public enum MenuItemType
    {
        Community,
        Messages,
        Settings,
        Logout
    }
    public class MenuItems
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }
    }
}
