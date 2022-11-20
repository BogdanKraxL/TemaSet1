using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

namespace Ex21_Real_
{
    internal class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            int nIndex = rnd.Next(1024);
            Console.Write("Ghiciti numarul intre 1 si 1024: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 1000; i++)
            {
                if (n == nIndex)
                {
                    Console.WriteLine($"Felicitari! Numarul {n} era numarul care trebuia ghicit.");
                    break;
                }
                else if (n < nIndex)
                {
                    Console.WriteLine($"Numarul {n} este mai mic decat numarul care trebuie sa fie ghicit.");   
                }
                else if (n > nIndex)
                {
                    Console.WriteLine($"Numarul {n} este mai mare decat numarul care trebuie sa fie ghicit.");
                }
                Console.Write("Mai incearca: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You won!");
            Console.ReadLine();
        }
    }
}
