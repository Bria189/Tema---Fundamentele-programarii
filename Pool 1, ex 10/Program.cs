using System;

namespace Pool_1__ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim.
            int n, i, nr = 0;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    nr++;
            if (nr == 2)
                Console.Write("Numarul este prim");
            else
                Console.Write("Numarul nu este prim");

        }
    }
}
