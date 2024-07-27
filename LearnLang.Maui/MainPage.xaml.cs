using LearnLang.Libraries;

namespace LearnLang.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Words.Parser();
        }

        async void OnButtonClickedMix(object sender, EventArgs args)
        {
            Words.Mix();
        }

        async void OnButtonClickedStart(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new StartPage());
        }
    }

}
