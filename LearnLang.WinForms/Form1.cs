using LearnLang.Libraries;

namespace LearnLang.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lang.Parser(@"C:\MY\Dict.json");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            label1.Text = String.Format("Введите \"{0}\" по англиски", Lang.word[0].Rus);
        }

        private void Mix_Click(object sender, EventArgs e)
        {
            Lang.Mix();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Lang.Index = 0;
        }

        private void Next_Click(object sender, EventArgs e)
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

        private void Validate_Click(object sender, EventArgs e)
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
    }
}
