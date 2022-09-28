using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    public class Public_internal
    {
        public void Internaldetails()
        {
            Console.WriteLine("Welcome to internal accessspecifier");
        }
        public void Publicdetails()
        {
            Console.WriteLine("Welcome to public accessspecifier");
        }

    }
    public class AccessSpecifiersMain
    {
        public static void Main()
        {
            Public_internal n=new Public_internal();
            n.Publicdetails();

        }
    }

}

    