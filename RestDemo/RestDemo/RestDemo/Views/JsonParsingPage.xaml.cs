using Newtonsoft.Json;
using RestDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JsonParsingPage : ContentPage
    {
        public JsonParsingPage()
        {
            InitializeComponent();
            GetJSON();
        }
        public async void GetJSON()
        {
            //Check network status 
            if (NetworkCheck.IsInternet())
            {
             
                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync("http://api.androidhive.info/contacts/");
                string contactsJson = response.Content.ReadAsStringAsync().Result;
                ContactList ObjContactList = new ContactList();
                if (contactsJson != "")
                {
                    //Converting JSON Array Objects into generic list
                    ObjContactList = JsonConvert.DeserializeObject<ContactList>(contactsJson);
                }
                //Binding listview with server response  
                listviewConacts.ItemsSource = ObjContactList.contacts;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
            }
            //Hide loader after server response  
            ProgressLoader.IsVisible = false;
        }
        
        private void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelectedData = e.SelectedItem as Contact;
            Navigation.PushAsync(new JsonDetailsPage(itemSelectedData));
        }
    }
}
