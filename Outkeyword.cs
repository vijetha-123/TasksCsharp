using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class Outkeyword
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdes;
            Student_det(out sid, out sname, out sdes);
        }
        public static void Student_det(out int x,out string y,out string z)
        {
            Console.WriteLine("Enter student id:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            y = Console.ReadLine();
            Console.WriteLine("Enter student description:");
            z = Console.ReadLine();
            Console.WriteLine("Enter student id:"+x);
            Console.WriteLine("Enter student name:"+y);
            Console.WriteLine("Enter student name:"+z);

        }
    }
}
