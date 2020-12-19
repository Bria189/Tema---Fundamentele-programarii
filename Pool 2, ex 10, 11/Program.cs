using System;

namespace Pool_2__ex_10__11
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
            //11. Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere.

            int n, x,  secv, y, secvmax;
            float s = 0;
            secv = 0;
            secvmax = 0;
            Console.WriteLine("Introduceti o valoare pentru n:");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti o valoare:");
            x = int.Parse(Console.ReadLine());
            s = s + 1 / x;
            y = x;
            n--;
            while (n!=0 )
            {
                
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());
                s = s + (1 / x);
                if (y == x)
                    secv++;
                else
                    if (secv > secvmax)
                {
                    secvmax = secv;
                    secv = 0;
                }
                y = x;
                n--;

            }
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este: " + secvmax);
            Console.WriteLine("Suma inverselor numerelor din secventa este = " + s);
            Console.ReadKey();
        }
    }
}
