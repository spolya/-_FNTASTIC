using System;

namespace Тестовое_FNTASTIC
{
    class Text
    {
        public string ConvertPhrase(string phrase)
        {
            phrase = phrase.ToLower();
            char[] arrayChar = phrase.ToCharArray();
            phrase = "";
            for (int i = 0; i < arrayChar.Length; i++)
            {
                char selectChar = arrayChar[i];
                string newChar = "";
                for (int j = 0; j < arrayChar.Length; j++)
                {
                    if (i != j) // пропуск выбранного символа
                    {
                        if (selectChar == arrayChar[j])
                        {
                            newChar = ")";
                            break;
                        }
                        else
                        {
                            newChar = "(";
                        }
                    }
                }
                phrase += newChar;
            }
            return phrase;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the phrase: ");
            string phrase = Console.ReadLine();
            Text objectText = new Text();
            phrase = objectText.ConvertPhrase(phrase);
            Console.WriteLine("New phrase: " + phrase);
        }

    }
}
