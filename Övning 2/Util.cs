using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    public static class Util
    {
        //Kollar att input är ett positivt nummer
        public static uint checkInt()
        {
            do
            {
                var input = Console.ReadLine();
                if (uint.TryParse(input, out uint answer))
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Skriv ett positivt nummer");
                }
            } while (true);
        }
    }
}
