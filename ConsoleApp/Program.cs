
//deklaracja zmiennej lokalnej o typue string (ciąg/łańcuch znaków) i nazwie helloVariable
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