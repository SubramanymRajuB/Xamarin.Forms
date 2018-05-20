using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace FormsXamlCSS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //this.Resources.Add(StyleSheet.FromAssemblyResource(
                //IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly,
                //"FormsXamlCSS.Assets.styles.css"));

            //using (var reader = new StringReader("^contentpage { background-color: lightgray; }"))
            //{
            //    this.Resources.Add(StyleSheet.FromReader(reader));
            //}
        }
    }
}
