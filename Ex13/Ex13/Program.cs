using System;
using System.Collections.Generic;
using System.Text;

//Determianti cati ani bisecti sunt intre anii y1 si y2.

namespace Ex13
{
    class Program
    {
        public static void Main(string[] args)
        {
            int y1, y2;
            Console.Write("De la anul: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Pana la anul: ");
            y2 = int.Parse(Console.ReadLine());
            
            for (int n = y1; n < y2; n++)
            {
                if (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0))
                {
                    Console.WriteLine($"Anul {n} este an bisect");
                }
                else
                {
                    Console.WriteLine($"Anul {n} nu este an bisect");
                }
            }
        }
    }

}
