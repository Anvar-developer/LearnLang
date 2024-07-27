using static System.Console;
using LearnLang.Libraries;
using System;

namespace LearnLang.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Words.Parser();

            DefualtForegraundColor();

            string inputWord;

            while (true)
            {
                WriteLine("Введите действие (exit, mix)");
                inputWord = ReadLine();
       
                    switch (inputWord)
                    {
                        case "exit":
                            goto Exit;

                        case "mix":
                            Words.Mix();
                            break;
                    }

                for (int i = 0; i < Words.word.Length; i++)
                {
                    WriteLine("Введите \"{0}\" по англиски", Words.word[i].Rus);
                    inputWord = ReadLine();

                    if (inputWord == Words.word[i].Eng)
                    {
                        Words.Count++;
                        ColorWrite("Правильно", ConsoleColor.Green);
                    }
                    else
                    {
                        ColorWrite("Неправильно", ConsoleColor.Red);
                    }
                }

                WriteLine("Кличество верных слов: {0}", Words.Count);
            }
        Exit:;
        }

        private static void ColorWrite(string text ,ConsoleColor color)
        {
            ForegroundColor = color;
            WriteLine(text);
            DefualtForegraundColor();
        }

        private static void DefualtForegraundColor()
        {
            ForegroundColor = ConsoleColor.White;
        }
    }
}
