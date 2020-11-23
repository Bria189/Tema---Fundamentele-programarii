using System;

namespace Ex_lab_incep_2
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Afisati cel mai mare si cel mai mic numar format cu cifrele unui numar dat
            int[] v;
            int n=100, k, i;
            v = new int[n];
            k = int.Parse(Console.ReadLine());
            i = 0;

            while(k!=0)
            {
                v[i] = k % 10;
                k = k / 10;
                i++;
                Console.WriteLine(v[i]);

            }
            n = i - 1;
            int aux, j, nr=0;
            for (i = 0; i < n - 1; i++)
                for(j=i+1; j<n; j++)
                {
                    if(v[i]<v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            for(i=0; i< n; i++)
            {
                Console.Write(v[i]);
                
            }
            Console.WriteLine();
            for (i = n-1; i > 0; i--)
            {
                if (v[i] != 0)
                {
                    Console.Write(v[i]);
                    nr = 0;
                }
                else
                    nr = 1;
                
                if (nr==1)
                    Console.Write(nr-1);
                
            }
            
            Console.ReadKey();




        }
    }
}
