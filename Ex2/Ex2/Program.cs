using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

//Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, dt, x1, x2;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            dt = b * b - 4 * a * c;

            if (dt < 0)
            {
                Console.WriteLine("Ecuatia nu are radacini reale");
            }
            else if (dt > 0)
            {
                x1 = -b - Math.Sqrt(dt) / 2 * a;
                x2 = -b + Math.Sqrt(dt) / 2 * a;
                Console.WriteLine("Ecuatia are doua radacini distincte reale x1 = {0}, x2 = {1}", x1, x2);
            }
            else
            {
                x2 = -b / 2 * a;
                x1 = -b / 2 * a;
                Console.WriteLine("Ecuatia are o radacina x1 = x2 = {0}", x1);
            }
            Console.ReadKey();
        }
    }
}