using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class _2d_Array
    {
        public static void Main()
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];

            Console.Write("First matrix is:\n");

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Second matrix is:\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            Console.Write("First matrix is:\n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}\t", a[i, j]);
            }
            Console.WriteLine("\n");

            Console.Write("Second matrix is:\n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}\t", b[i, j]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i,j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0}\t",c[i, j]);
                }
                
            }
            



        }
    }
}
