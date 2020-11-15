using System;

namespace Pool_1__ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

            int k, nr, n;
            Console.WriteLine("Introduceti o valoare pentru k");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru n");
            n = int.Parse(Console.ReadLine());

            nr = 0; //numaram cate cifre am eliminat din numarul n

            while (n != 0)
                if ((k - nr) != 1)
                {
                    n = n / 10;
                    nr++;
                }
                else
                {
                    Console.Write(n % 10);
                    break;
                }

                        
        }
    }
}
