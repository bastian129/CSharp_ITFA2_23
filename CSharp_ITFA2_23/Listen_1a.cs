using System;
using System.Collections.Generic;

namespace CSharp_ITFA2_23
{
    internal class Listen_1a
    {
        public static void Start()
        {
            WriteStringListToConsole(GetStringListFromUser());
        }

        static List<string> GetStringListFromUser()
        {
            List<string> stringList = new List<string>();
            while (true)
            {
                //Aufforderung für den Nutzer etwas einzugeben
                Console.WriteLine("Bitte geben Sie eine Zahl oder einen String ein:");
                //Nutzereingabe, die direkt in die Liste gespeichert wird
                stringList.Add(Console.ReadLine());
                //Fragen, ob weiter gemacht werden soll
                Console.WriteLine("Sollen noch weitere Eingaben gemacht werden? (J = Ja, ich will)");
                if (Console.ReadLine().ToUpper() != "J")
                    return stringList;
            }
        }
        static void WriteStringListToConsole(List<string> stringList)
        {
            int sum = 0;
            //Durch die Liste durchlaufen
            foreach (var element in stringList)
            {
                int val;
                //Ist es eine Zahl?
                if (int.TryParse(element, out val))
                {
                    Console.WriteLine("Ihre Zahl: " + element + " - Ihr Wert: " + val);
                }
                else
                {
                    val = element.Length;
                    Console.WriteLine("Ihr String: " + element + " - Ihr Wert: " + val);
                }
                //Summe bilden
                sum += val;
            }
            Console.WriteLine("Ihre Summe: " + sum);

        }
    }
}
