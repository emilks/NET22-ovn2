using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    internal class Third
    {
        //Menyval 3: läs in en sträng och skriv ut det tredje ordet
        public static void split()
        {
            bool tre = false;
            do
            {
                Console.WriteLine("Skriv en mening med minst tre ord.");
                string mening = Console.ReadLine();

                //Delar up meningen i lista med mellanslag som delimiter och tar bort tomma entries 
                string[] lista = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //Kollar att listan är minst längd tre och skriver i så fall ut ordet
                if (lista.Length >= 3)
                {
                    Console.WriteLine($"Det tredje ordet i stringen är: {lista[2]}");
                    tre = true;
                }
            } while (!tre);
        }
    }
}
