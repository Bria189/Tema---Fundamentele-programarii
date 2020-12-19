using System;

namespace Pool_2__ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. 
            //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
            int n, a, poz = 0, i, x;
            bool ok = false;

            Console.WriteLine("Introduceti o valoare pentru n:");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti o valoare pentru a:");

            a = int.Parse(Console.ReadLine());

            while(n!=0 && ok == false)
            {
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());

                if (x == a)
                {
                    Console.WriteLine("Numarul se afla pe pozitia " + poz);
                    ok = true;
                }
                else
                {
                    poz++;
                    n--;
                }

            }
            if (poz == 0 && ok == false)
                Console.WriteLine("Numarul se afla pe pozitia -1");
            Console.ReadKey();

        }
    }
}
