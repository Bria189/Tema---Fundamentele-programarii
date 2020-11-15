using System;

namespace Pool_1__ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            int n, k;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.Write("n se divide cu k");
            else
                Console.Write("n NU se divide cu k");

            Console.ReadKey();


        }
    }
}
