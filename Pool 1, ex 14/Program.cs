using System;

namespace Pool_1__ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            int n, m, ogl=0;
            n = int.Parse(Console.ReadLine());
            m = n;

            while(m!=0)
            {
                ogl = ogl * 10 + m % 10;
                m = m / 10;
            }
            if (ogl == n)
                Console.WriteLine("Numarul este palidrom");
            else
                Console.WriteLine("Numarul nu este palidrom");
        }
    }
}
