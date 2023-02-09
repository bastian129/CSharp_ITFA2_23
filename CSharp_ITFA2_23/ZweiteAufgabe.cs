using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class ZweiteAufgabe
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Das Ergebnis: " + Meth());
                Console.WriteLine("Möchten Sie die Eingabe beenden? (y = beenden)");
                if (Console.ReadLine() == "y")
                    break; //oder: return;
            }
        }
        public static int Meth()
        {
            Console.WriteLine("Bitte Wort eingeben:");
            return Console.ReadLine().Length;
        }
    }
}
