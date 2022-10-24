using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Afisati toti divizorii numarului n. 

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti un numar: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
