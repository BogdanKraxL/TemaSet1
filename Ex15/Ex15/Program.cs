using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Se dau 3 numere. Sa se afiseze in ordine crescatoare.

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Primul numar: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Al doilea numar: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Al treilea numar: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && b > c && a < c)
            {
                Console.WriteLine($"{a}, {c}, {b}.");
            }
            if (b < a && a > c && b < c)
            {
                Console.WriteLine($"{b}, {c}, {a}.");
            }
            if (a < c && c > b && b < a)
            {
                Console.WriteLine($"{b}, {a}, {c}.");
            }
            if (a < c && c > b && a < b)
            {
                Console.WriteLine($"{a}, {b}, {c}.");
            }
            if (c < a && b > c && a < b)
            {
                Console.WriteLine($"{c}, {a}, {b}.");
            }
            if (c < b && a > c && a > b)
            {
                Console.WriteLine($"{c}, {b}, {a}.");
            }
        }
    }
}