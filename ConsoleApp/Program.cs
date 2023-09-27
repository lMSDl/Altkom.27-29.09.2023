
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