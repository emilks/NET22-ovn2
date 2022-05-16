using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    internal class Tickets
    {
        //kollar hur många biljetter man behöver
        public static void bio()
        {
            Console.WriteLine("Hur många biljetter vill ni köpa?");
            uint amount = Util.checkInt();

            int totalPrice = 0;
            for (int i = 0; i < amount; i++)
            {
                totalPrice += checkAge(i + 1);
            }
            Console.WriteLine($"Biljetter för {amount} personer till totalt pris: {totalPrice}");
        }

        //Skriver ut och returnerar priset baserat på ålder
        static int checkAge(int nr)
        {
            Console.WriteLine($"Skriv ut ålder för person {nr}:");
            uint age = Util.checkInt();

            if (age < 5 || age > 100)
            {
                Console.WriteLine("Du går gratis!");
                return 0;
            }
            else if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
                return 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensinärspris: 90kr");
                return 90;
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
                return 120;
            }
        }
    }
}
