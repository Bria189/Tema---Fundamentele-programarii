using System;

namespace Pool_1__ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            int n;
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            }    
        }
    }
}
