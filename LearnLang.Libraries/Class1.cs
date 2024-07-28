using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Reflection.Emit;
using System.IO;

namespace LearnLang.Libraries
{
    sealed public class Words
    {
        // public static Dictionary<string, string> dict = new Dictionary<string, string>();
        // Добавить новый класс для избежания рекурсии или создать словарь j
        public string Rus { get; set; }
        public string Eng { get; set; }

        public static Words[]? word;

        public static int Count = 0;
        public static int Index = 0;
        public static void Parser()
        {
            string path = "Dict.json";
            
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                };

                string jsonString = File.ReadAllText(path);

                word = JsonSerializer.Deserialize<Words[]>(jsonString);
            }
            else
            {
                fileInfo.Create();
                Words[]? words = 
                {
                    new Words() 
                    {
                        Rus = "Стол",
                        Eng = "Table"
                    },
                    new Words()
                    {
                        Rus = "Мышка",
                        Eng = "Mouse"
                    }
                };

                File.WriteAllText(path, JsonSerializer.Serialize<Words[]>(words));
            }
        }

        public static void Mix() 
        {
            Random.Shared.Shuffle(word);
        }
    }
}