using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class Listen
    {
        public static void Start()
        {
            //Arrays
            string[] stringArray = new string[1];
            //Listen
            List<string> stringList = new List<string>();
            stringList.Add("Hallo");
            stringList.Clear();
            stringList.Add("Hi");
            stringList.Add("Hey");
            stringList.Remove("Hey");
            stringList.RemoveAt(0);
            int i = stringList.Count;
            stringList.Insert(0, "Hoho");
            bool b = stringList.Contains("Hoho");
            foreach (var element in stringList)
                Console.WriteLine(element);
        }
    }
}
