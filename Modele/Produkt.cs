using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Produkt
    {

        public string Nazwa { get; set; }
        public float Cena { get; set; }


        public string PobierzOpis()
        {
            string opis = $"{Nazwa}: {Cena:f2}zł";
            return opis;
        }

    }
}
