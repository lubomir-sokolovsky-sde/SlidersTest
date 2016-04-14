using System;
using Xamarin.Forms;

namespace SlidersTest
{
    public class StepsSlider : Slider
    {
        public static readonly BindableProperty StepsProperty =
               BindableProperty.Create<StepsSlider, int>(p => p.Steps, 1000, BindingMode.TwoWay);

        public StepsSlider()
        {
            // default according to Android
            Steps = 1000;
        }

        // currently implemented only on Windows
        // does work only if Minimum and Maximum are set to default
        public int Steps
        {
            get { return (int)GetValue(StepsProperty); }
            set { SetValue(StepsProperty, value); }
        }
    }
}
