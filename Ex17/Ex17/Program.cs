using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int a, b;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            n = a;
            m = b;

            while (n != m)
            {
                if (n > m)
                {
                    n -= m;
                }
                else 
                {
                    m -= n;
                }                   
            }
            Console.WriteLine(n);

            n = a;
            m = b;

            while (m != n)
            {
                if (n < m)
                {
                    n += a;
                }
                else
                {
                    m += b;
                }
            }
            Console.WriteLine(n);
        }
            
    }
}