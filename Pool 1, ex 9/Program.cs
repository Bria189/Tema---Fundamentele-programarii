using System;

namespace Pool_1__ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n. 
            int n, i;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numarului sunt:");
            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.Write(i + " ");
        }
    }
}
