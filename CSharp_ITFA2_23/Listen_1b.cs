using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class Listen_1b
    {
        public static void Start()
        {
            var list = GetUserInput();
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            foreach(var element in list)
            {
                if (element < min)
                    min = element;
                if (element > max)
                    max = element;
                sum += element;
            }
            Console.WriteLine("Minimaler Wert: " + min);
            Console.WriteLine("Maximaler Wert: " + max);
            Console.WriteLine("Summe: " + sum);
            Console.WriteLine("Durchschnitt: " + sum/list.Count);
        }
        static List<int> GetUserInput()
        {
            List<int> input = new List<int>();
            while (true)
            {
                string s = Console.ReadLine();
                int i;
                if (int.TryParse(s, out i))
                {
                    input.Add(i);
                }
                else if (s == string.Empty)
                    return input;
            }
        }
    }
}
