using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Biletix.Droid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("UnlinedGroup")]
[assembly: ExportEffect(typeof(AndroidUnlinedEffect), "UnlinedEffect")]
//remove underline entry&picker&datepicker 
namespace Biletix.Droid
{
    class AndroidUnlinedEffect :PlatformEffect
    {
        public AndroidUnlinedEffect()
        {

        }

        protected override void OnAttached()
        {
            try
            {
                if (Control != null)
                {
                    Android.Graphics.Color entry_line_color = Android.Graphics.Color.White;
                    Control.BackgroundTintList = ColorStateList.ValueOf(entry_line_color);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("err",ex.Message);
            }
        }

        protected override void OnDetached()
        {
            
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }
    }
}