using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class Taschenrechner
    {
        public static void Start()
        {
            Console.WriteLine("Ihr Ergebnis ist: " + Manage(UserInput()));
        }
        static List<string> UserInput()
        {
            List<string> stringList = new List<string>();
            Console.WriteLine("Bitte Rechnung eingeben:");
            string s = Console.ReadLine();

            string tempNum = "";
            foreach(var element in s)
            {
                if (int.TryParse(element.ToString(), out _))
                    tempNum += element;
                else
                {
                    stringList.Add(tempNum);
                    tempNum = "";
                    stringList.Add(element.ToString());
                }
            }
            stringList.Add(tempNum);
            return stringList;
        }
        static int Manage(List<string> stringList)
        {
            if (stringList[1] == "+")
                return Plus(stringList[0], stringList[2]);
            if(stringList[1] == "-")
                return Minus(stringList[0], stringList[2]);
            if (stringList[1] == "*")
                return Mal(stringList[0], stringList[2]);
            if (stringList[1] == "/")
                return Geteilt(stringList[0], stringList[2]);

            return -1;
        }
        static int Plus(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        static int Minus(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }
        static int Mal(string a, string b)
        {
            return Convert.ToInt32(a) * Convert.ToInt32(b);
        }
        static int Geteilt(string a, string b)
        {
            return Convert.ToInt32(a) / Convert.ToInt32(b);
        }
    }
}
