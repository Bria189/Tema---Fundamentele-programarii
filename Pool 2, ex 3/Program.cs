using System;

namespace Pool_2__ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 

            Console.WriteLine("Introduceti o valoare pentru n");

            int n, s = 0, p = 1, i;
            n = int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                s = s + i;
                p = p * i;

            }
            Console.WriteLine("Suma numerelor este = " + s);
            Console.WriteLine("Produsul numerelor este = " + p);
            Console.ReadKey();
        }
    }
}
