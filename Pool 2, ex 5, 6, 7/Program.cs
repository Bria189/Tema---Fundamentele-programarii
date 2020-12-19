using System;

namespace Pool_2__ex_5__6__7
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
            //6. Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
            //7. Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.

            int n, poz = 0, x, nr=0, y, max, min, aux;
            bool ok = true;

            Console.WriteLine("Introduceti o valoare pentru n:");

             n = int.Parse(Console.ReadLine());
            while (n != 0)
             {
                 Console.WriteLine("Introduceti o valoare:");
                 x = int.Parse(Console.ReadLine());
                 if (x == poz)
                     nr++;
                 poz++;
                 n--;

             }
             //Raspuns ex 5:
             Console.WriteLine("In secventa se afla " + nr + "numere care sunt egale cu pozitia lor");

            //Ex 6

            Console.WriteLine("Introduceti o valoare:");
            x = int.Parse(Console.ReadLine());
            y = x;
            while (n != 0 && ok==true)
            {
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());
                if (y < x)
                    ok = true;
                else
                    ok = false;
                n--;

            }
           
            //Raspuns ex 6:

            if(ok == true)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele din secventa NU sunt in ordine crescatoare");
            

            //Ex 7

            Console.WriteLine("Introduceti o valoare:");
            x = int.Parse(Console.ReadLine());
            min = x;
            x = int.Parse(Console.ReadLine());
            if (min < x)
                max = x;
            else
            {
                aux = min;
                min = x;
                max = aux;
            }
            n = n - 2;
            while (n != 0)
            {
                Console.WriteLine("Introduceti o valoare:");
                x = int.Parse(Console.ReadLine());
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
                n--;
                
            }
            Console.WriteLine("Cea mai mica valoare este = " + min);
            Console.WriteLine("Cea mai mare valoare este = " + max);
            Console.ReadKey();
        }
    }
}
