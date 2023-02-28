using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnArticulo
{
    class clsType7 : clsArticle
    {
        public double TYPE = 7;
        public double Iva;
        public clsType7(string name, double price)
            :base(name, price)
        {
            Name = name;
        }

        public override double IvaPart()
        {
            Iva = (Price * 19) / 100;
            return Iva;
        }
        public override void name()
        {
            Console.WriteLine("Articulo: ");
        }
        public override double price()
        {
            return Price = Price;
        }
        public override double Type()
        {
            return TYPE;
        }
    }
}
