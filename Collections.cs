using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FOR ICOLLECTION USABILITY
using System.Collections;
namespace TasksCsharp
{
    internal class Collections
    {
        public static void Main()
        {
            dictionary();
            Hashvalue();
        }
        public static void dictionary()
        {
            //here we need to specify the datatype(string ,string)
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("A", "john");
            dt.Add("B", "clora");
            dt.Add("C", "peter");
            dt.Add("D", "shri");
            Console.WriteLine("-----dictionary values are--------");
            foreach (string key in dt.Keys)
            {
                Console.WriteLine("key values:" + key);
            }
        } 
        public static void Hashvalue()
        {
            //here it takes random datatype,not required to mention any datatype
            Hashtable ht = new Hashtable();
            ht.Add(1, "vicky");
            ht.Add(2, "san");
            ht.Add(3, "dany");
            ht.Add(4, "james");
            Console.WriteLine("--------hashtable values are---------------");
            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(ht[key]);
                Console.WriteLine("---------------------------");
            }
           // ICollection keys=ht.Keys;//import collection
            //foreach(var obj in keys)
            //{
            //    Console.WriteLine(obj);
            //}


        }
    }
}
