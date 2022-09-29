using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    public class Exception_op
    {
        
    public void MultipleCatch()
        {
            Console.WriteLine("enter the length of array:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] c= null;
            int op;

            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine($"enter array element {j+1} :");
                a[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                try

                {
                    Console.WriteLine(a[i] / i);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           
        }
}
    internal class Exceptions
    {
        public static void Main()
        {
            Exception_op e = new Exception_op();
            e.MultipleCatch();
        }
    }
}
