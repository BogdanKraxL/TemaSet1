using System;
using System.Collections.Generic;
using System.Text;

//Afisati in ordine inversa cifrele unui numar n. 

namespace Ex11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;

            }
            Console.WriteLine("Numarul tau invers este: {0}", reverse);
        }
    }
}