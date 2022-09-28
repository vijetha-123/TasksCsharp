using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//regualr expression
using System.Text.RegularExpressions;

namespace TasksCsharp
{
    internal class Regularexp
    {
        public static void Main()
        {
            mob();
        }
        public static void mob()
        {
            Console.WriteLine("Enter Valid Mobile number:");
            string mobile=Console.ReadLine();
            var validate = Regex.IsMatch(mobile, @"^[789]\d{9}$");
            Console.WriteLine("Entered Mobile number is: "+validate);
        }
    }
}
