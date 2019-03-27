using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using HideListViewScroll.iOS.Renderers;

[assembly: ExportRenderer(typeof(ListView), typeof(CustomListViewRenderer))]
namespace HideListViewScroll.iOS.Renderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ShowsVerticalScrollIndicator = false;
                Control.ShowsHorizontalScrollIndicator = false;
            }
        }
    }
}
