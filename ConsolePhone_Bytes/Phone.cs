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
        public double num;
        public string msg;
        public string RemoveBrackets()
        {
            if (telephone == "")
            {
                Console.WriteLine("Telephone number cannot be Empty" + "   " + "Please try Again");
            }
            else if (telephone.Contains("(") || telephone.Contains(")") || telephone.Contains("-"))
            {
                telephone = telephone.Replace("(", "");
                telephone = telephone.Replace(")", "");
                telephone = telephone.Replace("-", "");
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
        public string CheckRange(string tel)
        {
            bool isNum = double.TryParse(tel, out num);
            tel.Trim();           
            if (telephone.Length != 10)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("**************************");
                if (telephone.Length != 10)
                {                 
                    msg = "The Telephone number must be 10 digits long" + "   " + "Please try Again";
                    Console.Beep(1125, 1125);
                }
                else if (!telephone.StartsWith("072") && !telephone.StartsWith("073") && !telephone.StartsWith("011") &&
                    !telephone.StartsWith("083") && !telephone.StartsWith("012") && !telephone.StartsWith("069"))
                {                  
                  msg = "Telephone number cannot start with" + " " + telephone.Substring(0, 3) + "   " + "Please try Again";
                    Console.Beep(1125, 1125);
                }
                else if (!isNum)
                {
                    
                    Console.WriteLine("The Telephone Must be Numeric, Please try Again");
                }
                else
                {           
                  msg = "You are Now Dialling......." + telephone + "\n";                  
                }
                return msg;
            }
        }
    }
}
