using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// Date: 25/02/2023
/// Name: Juan Jose Soto Echavarria 
/// Description: aplicacion de articulos utilizando clase abstracta 
/// </summary>

namespace cnArticle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsType4 pan = new clsType4("panela", 2000);
            pan.name();
            Console.WriteLine("Tipo: {0}", pan.TYPE);
            Console.WriteLine("Nombre: {0}", pan.Name);
            Console.WriteLine("Precio: {0}", pan.Price + " $");
            Console.WriteLine("Iva: {0}", pan.IVAPart() + " $");

            Console.WriteLine();

            clsType7 are = new clsType7("Arepas", 3000);
            are.name();
            Console.WriteLine("Tipo: {0}", are.TYPE );
            Console.WriteLine("Nombre: {0}", are.Name);
            Console.WriteLine("Precio: {0}", are.Price + " $");
            Console.WriteLine("Iva: {0}", are.IVAPart());

            Console.WriteLine();

            clsType17 lec = new clsType17("Leche", 4000);
            lec.name();
            Console.WriteLine("Tipo: {0}", lec.TYPE);
            Console.WriteLine("Nombre: {0}", lec.Name);
            Console.WriteLine("Precio: {0}", lec.Price + " $");
            Console.WriteLine("Iva: {0}", lec.IVAPart() + " $");
            Console.WriteLine();

            

            Console.ReadKey();
        }
    }
}
