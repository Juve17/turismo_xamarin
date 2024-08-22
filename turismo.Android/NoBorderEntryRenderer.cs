using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using turismo.Droid;
[assembly: ExportRenderer(typeof(Entry), typeof(NoBorderEntryRenderer))]

namespace turismo.Droid
{
    public class NoBorderEntryRenderer : EntryRenderer
    {
        public NoBorderEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }
}