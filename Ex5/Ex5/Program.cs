using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, k;
            num = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            for(int i=1; i<k; i++)
            {
                num /= 10;
            }
            Console.WriteLine(num % 10);

            Console.ReadKey();
        }    
    }   
}
