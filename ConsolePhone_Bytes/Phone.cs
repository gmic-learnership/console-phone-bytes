using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsolePhone_Bytes
{
    class Phone
    {
        public string telephone;
        public string msg;
        public double num;


     
        // This method will check if the telephone includes ()- and then remove then
        public string RemoveBrackets()
        {
            if (telephone == "")
            {
                Console.WriteLine("Telephone number cannot be Empty" + "   " + "Please try Again");
            }
            else if (telephone.Contains("(") || telephone.Contains(")") || telephone.Contains("-"))

            {

                string one = telephone.Replace("(", "");
                telephone = one;
                one = telephone.Replace(")", "");
                telephone = one;
                one = telephone.Replace("-", "");
                telephone = one;

            }
            return telephone;
        }

        public void ProgrammedNumber()
        {
            if (telephone == "0839071212")
            {
                Console.WriteLine("CHRISTOPHER DAWSON was Successfully Dialed...");
            }

            else if (telephone == "0116346554")
            {
                Console.WriteLine("WARREN GROENEWALD was Successfully Dialed...");
            }
            else if (telephone == "0720751453")
            {
                Console.WriteLine("PRUDENCE MABITSELA was Successfully Dialed...");
            }
            else if (telephone == "0849079547")
            {
                Console.WriteLine("WILLIES was Successfully Dialed...");
            }
            else if (telephone == "0117595930")
            {
                Console.WriteLine("J VAN DER MERVE was Successfully Dialed...");
            }

        }

        // this method will check the leght of the contact if its 10 digits long.
        // Also check if the Telephone starts with [012,011,069,072,073,083]
        // XX WILL CLOSE THE APPLICATION

        public string checkRange(string tel)
        {
            Console.Clear();
            bool isNum = double.TryParse(tel, out num);
            tel.Trim();


            if (telephone == "XX" || telephone == "xx")
            {

                Console.SetWindowSize(1, 1);

            }

            //  Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            //  if (regex.IsMatch(tel))


            //  {
           



            if (telephone.Length != 10)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("**************************");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                msg = "The Telephone number must be 10 digits long" + "   " + "Please try Again";
                Console.Beep(1500, 1500);
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (!telephone.StartsWith("072") && !telephone.StartsWith("073") && !telephone.StartsWith("011") &&
                !telephone.StartsWith("083") && !telephone.StartsWith("012") && !telephone.StartsWith("069"))

            {

                Console.WriteLine("**************************");
                Console.WriteLine("**************************");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                msg = "Telephone number cannot start with" + " " + telephone.Substring(0, 3) + "   " + "Please try Again";
                Console.Beep(1500, 1500);
                Console.WriteLine("");
                Console.WriteLine("");
            }
           
          else if (!isNum)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("**************************");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("The Telephone Must be Numeric, Please try Again");
                Console.WriteLine("**************************");
                Console.WriteLine("**************************");

            }



            else
            {


                Console.WriteLine("**************************");
                Console.WriteLine("**************************");
                Console.BackgroundColor = ConsoleColor.Blue;
                msg = "You are Now Dialling......." + telephone + "\n";
                Console.WriteLine("");
                Console.WriteLine("");
            }

          

            return msg;
        }
        /* else
         {

             Console.WriteLine("**************************");
             Console.WriteLine("**************************");
             Console.WriteLine("The Telephone Must be Numeric, Please try Again");
             Console.WriteLine("**************************");
             Console.WriteLine("**************************");
         }*/
    
           
        
    }
}
