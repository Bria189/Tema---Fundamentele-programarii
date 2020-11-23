using System;

namespace Pool_1__ex_21
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
            int n, x;
            n = rnd.Next(1024);
            Console.WriteLine("Introduceti numarul:");
            x = int.Parse(Console.ReadLine());
            if (x == n)
                Console.WriteLine("Ai ghicit numarul! Felicitari");
            while (x != n)
            {
                if (x < n)
                {
                    Console.WriteLine("Numarul este prea mic. Mai incearca.");
                    x = int.Parse(Console.ReadLine());
                    if(x==n)
                        Console.WriteLine("Ai ghicit numarul! Felicitari");
                }
                if (x > n)
                {
                    Console.WriteLine("Numarul este prea mare. Mai incearca.");
                    x = int.Parse(Console.ReadLine());
                    if (x == n)
                        Console.WriteLine("Ai ghicit numarul! Felicitari");
                }
            }


        }
    }
}
