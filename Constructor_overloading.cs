using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    public class Add
    {
        public Add(int x,int y)
        {
            x+=y;
            Console.WriteLine("Sum of 2 integer values :"+x);
        }
        public Add(float a,float b)
        {
            a+=b;
            Console.WriteLine("Sum of two float values:"+a);

        }
        public Add(string a1,string b1)
        {
            a1 += b1;
            Console.WriteLine("string concatenation:"+a1);

        }
    }
    internal class Constructor_overloading
    {
        public static void Main()
        {
            Console.WriteLine("enter the integer value 1:");
            int int1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the integer value 2:");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Add add= new Add(int1,int2);
            Console.WriteLine("enter the float value 1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the float value 2:");
            float y1 =float.Parse(Console.ReadLine());
            Add add1 = new Add(x1,y1);
            Console.WriteLine("enter the string 1:");
            string x2 = Console.ReadLine();
            Console.WriteLine("enter the string 2:");
            string y2 = Console.ReadLine();
            Add add2 = new Add(x2, y2);

        }
    }
}
