using System;
using System.Collections.Generic;
using HideListViewScroll.Model;

namespace HideListViewScroll.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {

        List<Contact> _contactList;
        public List<Contact> ContactList
        {
            get => _contactList;
            set
            {
                _contactList = value;
                NotifyPropertyChanged("ContactList");
            }
        }

        public MainPageViewModel()
        {
            GetContactLis();
        }

        void GetContactLis()
        {
            ContactList = new List<Contact>();
            ContactList.Add(new Contact() { Name = "Subramanyam" });
            ContactList.Add(new Contact() { Name = "Thomas KN" });
            ContactList.Add(new Contact() { Name = "Raju Bala" });
            ContactList.Add(new Contact() { Name = "Sudheer Varma" });
            ContactList.Add(new Contact() { Name = "Test FirstName" });
            ContactList.Add(new Contact() { Name = "Last Name" });
            ContactList.Add(new Contact() { Name = "Sudheer Varma" });
            ContactList.Add(new Contact() { Name = "Test FirstName" });
            ContactList.Add(new Contact() { Name = "Last Name" });
        }
    }
}
