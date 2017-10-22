using CrossPlatformExample;
using CrossPlatformExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(StretchedLabel), typeof(StretchedLabelRendererDroid))]
namespace CrossPlatformExample.Droid
{
    public class StretchedLabelRendererDroid : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            StretchedLabel label = (StretchedLabel)e.NewElement;
            Control.TextScaleX = label.Factor;
        }
    }
}
