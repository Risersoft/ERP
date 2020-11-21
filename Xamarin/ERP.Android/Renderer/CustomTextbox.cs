using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Maximprise.Droid.Renderer;
using Maximprise.XF.CRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TextBox),typeof(CustomTextbox))]
namespace Maximprise.Droid.Renderer
{
   public class CustomTextbox: EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.rounded_corners);
                Control.Gravity = GravityFlags.CenterVertical;
                Control.SetPadding(10, 0, 0, 0);
            }
        }
    }
}