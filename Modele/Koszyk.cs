using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Koszyk
    {
        private List<Produkt> _produkty;
        public int Rozmiar { get; private set; } 

        public Koszyk(int rozmiar) {
            _produkty = new List<Produkt>();
            Rozmiar= rozmiar;
        }
        

        public bool Dodaj(Produkt produkt)
        {
            if(Rozmiar > _produkty.Count)
            {
                _produkty.Add(produkt);
                return true;
            }
            return false;
        }

        public void Usuń(Produkt produkt)
        {
            _produkty.Remove(produkt);
        }


        public string CoJestWKoszyku()
        {
            string zawartosc = "";
            float wartosc = 0;

            foreach(Produkt produkt in _produkty)
            {
                zawartosc += produkt.PobierzOpis();
                zawartosc += "\n";

                wartosc += produkt.Cena;
            }

            zawartosc += $"Wartość koszyka: {wartosc}";
            return zawartosc;
        }


    }
}
