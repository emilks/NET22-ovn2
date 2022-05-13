
Console.WriteLine("Välkommna till övning 2 programmet!");

bool active = true;
while (active)
{
    Console.WriteLine("Skriv 0 för att avsluta.");
    Console.WriteLine("Skriv 1 för att se pris för biljett.");
    Console.WriteLine("Skriv 2 för att upprepa en input 10 gånger.");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 0:
            Console.WriteLine("Hej då");
            active = false;
            break;
        case 1:
            //ålder
            Console.WriteLine("Hur många biljetter vill ni köpa?");
            int amount = Convert.ToInt32(Console.ReadLine());
            int totalPrice = 0;
            for(int i = 0; i < amount; i++)
            {
                totalPrice += checkAge();
            }
            Console.WriteLine($"Biljätter för {amount} personer till totalt pris: {totalPrice}");

            break;

        case 2:
            repeat();
            break;

        default:
            Console.WriteLine("Felaktig input");
            break;

    }
    Console.WriteLine("\n");
}

//Skriver ut och returnerar priset baserat på ålder
static int checkAge()
{
    Console.WriteLine("Skriv ut din ålder:");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 5 || age > 100)
    {
        Console.WriteLine("Du går gratis!");
        return 0;
    }else if (age < 20)
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

//Menyval 2: Upprepa input
static void repeat()
{
    Console.WriteLine("Skriv en input som ska upprepas:");
    String input = Console.ReadLine();

    for(int i = 0; i < 10; i++)
    {
        Console.Write($"{i+1}. {input}, ");
    }
    Console.Write("\n");
}

//Menyval 3: 
