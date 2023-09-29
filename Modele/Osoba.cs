//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace zaciągamy używając "using"
namespace Modele
{
    //public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które są wytwarzane na jej podstawie
    //pełna nazwa klasy to <namespace>+<nazwa>
    public class Osoba
    {
        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy
        //brak modyfikatora dostępu == private
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        private string _imie;

        //setter - do ustawiania wartości imienia - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        public void SetImie(string imie)
        {
            _imie = imie.Trim();
        }

        //getter dobrania wartości pola _imie - metoda zwraca typ zgodny z typem pola
        public string GetImie()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return _imie;
        }



        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość zmiany modyfikatora dostępu dla getter lub setter (osobno)
        public int Wiek { get; /*private*/ set; }

        //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze
        private string _nazwisko;
        //full-property
        public string Nazwisko
        {
            //getter dla property
            get 
            { 
                return _nazwisko.ToUpper(); 
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                _nazwisko = value.Trim();
            }
        }






        //metoda - zachowanie klasy
        //void - metoda nic nie zwaraca
        public void ShowDateTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        //metoda zwraca obiekt daty i czasu
        public DateTime GetDateTime()
        {
            //return - instukcja zwracająca wynik metody
            return DateTime.Now;
        }
    }
}