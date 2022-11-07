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
            int a, b, c, d, e;
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;

            Console.Write("Primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Al doilea numar: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Al treilea numar: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Al patrulea numar: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Al cincilea numar: ");
            e = int.Parse(Console.ReadLine());

            if (a < b && a < c && a < d && a < e)
                num1 = a;

            if (a > b && a < c && a < d && a < e)
                num1 = b;

            if (a > b && a > c && a < d && a < e)
                num1 = c;

            if (a > b && a > c && a > d && a < e)
                num1 = d;

            if (a > b && a > c && a > d && a > e)
                num1 = e;

            if (b < a && b < c && b < d && b < e)
                num2 = a;

            if (b > a && b < c && b < d && b < e)
                num2 = b;

            if (b > a && b > c && b < d && b < e)
                num2 = c;

            if (b > a && b > c && b > d && b < e)
                num2 = d;

            if (b > a && b > c && b > d && b > e)
                num2 = e;

            if (c < a && c < b && c < d && c < e)
                num3 = a;

            if (c > a && c < b && c < d && c < e)
                num3 = b;

            if (c > a && c > b && c < d && c < e)
                num3 = c;

            if (c > a && c > b && c > d && c < e)
                num3 = d;

            if (c > a && c > b && c > d && c > e)
                num3 = e;

            if (d < a && d < b && d < c && d < e)
                num4 = a;

            if (d > a && d < b && d < c && d < e)
                num4 = b;

            if (d > a && d > b && d < c && d < e)
                num4 = c;

            if (d > a && d > b && d > c && d < e)
                num4 = d;

            if (d > a && d > b && d > c && d > e)
                num4 = e;

            if (e < a && e < b && e < c && e < d)
                num5 = a;

            if (e > a && e < b && e < c && e < d)
                num5 = b;

            if (e > a && e > b && e < c && e < d)
                num5 = c;

            if (e > a && e > b && e > c && e < d)
                num5 = d;

            if (e > a && e > b && e > c && e > d)
                num5 = e;

            Console.WriteLine("De la cel mai mic la cel mai mare " + num1 + " " + num2 + " " + num3 + " " + num4 + " " + num5);

            Console.ReadKey();
        }
    }
}