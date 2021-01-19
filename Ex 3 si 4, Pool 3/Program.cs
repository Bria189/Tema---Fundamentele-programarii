using System;

namespace Ex_3_si_4__Pool_3
{
    class Program
    {                
        static int[] vfrecv=new int[1000];
        static void Main(string[] args)
        {
            //3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.

            Console.WriteLine("Rezolvare exercitiu 3:");
            Console.WriteLine();
            Console.WriteLine("Introduceti o valoare pentru n:");
            int n, i, min, max, pozmin=0, pozmax=1;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti o valoare pentru primul element din vector:");

            v[0] = int.Parse(Console.ReadLine());
            min = v[0];

            Console.WriteLine("Introduceti o valoare pentru al doilea element din vector:");
            v[1] = int.Parse(Console.ReadLine());
            max = v[1];

            for(i=2; i<n; i++)
            {
                Console.WriteLine("Introduceti o valoare pentru un element din vector:");
                v[i] = int.Parse(Console.ReadLine());
                vfrecv[v[i]]++;
                if (min > v[i])
                {
                    min = v[i];
                    pozmin = i;
                }
                if (max < v[i])
                {    
                    max = v[i];
                    pozmax = i;
                }
             }
            Console.WriteLine();
            if (min == v[0])
                Console.WriteLine("Cel mai mic element al vectorului se afla pe pozitia " + 0);
            else
                Console.WriteLine("Cel mai mic element al vectorului se afla pe pozitia " + pozmin);
            Console.WriteLine();
            if (max == v[1])
                Console.WriteLine("Cel mai mare element al vectorului se afla pe pozitia " + 1);
            else
                Console.WriteLine("Cel mai mare element al vectorului se afla pe pozitia " + pozmax);

            Console.WriteLine();
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();

            Console.WriteLine("Rezolvare exercitiu 4:");
            Console.WriteLine();
            //4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea
                        
            Console.WriteLine("Cea mai mica valoare din vector este: " + min + " si apare de: " + vfrecv[min] + " ori");
            Console.WriteLine();
            Console.WriteLine("Cea mai mare valoare din vector este: " + max + " si apare de: " + vfrecv[max] + " ori");

            Console.ReadKey();
        }
    }
}
