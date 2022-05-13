// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool active = true;
while (active)
{
    Console.WriteLine("Välkommna till ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 0:
            Console.WriteLine("Hej då");
            active = false;
            break;
        default:
            Console.WriteLine("Felaktig input");
            break;

    }
}