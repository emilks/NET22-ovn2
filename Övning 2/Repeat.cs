using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    internal class Repeat
    {
        //Menyval 2: Upprepa input
        public static void repeat()
        {
            Console.WriteLine("Skriv en input som ska upprepas:");
            String input = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input}, ");
            }
            Console.Write("\n");
        }
    }
}
