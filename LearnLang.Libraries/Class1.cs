using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace LearnLang.Libraries
{
    // переписать все методы, которые используют этот класс
    static public class Lang
    {
        public static Words[]? word;

        public static int Count = 0;
        public static int Index = 0;

        public static string? asd;

        public static void Parser(string filePath)
        {
            string fileName = "Dict.json";

            FileInfo fileInfo = new FileInfo(fileName);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };

            asd = filePath;

            Console.WriteLine(filePath);

            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();

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

                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.Write(JsonSerializer.Serialize<Words[]>(words, options));
                }
            }

            string jsonString = File.ReadAllText(filePath);
            word = JsonSerializer.Deserialize<Words[]>(jsonString, options);
        }

        public static void Mix() 
        {
            Random.Shared.Shuffle(word);
        }
    }

    sealed public class Words
    {
        public string Rus { get; set; }
        public string Eng { get; set; }
    }
}