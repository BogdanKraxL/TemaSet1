using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, total = 0, t, inv;
            Console.WriteLine("Introduceti un numar: ");
            num = int.Parse(Console.ReadLine());
            t = num;
            
            while(num > 0)
            {
                inv = num % 10;
                total = (total * 10) + inv;
                num = num / 10;
            }
            if (t == total)
            {
                Console.WriteLine("Numarul este Palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este Palindrom");
            }
        }
    }
}