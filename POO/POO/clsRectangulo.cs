using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace POO
{
    class clsLinea
    {
        private int XInicial;
        private int YInicial;
        private int XFinal;
        private int YFinal;
        private static int contar = 0;
        public clsLinea()
        {
            XInicial = 0;
            YInicial = 0;
            XFinal = 0;
            YFinal = 0;
        }
       
        public clsLinea(int xi, int yi,int xf, int yf)
        {
            this.XInicial = xi;
            this.YInicial = yi;
            this.XFinal = xf;
            this.YFinal = yf;
        }

        public clsLinea(double xi, double yi, double xf,double yf)
        {
            this.XInicial = (int)xi;
            this.YInicial = (int)yi;
            this.XFinal = (int)xf;
            this.YFinal = (int)yf;
        }


        public static int ContarLineas()
        {
            contar += 1;
            return contar;
        }
    }
}
