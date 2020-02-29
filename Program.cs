using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.WriteLine("Gib den ersten Summanden ein");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Gib den zweiten Summanden ein");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Gleitkommazahlen
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            double summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();

        }
    }
}
