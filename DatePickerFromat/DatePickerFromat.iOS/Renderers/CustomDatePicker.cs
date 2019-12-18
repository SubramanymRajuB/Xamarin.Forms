using System.ComponentModel;
using System.Globalization;
using DatePickerFromat.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DatePicker), typeof(CustomDatePicker))]
namespace DatePickerFromat.iOS.Renderers
{
    public class CustomDatePicker : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control != null)
            {
                this.Control.Text = Element.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)?.Replace("-", "/");
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Element != null && Control != null)
            {
                this.Control.Text = Element.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)?.Replace("-", "/");
            }
        }

    }
}
