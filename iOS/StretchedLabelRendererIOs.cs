using CoreGraphics;
using CrossPlatformExample;
using CrossPlatformExample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StretchedLabel), typeof(StretchedLabelRendererIOs))]
namespace CrossPlatformExample.iOS
{
    public class StretchedLabelRendererIOs : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            StretchedLabel label = (StretchedLabel)e.NewElement;
            CGAffineTransform old = Control.Transform;
            CGAffineTransform t = new CGAffineTransform(old.xx, old.yx, old.xy, old.yy, old.x0, old.y0);
            t.Scale(label.Factor, 1);
            Control.Transform = t;
        }
    }
}
