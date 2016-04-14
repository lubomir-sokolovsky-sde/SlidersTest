using SlidersTest;
using SlidersTest.UWP;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(StepsSlider), typeof(StepsSliderRenderer))]
namespace SlidersTest.UWP
{
    public class StepsSliderRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            var accurateSlider = e.NewElement as StepsSlider;

            if(Control != null
                && accurateSlider != null)
            {
                Control.IsThumbToolTipEnabled = false;

                if (accurateSlider.Minimum == 0
                    && accurateSlider.Maximum == 1)
                {
                    Control.StepFrequency = 1.0 / (double)accurateSlider.Steps;
                }
            }
        }
    }
}
