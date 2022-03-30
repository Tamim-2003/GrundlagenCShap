using System;

namespace Methoden
{
    class Program
    {
        private static short übernachtung;

        static void Main(string[] args)
        {
            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = { "Jahn,Paul,George,Ringo" };
            string  = nachname { "Lennon,McCartney,Harrison,Starr"};
            short = übernachtung {"1,4,12,3"};
            

            Console.WriteLine("Bitte Geben Sie  meine Daten ein");
            Console.ReadLine();

            string eingabe_str = Console.WriteLine();
            short eingabe_sh;
            Console.ReadKey();

                                        //eingabe_str, out eingabe_sh
            bool success = short.TryParse(//eingabe_str, out eingabe_sh);
            if (success)
            {
                Console.WriteLine($"Converted '{value}' to {number}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");

            }
    
}
    }
