using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    public delegate void BankDetails(string Bankname, string Interest);
    public class Banking
    {
        public void Banktype1(string Bankname,string Interest)
        {
            Console.WriteLine($"{Bankname} :{Interest}");
        }
        public void Banktype2(string Bankname, string Interest)
        {
            Console.WriteLine($"{Bankname} :{Interest}");
        }
        public void Banktype3(string Bankname, string Interest)
        {
            Console.WriteLine($"{Bankname} :{Interest}");
        }
        
    }
    internal class Multicast_delegate
    {
        public static void Main()
        {
            Banking b=new Banking();
           
            BankDetails details = b.Banktype1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter bank name:");
                string bank = Console.ReadLine();
                if (bank == "HDFC" || bank == "Axis" || bank == "ICICI")
                {
                    details(bank, "3.00%-3.50%");
                }
                
                else if (bank == "SBI")
                {
                    
                    details(bank, "2.7%");
                    details -= b.Banktype2;


                }
                else
                {
                    details(bank, "3.50%");
                    details -= b.Banktype3;

                }

            }
                
           
            

        }
    }
}
