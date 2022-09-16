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

//Console.WriteLine("inserisci la prima parola");
//string phrase1 = Console.ReadLine();
//Console.WriteLine("inserisci la seconda parola");
//string phrase2 = Console.ReadLine();

//if (phrase1.Length > phrase2.Length)
//{
//    Console.WriteLine("La prima parola è più lunga");
//} else if (phrase2.Length > phrase1.Length) {
//    Console.WriteLine("La secondo parola è la più lunga");
//} else
//{
//    Console.WriteLine("Le due parole hanno la stessa lunghezza");
//}


//------------------------------SNACK 3---------------------------------------//

//int number, sum = 0;
//Console.WriteLine("Inserisci dieci numeri e calcolerò la loro somma!!");

//for (int i = 0; i < 10; i++)
//{
//    Console.Write("inserisci il numero {0}:", i + 1);
//    number = Convert.ToInt32(Console.ReadLine());
//    sum += number;

//}

//Console.WriteLine("La somma dei 10 numeri che hai inserito è: {0}", sum);
//Console.WriteLine();


//------------------------------SNACK 4---------------------------------------//

//double sum = 0, avg = 0;
//double[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//avg = sum / numbers.Length;

//Console.WriteLine("La lista dei numeri è: {0}", string.Join(", ", numbers));
//Console.WriteLine("la somma dei numeri è : " + sum);
//Console.WriteLine("la media dei numeri è : " + avg);

//Console.Read();

//------------------------------SNACK 5---------------------------------------//

//Console.WriteLine("Inserisci un numero");
//string userNumber = Console.ReadLine();
//int num1 = 0;
//num1 = int.Parse(userNumber);

//if (num1 % 2 == 0)
//{
//    Console.WriteLine(num1);
//} else
//{
//    Console.WriteLine(num1 + 1);
//}

//------------------------------SNACK 6---------------------------------------//