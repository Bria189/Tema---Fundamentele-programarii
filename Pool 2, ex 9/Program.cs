using System;

namespace Pool_2__ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.

            int n, x, y;
            bool ok = true;

            Console.WriteLine("Introduceti o valoare pentru n:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti o valoare:");
            x = int.Parse(Console.ReadLine());
            y = x;
            while (n != 0 && ok == true)
            {
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());
                if (y < x)
                    ok = true;
                else
                    ok = false;
                n--;
                y = x;
            }
            if (ok == true)
                Console.WriteLine("Secventa este monoton crescatoare");
            else
            {
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());
                y = x;
                while (n != 0 && ok == true)
                {
                    Console.WriteLine("Introduceti o valoare:");
                    x = int.Parse(Console.ReadLine());
                    if (y > x)
                        ok = true;
                    else
                        ok = false;
                    n--;
                    y = x;
                }
                if(ok==true)
                    Console.WriteLine("Secventa este monoton descrescatoare");

            }
            Console.ReadKey();
        }
    }
}
