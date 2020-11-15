using System;

namespace Pool_1__ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
            int a, b, aux;
            Console.WriteLine("Introduceti o valoare");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti alta valoare");
            b = int.Parse(Console.ReadLine());
           
            aux = a;
                a = b;
                b = aux;

            Console.WriteLine("Dupa interschimbare valorile sunt:");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
