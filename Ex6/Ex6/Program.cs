using System;
using System.Collections.Generic;
using System.Text;

//Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

namespace Ex6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c, num;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && (a + b > c || b + c > a || a + c > b))
            {
                Console.WriteLine("Triunghi");
            }
            else
            {
                Console.WriteLine("Nu este Triunghi");
            }
            Console.ReadKey();

        }
    }

}