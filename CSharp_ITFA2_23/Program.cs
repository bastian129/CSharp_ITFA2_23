using System;
using System.Collections.Generic;

namespace CSharp_ITFA2_23
{
    internal class Program
    {

        enum Kontinent { Europa, Asien, Afrika, Australien, Nord_Amerika, Süd_Amerika };
        static void Main(string[] args)
        {
            List<string> elemente = new List<string>() { "Schere", "Stein", "Papier"};
            elemente.Add("Brunnen");
            elemente[0] = "Baumstamm";

            List<string> liste = new List<string>() { "Asien", "Europa", "Amerika" };
            liste.Contains("Nord Amerika");
            liste.Contains("Nord_Amerika");
            liste.Contains("Nordamerika");


            GetKontinent(Kontinent.Asien);
        }
        static void GetKontinent(Kontinent kont)
        {
            Random rand = new Random();

            Kontinent k = (Kontinent)rand.Next(0,5);
            
        }
    }
}
