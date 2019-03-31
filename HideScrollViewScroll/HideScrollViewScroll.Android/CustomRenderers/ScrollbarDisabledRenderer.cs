using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using HideScrollViewScroll.Droid.CustomRenderers;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(ScrollView), typeof(ScrollbarDisabledRenderer))]
namespace HideScrollViewScroll.Droid.CustomRenderers
{
    public class ScrollbarDisabledRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.HorizontalScrollBarEnabled = false;
            this.VerticalScrollBarEnabled = false;
        }
    }
}