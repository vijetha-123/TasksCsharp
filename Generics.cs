using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class Generics
    {
        //GENERICdelegate
        public delegate T AreaDelegate<T>(T value1);
        class Area_op
        {
            public int Square_area(int a)
            {
                return a * a;
            }
            public int Cube_area(int a)
            {
                return 6 * a * a;
            }
            public int Circle_area(int a)
            {
                return 3 * a * a;
            }
            public double Square_area(double a)
            {
                return a * a;
            }
            public double Cube_area(double a)
            {
                return 6 * a * a;
            }
            public double Circle_area(double a)
            {
                return 3 * a * a;
            }

        }
        public static void Main()
        {
            Console.WriteLine("--------------Area using integer value-------------");
            Area_op area = new Area_op();
            AreaDelegate<int> dlgt = new AreaDelegate<int>(area.Square_area);
            Console.WriteLine("Square area:" + dlgt(10));
            dlgt = area.Cube_area;
            Console.WriteLine("Cube area:" + dlgt(20));
            dlgt = area.Circle_area;
            Console.WriteLine("Circle area:" + dlgt(30));
            Console.WriteLine("------------Area using double value--------- ");
            AreaDelegate<double> dlgt1 = new AreaDelegate<double>(area.Square_area);
            Console.WriteLine("Square area:" + dlgt1(10.5));
            dlgt1 = area.Cube_area;
            Console.WriteLine("Cube area:" + dlgt1(20.8));
            dlgt1 = area.Circle_area;
            Console.WriteLine("Circle area:" + dlgt1(30.3));
        }  
    }
}
