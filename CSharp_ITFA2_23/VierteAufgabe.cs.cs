using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class VierteAufgabe
    {
        public static void Start()
        {
            Console.WriteLine(Meth(14, 3));
        }
        public static string Meth(int a, int b)
        {
            int val1 = a / b;
            int val2 = a % b;
            return string.Format("Das Ergebnis: {0} / {1} = {2} Rest: {3}", a, b, val1, val2);
        }
    }
}
