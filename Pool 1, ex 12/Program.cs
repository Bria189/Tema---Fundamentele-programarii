using System;

namespace Pool_1__ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]
            int n, a, b, nr=0, aux;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (b < a)
            {   aux = a;
                a = b;
                b = a;
            }
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;
            Console.WriteLine(nr);
        }
    }
}
