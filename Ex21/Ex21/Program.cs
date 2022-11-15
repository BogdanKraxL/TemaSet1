using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int num1 = 1;
            int num2 = 1024;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ghiceste numarul intre {num1} si {num2}: ");
                n = int.Parse(Console.ReadLine());

                if (n < num1 || n > num2)
                {
                    Console.WriteLine($"Numarul {n} nu este considerat...\tMai incearca");
                    if (i == 1)
                    {
                        Console.WriteLine("Mai ai 3 incercari\n");
                    }
                    if (i == 2)
                    {
                        i = 1;
                        Console.WriteLine("Mai ai 2 incercari\n");
                    }
                    if (i == 3)
                    {
                        i = 2;
                        Console.WriteLine("Mai ai 1 incercare\n");
                    }
                }
                if (n == 420)
                {
                    Console.WriteLine($"\nYOU WON!");
                    break;
                }
                if (n < 420 && n > num1)
                {
                    Console.WriteLine($"Numarul {n} este mai mic decat numarul care trebuie ghicit\n");
                    if (i == 1)
                    {
                        Console.WriteLine("Mai ai 2 incercari\n");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Mai ai 1 incercare\n");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("YOU LOST!");
                        break;
                    }
                }
                if (n > 420 && n < num2)
                {
                    Console.WriteLine($"Numarul {n} este mai mare decat numarul care trebuie ghicit\n");
                    if (i == 1)
                    {
                        Console.WriteLine("Mai ai 2 incercari\n");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Mai ai 1 incercare\n");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("YOU LOST!");
                        break;
                    }
                }
            }
            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
        }
    }
}
