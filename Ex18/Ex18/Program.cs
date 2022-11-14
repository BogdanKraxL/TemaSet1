using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 

namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            int div = 2;
            int exp = 0;

            while(n != 1)
            {
                while (n % div == 0)
                {
                    exp++;
                    n = n / div;
                }
                if (exp != 0)
                {
                    Console.Write($"{div} ^ {exp}\n");
                    exp = 0;
                }
                div++;
            }
            Console.ReadKey();
        }
    }
}
