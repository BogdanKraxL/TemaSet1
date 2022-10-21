using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Console.Write("n = ");
            float n = float.Parse(Console.ReadLine());
            Console.Write("k = ");
            float k = float.Parse(Console.ReadLine());
            if (n%k == 0)
            {
                Console.WriteLine("{0} divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine(n + " nu se divide cu " + k);
            }
            Console.ReadKey();
        }
    }
}