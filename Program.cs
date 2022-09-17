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

//string[] stringArray = { "Rossi", "Esposito", "Brambilla", "Ciccarelli" };
//Console.WriteLine("Prego inserire il proprio Cognome e premere Invio");
//string value = Console.ReadLine();  
//int pos = Array.IndexOf(stringArray, value);
//if (pos > -1)
//{
//    Console.WriteLine("sei in lista!");
//}else
//{
//    Console.WriteLine("non sei in lista!");
//}


//------------------------------SNACK 7---------------------------------------//

//int[] numbers = new int[6];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Inserire un numero");
//    int userInput = Convert.ToInt32(Console.ReadLine());
//    if (userInput % 2 == 1)
//    {
//        numbers[i] = userInput;
//    }
//}
//Console.WriteLine("Ti mostro solo i numeri dispari che hai inserito: " + string.Join(", ", numbers));


//------------------------------SNACK 8---------------------------------------//

//int[] numbers = { 90, 12, 35, 51, 24, 4, 16, 81, 9 };
//int sum = 0;
//Console.WriteLine("La lista dei numeri è la seguente:");
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum = sum + numbers[i];
//    }

//    Console.WriteLine(numbers[i]);
//}
//Console.WriteLine("La somma degli elementi in posizione dispari all'interno dell'array è:" + sum);

//------------------------------SNACK 9---------------------------------------//

//int[] numbers = new int[51];
//int sum = 0;
//Console.WriteLine("Inserisci un numero fino a che la somma dei numeri che hai inserito non sara' maggiore o uguale di 50!");
//do
//{
//    Console.WriteLine("Inserisci un numero");
//    int userNumber = Convert.ToInt32(Console.ReadLine());
//    sum = sum + userNumber;
//} while (sum < 50);
//Console.WriteLine("La somma dei numeri che hai inserito è: " + sum);

//------------------------------SNACK 10---------------------------------------//

//Console.WriteLine("Inserisci il numero di array che vuoi creare!");
//int N = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < N; i++)
//{
//    int[] numbers = new int[10];
//    for (int k = 0; k < 10; k++)
//    {
//        Random r = new Random();
//        numbers[k] = r.Next(1, 100);
//    }
//    Console.WriteLine("Array creato: " + string.Join(", ", numbers));
//}

//------------------------------SNACK 11---------------------------------------//

Console.WriteLine("Inserisci la prima parola!");
string firstWord = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola!");
string secondWord = Console.ReadLine();

compareWords(firstWord, secondWord);

void compareWords(string firstInput, string secondInput)
{
	if (firstInput.Length == secondInput.Length)
	{
		Console.WriteLine("Le parole che hai inserito hanno la stessa lunghezza e sono: " + firstInput + " , " + secondInput);
	}
	else if (firstInput.Length > secondInput.Length)
	{
		Console.WriteLine("La parola piu' lunga che hai inserito è: " + firstInput);
	}
	else
	{
		Console.WriteLine("La parola piu' lunga che hai inserito è: " + secondInput);
	}
}

