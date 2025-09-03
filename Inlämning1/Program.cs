using System;

namespace inlämnings_uppgift1
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Skriver ut text
            Console.WriteLine("Du är nästan klar med kapitel 1");
            Console.WriteLine("Du har lärt dig skriva ut tecken som \" och \\");

            //Ändrar texten till svart för att inte se vart programmet är localiserat.
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}