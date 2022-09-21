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
            SayHello("English");
            SayHello("French");
            SayHello("German");
            SayHello("yes");

            Console.ReadLine();
        }

        static void SayHello(string language)
        {
            Console.WriteLine(language);

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
    }
}
