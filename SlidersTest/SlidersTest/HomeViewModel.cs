using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SlidersTest
{
    public class HomeViewModel : /*BindableObject*/ INotifyPropertyChanged
    {
        private int smallScale;
        private int largeScale;
        private int offset;
        private float smallFloat;
        private double largeDecimal;

        public event PropertyChangedEventHandler PropertyChanged;

        // 0-9
        public int SmallScale
        {
            get { return smallScale; }
            set
            {
                if (smallScale != value)
                {
                    if (value < 0)
                        smallScale = 0;
                    else if (value > 9)
                        smallScale = 9;
                    else
                        smallScale = value;
                    OnPropertyChanged();
                }
            }
        }

        // 0-999
        public int LargeScale
        {
            get { return largeScale; }
            set
            {
                if (largeScale != value)
                {
                    if (value < 0)
                        largeScale = 0;
                    else if (value > 1000)
                        largeScale = 1000;
                    else
                        largeScale = value;
                    OnPropertyChanged();
                }
            }
        }

        // 5-25
        public int Offset
        {
            get { return offset; }
            set
            {
                if(offset != value)
                {
                    if (value < 5)
                        offset = 5;
                    else if (value > 25)
                        offset = 25;
                    else
                        offset = value;
                    OnPropertyChanged();
                }
            }
        }

        // 0.0-9.0
        public float SmallFloat
        {
            get { return smallFloat; }
            set
            {
                if(smallFloat != value)
                {
                    if (value < 0)
                        smallFloat = 0;
                    else if (value > 9)
                        smallFloat = 9;
                    else
                        smallFloat = value;
                    OnPropertyChanged();
                }
            }
        }

        // 0.0-999.0
        public double LargeDecimal
        {
            get { return largeDecimal; }
            set
            {
                if(largeDecimal != value)
                {
                    if (value < 0)
                        largeDecimal = 0;
                    else if (value > 999)
                        largeDecimal = 999;
                    else
                        largeDecimal = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
