using System;
using System.Collections.Generic;
using System.Text;

//(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.

namespace Ex7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a = {0} \\ b = {1}", b, a);
        }
    }

}
 