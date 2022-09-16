// See https://aka.ms/new-console-template for more information
Console.WriteLine("inserisci il primo numero");
string number1 = Console.ReadLine();
Console.WriteLine("inserisci il secondo numero");
string number2 = Console.ReadLine();

if (int.Parse(number1) > int.Parse(number2))
{
    Console.WriteLine("Il numero maggiore è: " + number1);
}
else if (int.Parse(number1) < int.Parse(number2))
{
    Console.WriteLine("Il numero maggiore è: " + number2);
} else
{
    Console.WriteLine("I numeri sono uguali");
}
Console.WriteLine();


