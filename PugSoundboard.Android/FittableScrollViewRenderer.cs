using System;
using Android.Content;
using PugSoundboard.Droid;
using PugSoundboard.views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FittableScrollView), typeof(FittableScrollViewRenderer))]
namespace PugSoundboard.Droid
{
    public class FittableScrollViewRenderer : ScrollViewRenderer
    {
        public FittableScrollViewRenderer(Context context) : base(context)
        {
            SetFitsSystemWindows(true);
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            
        }
    }
}
