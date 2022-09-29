using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    /// <summary>
    /// user-defined exception
    /// </summary>
    public class InvalidException : ApplicationException
    {
        public  InvalidException(string message) : base(message)
        {

        }
    }
    internal class UserDefined_excp
    {
        public static void Main() {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age > 22)
                {
                    Console.WriteLine("Entered valid age :"+age);
                }
                else
                {
                    throw (new InvalidException("Entered age is invalid"));
                }
            }
            catch(InvalidException ex) {
                    Console.WriteLine(ex.Message);
            }
            }
    }
}
