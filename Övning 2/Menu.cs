using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Huvudmenyn
namespace Övning_2
{
    public static class Menu
    {
        public static void menu()
        {
            bool active = true;
            while (active)
            {
                //Huvudmenyn
                Console.WriteLine("Skriv 0 för att avsluta.");
                Console.WriteLine("Skriv 1 för att se pris för biljett.");
                Console.WriteLine("Skriv 2 för att upprepa en input 10 gånger.");
                Console.WriteLine("Skriv 3 för att ta ut det tredje ordet ur en mening.");

                uint choice = Util.checkInt();
                switch (choice)
                {
                    case 0:
                        //avsluta programmet
                        Console.WriteLine("Hej då");
                        active = false;
                        break;

                    case 1:
                        Tickets.bio();
                        break;

                    case 2:
                        Repeat.repeat();
                        break;

                    case 3:
                        Third.split();
                        break;

                    default:
                        Console.WriteLine("Felaktig input");
                        break;

                }
                Console.WriteLine("\n");
            }

        }
    }
}


