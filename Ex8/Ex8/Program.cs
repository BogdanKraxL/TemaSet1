using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
//Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

namespace Ex8
{
    class Program
    {
        internal static void Main(string[] args)
        {
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(".....");
            Console.WriteLine(".....");
            Console.WriteLine(".....");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}