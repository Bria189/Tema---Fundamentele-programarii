using System;

namespace Pool_2__ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive

            int n, x, poz = 0, neg = 0, nule = 0;

            Console.WriteLine("Introduceti o valoare pentru n");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine("Introduceti o valoare");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    neg++;
                else
                    if (x > 0)
                    poz++;
                else
                    nule++;
                n--;
            }
            Console.WriteLine(neg + " numere negative");
            Console.WriteLine(poz + " numere pozitive");
            Console.WriteLine(nule + " numere nule");
            Console.ReadKey();

        }
    }
}
