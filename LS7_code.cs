using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4IPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int akku = 3;
            //while (akku > 0)
            //{
            //    Console.WriteLine("Noch " + akku + " Einheiten");
            //    akku--;
            //}
            ///int zeit = 5;
            //while (zeit > 0)
            //{
            //    Console.WriteLine("Noch " + zeit + " Sekunden");
            //    zeit--;
            //}
            //
            //Console.WriteLine("Start!!!");
            //int auswahl;
            //do
            //{
            //    Console.Write("Wähle 1 und 2 oder 3: ");
            //   auswahl = Convert.ToInt32(Console.ReadLine());
            //} while (auswahl < 1 || auswahl > 3);
            //Console.WriteLine("Auswahl gespeichert.");                    
            int auswahl;
            // 1. Anzahl Bücher abfragen
            do
            {
              Console.Write("Wie viele Bücher hast du von 1 bis 5 ? ");
               auswahl = Convert.ToInt32(Console.ReadLine());
            } 
            while (auswahl < 1 || auswahl > 5);
            // 2. Bücher registrieren
            for (int i = 1; i <= auswahl; i++) 
            {
                Console.WriteLine("Buch " + i + " registiert");
                           
            }
            int x = auswahl;
            // 3. Rückgabe simulieren
            while (x > 0)
            {
                Console.WriteLine("Noch " + x + " offen");
                x--;
            }   
            Console.WriteLine("Alle Bücher verarbeitet.");
        }
    }
}
