using System.Globalization;
using Modele;


Produkt produkt1 = new Produkt();
Produkt produkt2 = new Produkt("Herbata", 58.22f);
Produkt produkt3 = new Produkt();
Produkt produkt4 = new Produkt();

produkt1.Nazwa = "Kawa";
produkt1.Cena = 13.24f;


/*produkt2.Nazwa = "Herbata";
produkt2.Cena = 55.22f;*/


produkt3.Nazwa = "Mleko";
produkt3.Cena = 2.24f;

Console.WriteLine(produkt1.PobierzOpis());

Console.WriteLine(produkt2.PobierzOpis());

Console.WriteLine(produkt3.PobierzOpis("Produkt o nazwie {0} kosztuje {1} zł"));

Console.WriteLine(produkt4.PobierzOpis());




//new - wytwarzamy nowy obiekt (instancję) klasy Osoba
Modele.Osoba osoba = new Osoba();
Modele.Osoba osoba1 = new Osoba();
Modele.Osoba osoba2 = new Osoba();
Modele.Osoba osoba3 = new Osoba();

Console.WriteLine(osoba.GetType().Name);
Console.WriteLine(osoba.GetType().Namespace);
Console.WriteLine(osoba.GetType().FullName);


osoba.ShowDateTime();

DateTime dataCzas = osoba.GetDateTime();
Console.WriteLine(dataCzas);

osoba.SetImie("   Adam   ");
Console.WriteLine(osoba.GetImie());

osoba.Nazwisko = "    Adamski   ";

Console.WriteLine(osoba.Nazwisko);

osoba1.SetImie("Ewa");
osoba1.Nazwisko = "Ewowska";
Console.WriteLine(osoba1.GetImie());
Console.WriteLine(osoba1.Nazwisko);


void ForDemo()
{
    //I - inicjalizacja pętli - wykonuje siuę tylko raz na początku
    //II - warunek kontynuacji pętli - wykonuje się przed każdym wykonaniem ciała
    //III - ciało pętli
    //IV - akcja po wykonaniu ciałą - najczęsciej inkrementacja licznika
    //for(I ; II ; IV)
    //{ III }

    for (int i = 0; i < 5; i++ /*i = i+1*/)
    {
        Console.WriteLine(i);
    }


    //pętla nieskończona
    /*for(; ; )
    {
        Console.WriteLine("*");
    }*/


    int licznik = 5;
    for (; licznik >= 0; licznik--)
    {
        Console.WriteLine(licznik);
    }

    //odpowiednik pętli while
    for (; licznik < 4;)
    {
        Console.WriteLine(licznik++);
    }


    Console.WriteLine("Podaj liczby po spacji:");
    string ciagWejsciowy = Console.ReadLine();

    string[] podzielonyCiagWejsciowy = ciagWejsciowy.Split(" ");
    float[] liczby = new float[podzielonyCiagWejsciowy.Length];


    for (int i = 0; i < liczby.Length; i++)
    {
        liczby[i] = float.Parse(podzielonyCiagWejsciowy[i]);
    }

    for (int i = liczby.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(liczby[i]);
    }

    //foreach - pozwala przejsc po wszystkich elementach tablicy
    foreach (float liczba in liczby)
    {
        Console.WriteLine(liczba);
    }
    //foreach zastępuje poniższy sposób iteracji po tablicy
    for (int i = 0; i < liczby.Length; i++)
    {
        float liczba = liczby[i];
        Console.WriteLine(liczba);
    }
}



void DoWhileDemo()
{
    float wartoscFloat;
    bool wartoscPoprawna;

    //do-while - sprawdza warunek po wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
    //pozwala to wyeliminować inicjalizację zminnych przed wejściem do pętli
    do
    {
        Console.WriteLine("Podaj liczbę:");
        string wartoscString = Console.ReadLine();
        wartoscPoprawna = float.TryParse(wartoscString, out wartoscFloat);

        if (!wartoscPoprawna)
        {
            Console.WriteLine("Podana wartość nie jest liczbą");
        }
    } while (!wartoscPoprawna); //w przypadku do-while na końcu występuje średnik ;

    Console.WriteLine($"Twoja liczba to {wartoscFloat}");
}

