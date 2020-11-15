using System;

namespace Pool_1__ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
            int a, b;
            float x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = -b / a;

            Console.Write(x);
            Console.ReadKey();


        }
    }
}
