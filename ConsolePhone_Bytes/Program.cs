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
            Console.WriteLine("");

            call.telephone = "";
         
          
          
            //Iterate until you enter XX to exit
            while (call.telephone != "xx")

            {

                //Displays the header propt the user to enter the Telephone
                Console.Clear();
                Console.WriteLine("................Vodacom Dialling App............");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Please Enter the Telephone, -Enter XX or Cancel to STOP.");
                call.telephone = Console.ReadLine();


                //call the methods

                string msg = call.RemoveBrackets();
                Console.WriteLine(msg);

                string alert = call.checkRange(call.telephone);
                Console.WriteLine(alert);

               

                call.ProgrammedNumber();
              
                Console.ReadLine();
            }



        }

    }
}
   
