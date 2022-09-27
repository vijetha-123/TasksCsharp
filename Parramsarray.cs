using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class Parramsarray
    {
        public static void Main()
        {
            int no = Mul(2, 3);
            
        }
        public static int Mul(params int[] number)
        {
            foreach (int i in number)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1}= {2}",i,j,(i * j));
                }
                Console.WriteLine("\n");
            }
            
            return 0;
            
            
        }
    }
}
