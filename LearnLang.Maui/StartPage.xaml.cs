using LearnLang.Libraries;

namespace LearnLang.Maui;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        //label1.Text = Lang.asd;
        label1.Text = String.Format("Введите \"{0}\" по англиски", Lang.word[Lang.Index].Rus);
    }

    async void OnButtonClickedValidate(object sender, EventArgs args)
    {
        if (textBox1.Text == Lang.word[Lang.Index].Eng)
        {
            label1.Text = "Правильно";
            Lang.Count++;
        }
        else
        {
            label1.Text = "Неправильно";
        }
    }

    async void OnButtonClickedNext(object sender, EventArgs args)
    {
        if (Lang.word.Length != Lang.Index + 1)
        {
            ++Lang.Index;
            label1.Text = String.Format("Введите \"{0}\" по англиски", Lang.word[Lang.Index].Rus);
        }
        else
        {
            label1.Text = String.Format("Количество верных слов: {0}", Lang.Count);
        }
    }
}