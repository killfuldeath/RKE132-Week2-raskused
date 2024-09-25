//järgmine kord on tähelepanu vajalik, õpetaja


Console.WriteLine("What is your age?");

string age = Console.ReadLine();

int userage = 0;

Console.WriteLine("One more time.");

bool isAgeNumber = Int32.TryParse(age, out userage);

int tage = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Parse result is {isAgeNumber}. User is {userage}");

if (tage >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young!");
}

if (isAgeNumber == true)
{
    if(userage >= 13)
    {
        Console.WriteLine("We repeat, welcome to Instagram!");
    }
}
else
{
   Console.WriteLine("Could not read the given age.");
}
