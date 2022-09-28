using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class Inheritance
    {
        public class Bonus
        {
            protected int bonus;
        }
        public class Staff : Bonus
        {
            public void GetDetails()
            {
                bonus = 3;
            }
            public void Calcbonus(int salary)
            {
                bonus=salary*bonus;
                Console.WriteLine("Staff bonus:"+bonus);
            }

        }
        public class Nonstaff : Bonus
        {
            public void GetDetails()
            {
                bonus = 2;
            }
            public void Calcbonus(int salary)
            {
                bonus = salary * bonus;
                Console.WriteLine("Non staff bonus:"+ bonus);
            }
        }
        public static void Main()
        {
            Staff s = new Staff();
            s.GetDetails();
            Console.WriteLine("Enter the staff salary:");
            int sal=Convert.ToInt32(Console.ReadLine());
            s.Calcbonus(sal);
            Nonstaff s2 = new Nonstaff();
            s2.GetDetails();
            Console.WriteLine("Enter the Nonstaff salary:");
            int sal1 = Convert.ToInt32(Console.ReadLine());
            s2.Calcbonus(sal1);

        }
    }
}
