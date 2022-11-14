using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a1, a2=0, aux;
            bool gasit_a2a_cifra = false, ok=false;

            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            aux = n;
            a1 = aux % 10;
            aux /= 10;

            while (aux != 0)
            {
                if(aux%10 != a1 && gasit_a2a_cifra==false)
                {
                    a2 = aux % 10;
                    gasit_a2a_cifra=true;
                }
                if((aux%10!=a1 && aux%10 != a2) && gasit_a2a_cifra == true)
                {
                    Console.WriteLine("Numarul {0} este format din mai multe cifre identice", n);
                    ok= true;
                    break;
                }
                aux /= 10;
            }
            if (ok == false)
            {
                Console.WriteLine("Numarul {0} este format din doua sau o cifre identice", n);
            }
            Console.ReadLine();
        }
    }
}
