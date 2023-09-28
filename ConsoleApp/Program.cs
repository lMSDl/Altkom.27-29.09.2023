﻿using System.Globalization;


int a = 11;
int b = 4;

int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
c = a - b;
Console.WriteLine($"{a} - {b} = {c}");
c = a * b;
Console.WriteLine($"{a} * {b} = {c}");
c = a / b; // część dziesiętna jest ucięta
Console.WriteLine($"{a} / {b} = {c}");
c = a % b; //reszta z dzielenia
Console.WriteLine($"{a} % {b} = {c}");

float aa = 11f;
float bb = 4.0f;
float cc = aa + bb;
Console.WriteLine($"{aa} + {bb} = {cc}");
cc = aa - bb;
Console.WriteLine($"{aa} - {bb} = {cc}");
cc = aa * bb;
Console.WriteLine($"{aa} * {bb} = {cc}");
cc = aa / bb;
Console.WriteLine($"{aa} / {bb} = {cc}");

//aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
//możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
cc = 1f * a / b;
Console.WriteLine($"{a} / {b} = {cc}");
//lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
cc = (float)a / b;
Console.WriteLine($"{a} / {b} = {cc}");

//kolejność działań zgodna z zasadami matematyki
c = a + a * a;
Console.WriteLine($"{a} + {a} * {a} = {c}");
c = (a + a) * a;
Console.WriteLine($"({a} + {a}) * {a} = {c}");



Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");
Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

//dzielenie przez float/double/decimal daje wynik o wyższej precyzji
Console.WriteLine(5 / 3.3f);
Console.WriteLine(5 / 3.3d);
Console.WriteLine(5 / 3.3m);

//Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
//domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej ("financial rounding")
Console.WriteLine(Math.Round(2.5));
Console.WriteLine(Math.Round(3.5));

//zaokrąglanie klasyczne
Console.WriteLine(  Math.Round(2.5, MidpointRounding.AwayFromZero) );
Console.WriteLine(  Math.Round(3.5, MidpointRounding.AwayFromZero) );


//formatowanie liczb
Console.WriteLine($"{9:0#}");
Console.WriteLine($"{19:0#}");


Console.WriteLine("Podaj jakąś wartość liczbową:");
string input = Console.ReadLine();

//parsowanie/konwersja string na int
int intInput = int.Parse(input);
//parsowanie/konwersja string na float
float floatInput = float.Parse(input);

float value = intInput / 2f;
Console.WriteLine(value);


int wartoscInt = 5;
long wartoscLong = wartoscInt;

Console.WriteLine(wartoscLong);

wartoscLong = 9223372036854775807;
//rzutowanie - chcąc przypisać wartość o wyższej prezycji do zmiennej o niższej precyzji musimy zastosować rzutowanie
wartoscInt = (int)wartoscLong;
Console.WriteLine(wartoscInt);

float wartoscFloat = 4.5f;
double wartoscDouble = wartoscFloat;

wartoscFloat = (float)wartoscDouble;

DateTime dataCzas = DateTime.Parse("10-3-2022");
dataCzas = DateTime.ParseExact("10-3-2022", "dd-M-yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(dataCzas);

float wartoscMaksymalna = Math.Max(wartoscInt, wartoscFloat);
//niektóre metody zwracają inny typ danych, niż ten z którego korzystamy, więc tu przydaje się rzutowanie
float wartoscSrednia = (float)Math.Pow(wartoscFloat, 2);



void StringDemo()
{

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


    //Lenth - właściwość (brak nawiasów odróżnia ją od metody) - przetrzymuje dane
    Console.WriteLine($"Długość stringa \"{output}\" to {output.Length}"); // \ - ukośnik opadający aktywuje znak specjalny/zastrzeżony

    //Count() - metoda (ma nawaiasy) oblicza ilość znaków
    Console.WriteLine($"Długość stringa \"{output}\" to {output.Count()}");

    //stringów nie możemy edytować, żeby zmienić wartość należy wytworzyć nowego stringa i przypisać pod zmienną
    //zastąpienie części znaków - czułe na wielkość liter
    output = output.Replace("Hello", "Hi");
    Console.WriteLine(output);
    //zastąpienie części znaków - niezależne od wielkości liter
    output = output.Replace("hi", "Welcome", ignoreCase: true, CultureInfo.InvariantCulture);
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

}