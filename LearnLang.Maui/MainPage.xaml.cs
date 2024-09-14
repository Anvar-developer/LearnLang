using LearnLang.Libraries;

namespace LearnLang.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On();
        }

        async void OnButtonClickedMix(object sender, EventArgs args)
        {
            Lang.Mix();
        }

        async void OnButtonClickedStart(object sender, EventArgs args)
        {
            Lang.Index = 0;
            Lang.Count = 0;
            await Navigation.PushAsync(new StartPage());
        }

        private async void On()
        {
            //await DisplayAlert("asd", "asd", "asd");
            await Task.Delay(1);
            var r = await FilePicker.Default.PickAsync();
            Lang.Parser(r.FullPath);
        }
    }
}
