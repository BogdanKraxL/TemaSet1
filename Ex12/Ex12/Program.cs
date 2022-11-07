using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;
using System.Text; 

//Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].

namespace Ex12
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, n, nr = 0;
            Console.Write("Primul numar din interval: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Al doilea numar din interval: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Numerele divizibile cu: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Din intervalul [{a} {b}]");

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
    }
}

