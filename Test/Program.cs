using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static string Löss;
        public static string Möss;

        static void Main(string[] args)
        {

            string namn = string.Empty;

            Console.WriteLine("Skriv ett namn");
            namn = Console.ReadLine();

            
            {

            }
          switch (namn)
            {
                case "Sten":
                    Console.WriteLine("Hej sten, du är ful");
                    Console.WriteLine(DateTime.Now);
                    Funktion Djur = new Funktion(Löss, Möss);
                    
                    break;

                default:
                    Console.WriteLine("Du skrev inte Sten");
                    break;

                   
            }
            Console.ReadKey();
        }
    }
}
