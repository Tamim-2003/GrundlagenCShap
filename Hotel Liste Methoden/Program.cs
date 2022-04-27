using System;

namespace Hotel_Liste
{
    class Program
    {
        public class arrays
        {

            public static int[] index = new int[] { 0, 1, 2, 3 };
            public static int[] zimmernummern = new int[] { 45, 23, 3, 32 };
            public static string[] vornamen = new string[] { "John", "Paul", "George", "Ringo" };
            public static string[] namen = new string[] { "Lennon", "MCCartney", "Harrison", "Starr" };
            public static int[] dauer = new int[] { 1, 4, 12, 3 };

        }

        static void Main()
        {

            int auswahl = 0;

            string zimmernummereingabe = null; string nachnameeingabe = null;

            double betrag = 82.46;

            int aussuchenneu;

            int zimmernummereingabeneu = 0;

            bool richtig = true;

            bool richtig2 = true;

            do
            {

                richtig = true;
                Console.WriteLine("Möchten sie nach Nachnamen oder Zimmernummern suchen? Geben sie bitte '1' ein für Nachnamen oder '2' für Zimmernummern:");
                string aussuchen = Console.ReadLine();
                if (!Int32.TryParse(aussuchen, out aussuchenneu))
                {
                    richtig = false;
                    Console.WriteLine("\nBitte geben sie eine gültige Eingabe ein. Bitte drücken sie eine beliebige Taste um es erneut zu versuchen:");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (richtig == false);

            Console.WriteLine();

            switch (aussuchenneu)
            {
                case 1:
                    Console.WriteLine("Geben sie bitte den Nachnamen von derjenigen Person, dessen Profil sie suchen möchten, ein:");
                    nachnameeingabe = Console.ReadLine();
                    auswahl = 1;
                    break;



                case 2:
                    do
                    {
                        richtig2 = true;
                        Console.WriteLine("Geben sie bitte die Zimmernummer von derjenigen Person, dessen Profil sie suchen möchten, ein:");
                        zimmernummereingabe = Console.ReadLine();
                        if (!Int32.TryParse(zimmernummereingabe, out zimmernummereingabeneu))
                        {
                            richtig2 = false;
                            Console.WriteLine("\nBitte geben sie eine gültige Eingabe ein. Bitte drücken sie eine beliebige Taste um es erneut zu versuchen:");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        auswahl = 2;

                    } while (richtig2 == false);

                    break;



                default:



                    break;

            }



            var data = GetData(zimmernummereingabeneu, nachnameeingabe, auswahl);

            Console.WriteLine($"\n\n{"Index",7} |{"Zimmernummer",13} |{"Vorname",9} |{"Nachname",10} |{"Übernachtungen",16} |{"Rechnungsbetrag",17}");
            Console.WriteLine($"{data.Item2,7} |{data.Item3,13} |{data.Item4,9} |{data.Item5,10} |{data.Item6,16} |{betrag * data.Item6,17}\n");

        }

        public static (bool, int, int, string, string, int) GetData(int zimmernummereingabeneu, string nachnameeingabe, int auswahl)
        {
            int value = 0;

            if (auswahl == 1)
            { value = Array.IndexOf(arrays.namen, nachnameeingabe); }
            else if (auswahl == 2)
            { value = Array.IndexOf(arrays.zimmernummern, zimmernummereingabeneu); }

            return (true, arrays.index[value], arrays.zimmernummern[value], arrays.vornamen[value], arrays.namen[value], arrays.dauer[value]);
        }







    }

}