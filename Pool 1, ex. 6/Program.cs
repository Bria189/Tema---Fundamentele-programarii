using System;

namespace Pool_1__ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi

            float a, b, c, aux;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b)
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

            if (a < (b + c) && b<(a+c) && c<(a+b) && a> 0 && b> 0 && c> 0)
            {  
                if (a * a + b * b == c * c) 
                    Console.Write("Triunghi dreptunghic");
                else 
                    if (a * a + b * b > c * c) 
                        Console.Write("Triunghi ascutitunghic");
                    else 
                        Console.Write("Triunghi obtuzunghic");
            }
            else Console.Write("Laturile nu pot forma un triunghi");
             
    }
    }
}