void WhileDemo()
{

    //musimy zainicjalizować zmienną, ponieważ istnieje szansza, że pętla się nie wykona i zmienna nie zostanie zainicjalozowana, a za pętlą ma być użyta
    float wartoscFloat = 0;
    bool wartoscPoprawna = false;

    //while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany przed każdym wejściem do pętli
    // jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona
    //while(true) = pętla nieskończona

    while (!wartoscPoprawna)
    {
        Console.WriteLine("Podaj liczbę:");
        string wartoscString = Console.ReadLine();
        wartoscPoprawna = float.TryParse(wartoscString, out wartoscFloat);

        if (!wartoscPoprawna)
        {
            Console.WriteLine("Podana wartość nie jest liczbą");
        }
    }

    Console.WriteLine($"Twoja liczba to {wartoscFloat}");

}



void SwitchDemo()
{

    Console.WriteLine("Podaj nazwę stopnia ze szkolej skali ocen:");
    string nazwa = Console.ReadLine();

    //switch - przyjmuje parametr, kóry jest porównywany z listą przypadkó (case)
    switch (nazwa)
    {
        //case - rozpatrywany przypadek
        //wiele case'ow może być przypisanych do tego samego kodu
        case "celujący":
        case "celująca":
            {
                Console.WriteLine(6);
                //kod wykonywany jest od case do break - nie ma potrzeby stosowaniea klamerek {}
                //case musi kończyć się instrukją break - przerywająca wykonywanie swticha
            }
            break;
        case "bardzo dobry":
        case "bardzo dobra":
            Console.WriteLine(5);
            break;
        case "dobry":
        case "dobra":
            Console.WriteLine(4);
            break;
        case "dostateczny":
        case "dostateczna":
            Console.WriteLine(3);
            break;
        case "dopuszczający":
        case "dopuszczająca":
            Console.WriteLine(2);
            break;
        case "niedostateczny":
        case "niedostateczna":
            Console.WriteLine(1);
            break;
        //default - odpowiedniek else, czyli wykonanie kodu, jeśli nie znalezioni odpowiedniego case
        default:
            Console.WriteLine("W skali ocen nie występuje taki stopień");
            break;
    }

    /*if (nazwa == "celujący" || nazwa == "celująca")
    {
        Console.WriteLine(6);
    }
    else if (nazwa == "bardzo dobry")
    {
        Console.WriteLine(5);
    }
    else if (nazwa == "dobry")
    {
        Console.WriteLine(4);
    }
    else if (nazwa == "dostateczny")
    {
        Console.WriteLine(3);
    }
    else if (nazwa == "dopuszczający")
    {
        Console.WriteLine(2);
    }
    else if (nazwa == "niedostateczny")
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine("W skali ocen nie występuje taki stopień");
    }*/


    string wartosc = Console.ReadLine();
    int wartoscLiczbowa = int.Parse(wartosc);

    switch (wartoscLiczbowa)
    {
        case > 0:
            Console.WriteLine($"{wartosc} jest > 0");
            break;
        case < 0:
            Console.WriteLine($"{wartosc} jest < 0");
            break;
        case 0:
            Console.WriteLine($"{wartosc} jest = 0");
            break;
    }
}


void IfDemo()
{

    Console.WriteLine("Podaj bok kwadratu:");
    string daneOdUzytkownika = Console.ReadLine();


    if (daneOdUzytkownika != "exit")
    {
        float bokKwadratu;

        //TryParse - zwraca wartość bool mówiącą czy parsowanie się powiodło
        //out - parameter wyjściowy - parametr przez który metoda może nam zwrócić jakąś dodatkową wartość (w tym przypadku jest to wynik parsowania)
        // jeśli parsowanie się nie powiodło, to w parametrze wyjściowym będzie wpisana wartość domyślna typu (dla typów liczbowych jest to 0)
        bool jestToWartoscLiczbowa = float.TryParse(daneOdUzytkownika, out bokKwadratu);
        if (!jestToWartoscLiczbowa)
        {
            Console.WriteLine("Błędna wartość");
        }
        else
        {

            //if sprawdza watunek w nawiasie i jeśli jest on prawdziwy, to wykonuje się blok kodu pod nim
            // > - znak większości
            if (bokKwadratu > 0)
            {
                float obwod = bokKwadratu * 4;
                Console.WriteLine($"Kwadrat o boku {bokKwadratu} na obwód {obwod}");
            }
            // jeśli poprzedni warunek nie jest spełniony, to sprawdzany jest kolejny if
            // else if - może występować wielokrotne
            else if (bokKwadratu < 0)
            {
                Console.WriteLine("Nie mogę policzyć obwodu z boku mniejszego niż zero");
            }
            //else - wykonuje blok kodu w każdym innym przypadku
            else
            {
                Console.WriteLine("Kwadrat nie istnieje");
            }

            //jeżeli używany else, to tylko jeden blok kodu zostanie wykonany i sprawdzanie warunków zakończy się w przypadku wejścia w któryś z bloków
            //jeżeli nie używamy else, to każdy if będzie traktowany osobno i warunek będzie sprzwdzany niezależnie
            //wniosek else jest też łącznikiem między kolejnymi if'ami


            //!= - znak nierówności 
            if (bokKwadratu != 0)
            {
                Console.WriteLine("Bok jest różny od 0");
            }

            //znak równości
            if (bokKwadratu == 0)
            {
                Console.WriteLine("Bok jest równy 0");
            }


            bool rezultat = bokKwadratu == 0; //porównanie
            rezultat = bokKwadratu != 0; //nierówność
            rezultat = bokKwadratu > 0; //większe
            rezultat = bokKwadratu < 0; //mniejsze
            rezultat = bokKwadratu >= 0; //większe bądź równe
            rezultat = bokKwadratu <= 0; // mniejsze bądź równe

            rezultat = bokKwadratu < 0 || bokKwadratu == 0; // || - logiczne lub (OR)
            rezultat = bokKwadratu > 0 && bokKwadratu <= 10; // && - logiczne i (AND)


            if (rezultat)
            {
                Console.WriteLine("Bok kwadratu jest z przedziału (0;10>");
            }

            //! - negacja - zaprzeczenie tego co występuje po wykrzykniku
            if (!rezultat)
            {
                Console.WriteLine("Bok kwadratu nie jest z przediału (9:10>");
            }
        }

    }
}



