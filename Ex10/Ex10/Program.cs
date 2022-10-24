using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Test de primalitate: determinati daca un numar n este prim.

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            bool prim = true;
            if (n < 1)
            {
                prim = false;
                Console.WriteLine(n + " nu este prim");
            }
            else
            {
                if (n == 1 || n == 2)
                {
                    prim = true;
                    Console.WriteLine(n + " este prim");
                }
                else
                {
                    for (int d = 3; d < n; d++)
                    {
                        if (n % d == 0)
                        {
                            prim = false;
                        }
                    }
                    if (prim == true)
                        Console.WriteLine(n + " este prim");
                    else
                        Console.WriteLine(n + " nu este prim");

                }

            }
        }
    }
}
