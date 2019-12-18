using System.ComponentModel;
using System.Globalization;
using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DatePicker), typeof(DatePicker))]
namespace DatePickerFromat.Droid.Renderers
{
    public class CustomDatePicker : DatePickerRenderer
    {
        public CustomDatePicker(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null && Control != null)
            {// creating gradient drawable for the curved background  
                var _gradientBackground = new GradientDrawable();
                _gradientBackground.SetShape(ShapeType.Rectangle);

                //_gradientBackground.SetColor(Android.Graphics.Color.Gray);

                // Thickness of the stroke line  
                _gradientBackground.SetStroke(1, Android.Graphics.Color.Gray);

                // Radius for the curves  
                _gradientBackground.SetCornerRadius(10);

                // set the background of the   
                Control.SetBackground(_gradientBackground);

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

