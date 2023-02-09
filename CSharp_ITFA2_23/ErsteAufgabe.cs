using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class ErsteAufgabe
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie einen Wert ein (Hello, Quadrat, Buchstaben):");
                switch (Console.ReadLine())
                {
                    case "Hello":
                        Hello();
                        break;
                    case "Quadrat":
                        Quadrat();
                        break;
                    case "Buchstaben":
                        Buchstaben();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Leider wurde die Eingabe nicht erkannt :(");
                        break;
                }
            }

        }

        public static void Hello()
        {
            Console.WriteLine("****************");
            Console.WriteLine("* Hello World! *");
            Console.WriteLine("****************");
        }

        public static void Quadrat()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ihre Zahl ist quadriert: " + (i*i));
        }

        public static void Buchstaben()
        {
            Console.WriteLine("Bitte geben Sie einen String ein:");
            foreach(var element in Console.ReadLine())
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
