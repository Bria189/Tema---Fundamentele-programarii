using System;

namespace Pool_2_exercitiul_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare.

            int n, x, nr = 0;

            Console.WriteLine("Introduceti o valoare pentru n");

            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine("Introduceti o valoare");
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nr++;
                n--;

            }
            Console.WriteLine(nr + "numere sunt pare");
            Console.ReadKey();
        }
    }
}
