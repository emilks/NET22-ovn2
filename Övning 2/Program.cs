Console.WriteLine("Välkommna till övning 2 programmet!");

bool active = true;
while (active)
{
    //Huvudmenyn
    Console.WriteLine("Skriv 0 för att avsluta.");
    Console.WriteLine("Skriv 1 för att se pris för biljett.");
    Console.WriteLine("Skriv 2 för att upprepa en input 10 gånger.");
    Console.WriteLine("Skriv 3 för att ta ut det tredje ordet ur en mening.");

    uint choice = checkInt();
    switch(choice)
    {
        case 0:
            //avsluta programmet
            Console.WriteLine("Hej då");
            active = false;
            break;

        case 1:
            bio();
            break;

        case 2:
            repeat();
            break;

        case 3:
            split();
            break;

        default:
            Console.WriteLine("Felaktig input");
            break;

    }
    Console.WriteLine("\n");
}

//kollar hur många biljetter man behöver
static void bio()
{
    Console.WriteLine("Hur många biljetter vill ni köpa?");
    uint amount = checkInt();

    int totalPrice = 0;
    for (int i = 0; i < amount; i++)
    {
        totalPrice += checkAge(i+1);
    }
    Console.WriteLine($"Biljetter för {amount} personer till totalt pris: {totalPrice}");
}

//Skriver ut och returnerar priset baserat på ålder
static int checkAge(int nr)
{
    Console.WriteLine($"Skriv ut ålder för person {nr}:");
    uint age = checkInt();

    if (age < 5 || age > 100)
    {
        Console.WriteLine("Du går gratis!");
        return 0;
    }else if (age < 20)
    {
        Console.WriteLine("Ungdomspris: 80kr");
        return 80;
    }else if (age > 64)
    {
        Console.WriteLine("Pensinärspris: 90kr");
        return 90;
    }else
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

//Menyval 3: läs in en sträng och skriv ut det tredje ordet
static void split()
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

//Kollar att input är ett positivt nummer
static uint checkInt()
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

//Kollar att input är en mening med tre ord
static string[] checkSentance()
{
    do
    {
        string mening = Console.ReadLine();
        string[] lista = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (lista.Length >= 3)
        {
            return lista;
        }
        else
        {
            Console.WriteLine("Skriv en mening med minst tre ord.");
        }
    } while (true);
}
