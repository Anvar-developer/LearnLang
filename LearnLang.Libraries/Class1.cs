using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace LearnLang.Libraries
{
    static public class Words
    {
        public static Lang[]? word;

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

                word = JsonSerializer.Deserialize<Lang[]>(jsonString);
            }
            else
            {
                fileInfo.Create();
                Lang[]? words = 
                {
                    new Lang() 
                    {
                        Rus = "Стол",
                        Eng = "Table"
                    },
                    new Lang()
                    {
                        Rus = "Мышка",
                        Eng = "Mouse"
                    }
                };

                File.WriteAllText(path, JsonSerializer.Serialize<Lang[]>(words));
            }
        }

        public static void Mix() 
        {
            Random.Shared.Shuffle(word);
        }
    }

    sealed public class Lang
    {
        public string Rus { get; set; }
        public string Eng { get; set; }
    }
}