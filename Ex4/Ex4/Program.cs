using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Detreminati daca un an y este an bisect. 

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar de ani: ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " este an bisect");
            }
            else 
            {
                Console.WriteLine(y + " nu este an bisect"); 
            }
            Console.ReadKey();
        }
    }
}