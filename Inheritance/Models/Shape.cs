using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //każda klasa dziedziczy niejawnie po klasie Object
    internal abstract class Shape /*: Object*/
    {
        //protected - modyfikator dostępu pozwalający korzystać typom pochodnym ale na zewnątrz działa jak private
        protected string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        //override - nadpisujemy metodę z klasy bazowej (czyli tej po której dziedziczymy)
        public override string ToString()
        {
            return Name;
        }
    }
}
