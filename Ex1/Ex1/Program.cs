using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Ecuatie nedeterminata");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x = {0}", x);
            }
            Console.ReadKey();
        }
    }
}