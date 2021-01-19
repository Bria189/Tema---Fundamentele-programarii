using System;

namespace Ex_1__Pool_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

            Console.WriteLine("Rezolvare exercitiu 1:");
            Console.WriteLine();
            Console.WriteLine("Introduceti o valoare pentru n");
            int n, s = 0, i;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti o valoare pentru elementul vectorului");
                a[i] = int.Parse(Console.ReadLine());
                s = s + a[i];
            }
            Console.WriteLine("Suma elementelor vectorului este = " + s);


            //2. Se da un vector cu n elemente si o valoare k. 
            //Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

            Console.WriteLine();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();
            Console.WriteLine("Rezolvare exercitiu 2:");
            Console.WriteLine();
            Console.WriteLine("Introduceti o valoare pentru m");
            int m, k;
            bool ok=false;
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru k");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("Introduceti o valoare pentru elementul vectorului");
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == k)
                {
                    Console.WriteLine("Prima pozitie din vector pe care apare k este:" + " " + i);
                    ok = true;
                    break;
                }

            }
            if (ok == false)
                Console.WriteLine(-1);

            Console.ReadKey();
        }
    }
}
