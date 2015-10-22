using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhone_Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone call = new Phone();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();
            

            call.telephone = "b";     
            while (call.telephone != "xx")
            {             

            Console.Clear();                        
            while (call.telephone != "XX" || call.telephone != "xx" || call.telephone != "Xx" || call.telephone != "xX")

                Console.Clear();
                Console.WriteLine("................Vodacom Dialling App............");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Please Enter the Telephone, -Enter XX or Cancel to STOP.");
                call.telephone = Console.ReadLine();
                string msg = call.RemoveBrackets();
                Console.WriteLine(msg);
                string alert = call.CheckRange(call.telephone);
                Console.WriteLine(alert);            
                call.ProgrammedNumber();             
                Console.ReadLine();
            }
        }
    }
}
   
