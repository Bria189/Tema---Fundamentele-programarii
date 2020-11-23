using System;

namespace Pool_1__ex_15_si_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.
            //16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            int a, b, c, d, e, aux;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if(a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine("Primele 3 numere ordonate crescator sunt:" + a + " " + b + " " + c);
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }
            if(b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            Console.WriteLine("Primele 5 numere ordonate crescator sunt:" + a + " " + b + " " + c + " " + d + " " +  e);


        }
    }
}
