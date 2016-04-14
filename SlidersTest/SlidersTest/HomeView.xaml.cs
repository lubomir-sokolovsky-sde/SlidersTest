using Xamarin.Forms;

namespace SlidersTest
{
    public partial class HomeView : ContentPage
    {
        private HomeViewModel viewModel;

        public HomeView()
        {
            viewModel = new HomeViewModel();
            viewModel.SmallScale = 1;
            viewModel.LargeScale = 222;
            viewModel.Offset = 11;
            viewModel.SmallFloat = 4.4f;
            viewModel.LargeDecimal = 555.5;
            BindingContext = viewModel;
            InitializeComponent();
        }

        void FirstValueChanged(object sender, ValueChangedEventArgs args)
        {
            viewModel.SmallScale = (int)args.NewValue;
        }
    }
}