void ListDemo()
{

    //tworzymy nową listę. Lista po inicjalizacji jest pusta.
    List<string> mojaLista = new List<string>();

    //dodajemy nowy element do listy, rozmiar tablicy się zwiększa
    mojaLista.Add("!");
    mojaLista.Add("ala");
    mojaLista.Add("kota");

    //stawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
    mojaLista.Insert(1, "ma");

    mojaLista.Add("!");
    mojaLista.Add("!");

    //usuwamy element pod indeksem 2 - rozmiar listy się zmniejsza
    mojaLista.RemoveAt(2);
    //usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
    mojaLista.Remove("!");

    Console.WriteLine();

    //wypisujemy element po indeksem 1
    Console.WriteLine(mojaLista[1]);
    Console.WriteLine($"Lista ma rozmiar: {mojaLista.Count}");

    //przekształcenie tablicy do listy
    List<string> listaWyrazw = Console.ReadLine().Split(" ").ToList();
}


void ArrayDemo()
{

    int a = 5;
    int b = 10;
    int c = 15;


    //deklaracja tablicy przechowującej dane typu int
    //[] - tablica
    int[] tablicaInt;
    //inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
    tablicaInt = new int[3];

    //tablice są indeksowane od 0 (minimalny indeks)
    //odwołujemy się do pierwszgo elemntu tablicy, czyli pod indeks 0
    tablicaInt[0] = a;
    tablicaInt[1] = b;
    //maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
    tablicaInt[2] = c;

    Console.WriteLine(tablicaInt[1]);
    Console.WriteLine(tablicaInt[0]);
    Console.WriteLine(tablicaInt[2]);

    Console.WriteLine($"Tablica ma rozmiar {tablicaInt.Length}");


    string[] tablicaWartosci = new string[3];
    //wpisujemy do tablicy wartość bezpośrednio z konsoli pod indeks 0
    tablicaWartosci[0] = Console.ReadLine();

    Console.WriteLine("Napisz coś:");

    string historyjka = Console.ReadLine();

    //tablica zwracana jako rezultat wywołania metody
    //metoda split dzieli string na części wg wskazanego separatora
    string[] wyrazy = historyjka.Split(" ");
    //pobieramy wielkość tablicy
    Console.WriteLine($"Ilość wyrazów: {wyrazy.Length}");


    int indeksPierwszegoWyrazu = 0;
    Console.WriteLine($"Pierwszy wyraz: {wyrazy[indeksPierwszegoWyrazu]}");
    int indeksOstatniegoWyrazu = wyrazy.Length - 1;
    Console.WriteLine($"Ostatni wyraz: {wyrazy[indeksOstatniegoWyrazu]}");

    int indekszTablicyWartosci = int.Parse(tablicaWartosci[0]);
    string wyraz = wyrazy[indekszTablicyWartosci];

    Console.WriteLine(wyraz);
}

void Numbers()
{

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
    Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
    Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));


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

    float poleKola = (float)(3.14 * Math.Pow(wartoscFloat, 2));
    poleKola = (float)(Math.PI * wartoscFloat * wartoscFloat);

    Console.WriteLine($"{poleKola:f2}");
}

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