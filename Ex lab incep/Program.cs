using System;

namespace Ex_lab_incep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector si se cere suma celor mai mari 3 valori
            Console.WriteLine("Introduceti o valoare pentru n si mai apoi valorile din vector");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int max1, max2, max3, i, s = 0, aux;
            
            
            for (i = 0; i < n; i++)
               v[i]=int.Parse( Console.ReadLine());

            Console.WriteLine("Maximele initiale sunt:");
            max1 = v[0];
            max2 = v[1];
            max3 = v[2];
            do
            {
                if (max1 > max2)
                {
                    aux = max2;
                    max2 = max1;
                    max1 = aux;
                }
                else
                    if (max1 > max3)
                {
                    aux = max3;
                    max3 = max1;
                    max1 = aux;
                }
                else
                    if (max2 > max3)
                {
                    aux = max3;
                    max3 = max2;
                    max2 = aux;
                }
                Console.WriteLine(max1);
                Console.WriteLine(max2);
                Console.WriteLine(max3);
            } while (max1 > max2 || max2 > max3);


            for (i = 3; i < n; i++)
            {
                if (v[i] > max3)
                {
                    aux = max3;
                    max3 = v[i];
                    Console.WriteLine("Noile maxime sunt:");
                    Console.WriteLine(max1);
                    Console.WriteLine(max2);
                    Console.WriteLine(max3);
                    int aux2 = max2;
                    max2 = aux;
                    max1 = aux2;
                }
                else
                 if (v[i] > max2)
                {
                    aux = max2;
                    max2 = v[i];
                    Console.WriteLine("Noile maxime sunt:");
                    Console.WriteLine(max1);
                    Console.WriteLine(max2);
                    Console.WriteLine(max3);
                    max1 = aux;
                }
                else
                 if (v[i] > max1)
                {
                    max1 = v[i];
                    Console.WriteLine("Noile maxime sunt:");
                    Console.WriteLine(max1);
                    Console.WriteLine(max2);
                    Console.WriteLine(max3);
                }
                }
            s = max1 + max2 + max3;
            Console.WriteLine("Suma celor mai mari 3 valori din vector este:");
            Console.WriteLine(s);
            Console.ReadKey();
            }
    }
}
