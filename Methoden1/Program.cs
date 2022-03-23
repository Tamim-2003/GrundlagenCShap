using System;

namespace Methoden1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie an wie oft der Name ausgegeben werden soll.");
            int durchlauf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie den Text ein, der ausgegeben werden soll.");

            string Text = Console.ReadLine();
            int anzahl = 0;
            anzahl = ausgabeTextMalX(durchlauf, Text);



            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);



        }



        static int ausgabeTextMalX(int durchlauf, string text)
        {



            for (int i = 0; i < durchlauf; i++)
            {
                Console.WriteLine(text);
            }



            return text.Length * durchlauf;




        }
    }
}
