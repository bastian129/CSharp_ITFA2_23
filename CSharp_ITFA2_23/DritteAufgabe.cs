using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFA2_23
{
    internal class DritteAufgabe
    {
        public static void Start()
        {
            while(true)
            {
                Console.WriteLine("Bitte geben Sie einen String ein:");
                string s = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ihr manipulierter String: " + Meth(s, i));
            }    
        }
        public static string Meth(string s, int i)
        {
            string[] LetterArray = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            string temp = "";
            int num = 0;
            foreach(string element in LetterArray)
            {
                bool b = false;
                foreach(char letter in s)
                {
                    //Wenn die Variable b auf true steht, dann werden alle restlichen Buchstaben noch zu dem temporären String hinzugefügt.
                    if (b)
                    {
                        temp += letter;
                        continue;
                    }
                    //Wir überprüfen, ob der Buchstaben an dieser Stelle vorhanden ist. Wenn nein, wird der Buchstaben zum temprären String hinzugefügt, wenn ja, dann wir der Wert num um eins erhöht.
                    if (element == letter.ToString() || element.ToUpper() == letter.ToString())
                        num++;
                    else
                        temp += letter;
                    //Wenn die richtige Länge erreicht wurde, dann setzen wir die Variable b auf true.
                    if (s.Length - num <= i)
                        b = true;

                }
                //Hier sind wir fertig mit dem temporären String, also geben wir ihn zurück
                if(b)
                    return temp;

                s = temp;
                temp = "";
                num = 0;
            }

            return string.Empty; // := ""
        }
    }
}
