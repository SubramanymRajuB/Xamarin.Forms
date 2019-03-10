using System.IO;
using System.Reflection;
using LocalJsonParsing.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace LocalJsonParsing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetJsonData();
        }

        void GetJsonData()
        {
            string jsonFileName = "contacts.json";
            ContactList ObjContactList = new ContactList();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list  
                ObjContactList = JsonConvert.DeserializeObject<ContactList>(jsonString);
            }
            //Binding listview with json string   
            listviewConacts.ItemsSource = ObjContactList.contacts;
        }
    }

}

