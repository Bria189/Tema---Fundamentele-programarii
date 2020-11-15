using System;

namespace Pool_1__ex._4
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect.

            /*Rezolvare: 
              Un an bisect se divide cu 4
              Însă dacă se divide cu 100 atunci nu e an bisect
              Însă dacă se divide cu 400, atunci e an bisect */

            int y;
            y = rnd.Next(1000, 3000);
            Console.WriteLine(y);
          
            if ((y % 4 == 0) && (y % 100 != 0))
                Console.Write("Nu e an bisect");
            else
                if (y % 400 == 0)
                Console.Write("Este an bisect");
                else
                Console.Write("Nu e an bisect");



        }
    }
}
