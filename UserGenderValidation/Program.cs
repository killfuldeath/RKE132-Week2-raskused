// Imelik kuidas see ei julgenud week2 asje ümber kopeerida, coward ig

Console.WriteLine("What is your gender? (M/F)");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("What is your last name?");

string lname = Console.ReadLine();

if (userGender == 'm')
{ 
    Console.WriteLine($"Welcome, Mr. {lname}!");
}
if (userGender == 'f') //päris?
{ 
    Console.WriteLine($"Welcome, Ms. {lname}!");
}
else
{
    Console.WriteLine("Welcome!");
}
//ma tahan et sa teaksid et f ja m EI TOHI olla suured tähed, muidu see millegipärast otsustab loll olla
//veel üks väike btw, ma suutsin selle asja teha enne teie videot, kuldmedal mulle ig ._.