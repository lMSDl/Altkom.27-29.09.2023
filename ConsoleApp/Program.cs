
//deklaracja zmiennej lokalnej o typue string (ciąg/łańcuch znaków) i nazwie helloVariable
using System.Globalization;

string helloVariable;
//inicjalizację zmiennej - pierwsze przypisanie wartości
helloVariable = "Hello";

//nie możemy używać niezainicjalizowanych zmiennych
//wywołanie metody na konsoli (każda metoda ma nawiasy () )
Console.Write(helloVariable); //Write - wypisanie na konsole bez znaku nowej linii na końcu

//deklaracja z inicjalizacją
string target = "World";

Console.WriteLine(target); //WriteLine - wypisanie na konsole ze znakiem nowej linii na końcu

//zmiana wartości - każde kolejne przypisanie wartości
target = "Class";

Console.WriteLine(target);
//; - średnik oznacza koniec instrukcji

string output;

//łączenie stringów za pomocą operatora +
output = helloVariable + " " + target + "!"; //łączenie stringów to wyprodukowanie nowego stringa na postawie innych
Console.WriteLine(output);

Console.WriteLine("Podaj swoje imię:");
target = Console.ReadLine();
Console.WriteLine(output); // output nie uległ zmianie

output = string.Concat(helloVariable, " ", target, "!"); //łączenie stringów za pomocą funkcji Concat
Console.WriteLine(output); //nowy output uwzględnia zmianę "target"

string format = "{1} {0}!"; //wartości w nawiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
output = string.Format(format, target, helloVariable); //łączenie stringów za pomocą funkcji Format
Console.WriteLine(output);

output = $"{helloVariable} {target}!"; //łączenie stringów wykorzystując interpolację (string interpolowany)
Console.WriteLine(output);


//Lenth - właściwość (brak nawiasów odróżnia ją od metody) - przetrzymuje dane
Console.WriteLine($"Długość stringa \"{output}\" to {output.Length}"); // \ - ukośnik opadający aktywuje znak specjalny/zastrzeżony

//Count() - metoda (ma nawaiasy) oblicza ilość znaków
Console.WriteLine($"Długość stringa \"{output}\" to {output.Count()}");

//stringów nie możemy edytować, żeby zmienić wartość należy wytworzyć nowego stringa i przypisać pod zmienną
//zastąpienie części znaków - czułe na wielkość liter
output = output.Replace("Hello", "Hi");
Console.WriteLine(output);
//zastąpienie części znaków - niezależne od wielkości liter
output = output.Replace("hi", "Welcome", ignoreCase: true, CultureInfo.InvariantCulture );
Console.WriteLine(output);

//obliczamy ile znaków usunąć z końca
output = output.Substring(5, output.Length - 5 - 1);
Console.WriteLine(output);

//Equals porównuje czy obiekty są tym samym obiektem. Produktem metody jest zmienna bool (prawda/fałsz)
bool isEqual = helloVariable.Equals("Hi");
Console.WriteLine(isEqual);

// == - operator porównania, dla string działa tak samo jako Equals
isEqual = helloVariable == "Hello";
Console.WriteLine(isEqual);

//porównanie z ignorowaniem wielkości znaków
isEqual = helloVariable.Equals("hello", StringComparison.InvariantCultureIgnoreCase);
Console.WriteLine(isEqual);


//usuwanie białych znaków z poćżatku i/lub końca
output = "      ala ma kota       ";
Console.WriteLine(output + "|");
Console.WriteLine(output.Trim() + "|");
Console.WriteLine(output.TrimEnd() + "|");
Console.WriteLine(output.TrimStart() + "|");