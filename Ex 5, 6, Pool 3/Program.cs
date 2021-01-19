using System;

namespace Ex_5__6__Pool_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
            
            Console.WriteLine("Rezolvare exercitiu 5:");
            Console.WriteLine();
            Console.WriteLine("Introduceti o valoare pentru n:");
            int n, i, e, k, pozk=0;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru k mai mica decat n:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru e:");
            e = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            int[] aux = new int[n+1];
            int[] aux2 = new int[n - 1];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti o valoare pentru un element din vector:");
                v[i] = int.Parse(Console.ReadLine());
                if (i == k)
                    pozk = i;
            }

            Console.WriteLine();
            Console.WriteLine("Vectorul inaintea introducerea valorii e:");
            Console.WriteLine();
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            i = 0;
            while(i<n && pozk!=i)
            {
                aux[i] = v[i];
                i++;
            }
            aux[pozk] = e;
            i = i--;
            if(i<n)
                while(i<n+1)
                {
                    aux[i] = v[i];
                    i++;
                }

            Console.WriteLine();
            Console.WriteLine("Vectorul dupa introducerea valorii e:");
            Console.WriteLine();
            for (i = 0; i <= n; i++)
                Console.Write(aux[i] + " ");


            Console.WriteLine();
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Rezolvare exercitiu 5:");
            Console.WriteLine();
            //6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. 
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga
            i = 0;
            while (i<n)
            {
                if (pozk == i)
                    i++;
                aux2[i] = v[i];
                i++;
              
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul dupa eliminarea valorii dupa pozitia k:");
            Console.WriteLine();
            for (i = 0; i < n - 1; i++)
                Console.Write(aux2[i] + " ");

        }

    }
}
