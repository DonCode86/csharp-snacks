// See https://aka.ms/new-console-template for more information


//---------------------------SNACK 1---------------------------------------//

//Console.WriteLine("inserisci il primo numero");
//string number1 = Console.ReadLine();
//Console.WriteLine("inserisci il secondo numero");
//string number2 = Console.ReadLine();

//if (int.Parse(number1) > int.Parse(number2))
//{
//    Console.WriteLine("Il numero maggiore è: " + number1);
//}
//else if (int.Parse(number1) < int.Parse(number2))
//{
//    Console.WriteLine("Il numero maggiore è: " + number2);
//} else
//{
//    Console.WriteLine("I numeri sono uguali");
//}
//Console.WriteLine();


//-----------------------------SNACK 2----------------------------------------//

Console.WriteLine("inserisci la prima parola");
string phrase1 = Console.ReadLine();
Console.WriteLine("inserisci la seconda parola");
string phrase2 = Console.ReadLine();

if (phrase1.Length > phrase2.Length)
{
    Console.WriteLine("La prima parola è più lunga");
} else if (phrase2.Length > phrase1.Length) {
    Console.WriteLine("La secondo parola è la più lunga");
} else
{
    Console.WriteLine("Le due parole hanno la stessa lunghezza");
}