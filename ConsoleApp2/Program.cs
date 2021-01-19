using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, x;
            TextReader load = new StreamReader(@"..\..\..\Bac.txt");
            string buffer = load.ReadLine();
            int n = int.Parse(load.ReadLine());
            Console.WriteLine(n);
            Console.WriteLine(buffer);

            string[] local = buffer.Split(' ');
            
            Console.WriteLine(n);
        }
    }
}
