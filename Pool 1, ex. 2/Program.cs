using System;

namespace Pool_1__ex._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
            Tratati toate cazurile posibile.*/

            int a, b, c;
            double x1, x2;
            float delta;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            
            delta = b * b - (4 * (a * c));

            Console.Write("Delta este egala cu = ");
            Console.WriteLine(delta);

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.Write("Radacinile ecuatiei sunt:", " ");
                Console.Write(x1);
                Console.Write(" ");
                Console.Write(x2);

            }
            else
                if (delta == 0)
                  {
                       x1 = -b / (2 * a);
                       x2 = -b / (2 * a);
                       Console.Write("Radacinile ecuatiei sunt:", " ");
                       Console.Write(x1);
                       Console.Write(" ");
                       Console.Write(x2);
            }
                else
                  {
                    Console.WriteLine("Ecuatia nu are radacini numere reale");

                  }
                                            
            Console.ReadKey();
        }
    }
}
