using LearnLang.Libraries;

namespace LearnLang.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Words.Parser();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            label1.Text = String.Format("Введите \"{0}\" по англиски", Words.word[0].Rus);
        }

        private void Mix_Click(object sender, EventArgs e)
        {
            Words.Mix();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Words.Index = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Words.word.Length != Words.Index + 1)
            {
                ++Words.Index;
                label1.Text = String.Format("Введите \"{0}\" по англиски", Words.word[Words.Index].Rus);
            }
            else
            {
                label1.Text = String.Format("Количество верных слов: {0}", Words.Count);
            }
        }

        private void Validate_Click(object sender, EventArgs e)
        {         
            //if (Words.Index < Words.word.Length + 1)
            {
                if (textBox1.Text == Words.word[Words.Index].Eng)
                {
                    label1.Text = "Правильно";
                    Words.Count++;
                }
                else
                {
                    label1.Text = "Неправильно";
                }
            }
        }
    }
}
