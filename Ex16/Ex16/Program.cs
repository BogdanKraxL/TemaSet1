using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, aux;
            aux = 0;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            e = int.Parse(Console.ReadLine());
            

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }
    }
}