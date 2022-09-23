using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = "Japanese";
            SayHello(ref language);
            Console.WriteLine($"I just said hello in {language}");

            Console.ReadLine();
        }

        static void SayHello(ref string language)
        {
            Console.Write($"You can say hello in {language} by saying: ");

            switch (language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                case "German":
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("I don't know that language");
                    break;
            }
        }

        static void ShowOff()
        {
            List<string> languageList = new List<string> { "English", "French", "German", "undefined" };

            foreach (string language in languageList)
            {
                string lang = language;
                SayHello(ref lang);
            }
        }
    }
}
