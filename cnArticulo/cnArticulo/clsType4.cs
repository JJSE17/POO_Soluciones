using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnArticulo
{
    class clsType4 : clsArticle
    {
        public double TYPE = 4;
        public double Iva;
        public clsType4(string name, double price)
            : base(name, price)
        {
            Name = name;
            Price = price;
        }
        public override double IvaPart()
        //iva de colombia actual
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
