using System;

namespace Pool_1__ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Dupa interschimbare variabilele sunt:");
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.ReadKey();
        }
    }
}
