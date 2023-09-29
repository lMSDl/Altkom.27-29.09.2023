using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Produkt
    {
        //metoda konstrukcyjna  (konstruktor) - bezparametrowy
        //brak określenia typu zwracanego i nazwa taka sama jak nazwa klasy
        //jeśli klasa nie ma żadnego zdefiniowanego konstruktora, to konstruktor bezparametrowy jest generowany automatycznie
        //metody konstrukcyjne są potrzebne, aby wstępnie skonfugorować produkt
        public Produkt()
        {
            Nazwa = "Brak nazwy";
        }

        //konstruktor parametrowy - służy do zapewnienia klasie wartości początkowych przekazanych jako parametry
        //jeśli w klasie występuje jakiś konstuktor parametrowy, to konstuktor bezparametrowy nie zostanie automatycznie wygenerowany
        //chcąc posiadać jednocześnie konstruktor parametrowy i bezparametrowy musimy go jawnie utworzyć
        public Produkt(string nazwa, float cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }

        public Produkt(string nazwa)
        {
            Nazwa = nazwa;
        }

        //nie pozwalamy modyfikować nazwy produktu z zewnątrz
        //nazwa jest ustawiana przez konstruktor
        public string Nazwa { get; private set; }
        public float Cena { get; set; }

        //przeciążenie metody = wiele metod o tej samej nazwie, ale przyjmujące inne parametry
        public string PobierzOpis(string format)
        {
            return string.Format(format, Nazwa, Cena);
        }
        public string PobierzOpis()
        {
            string opis = $"{Nazwa}: {Cena:f2}zł";
            return opis;
        }


        public override string ToString()
        {
            return PobierzOpis();
        }
    }
}
