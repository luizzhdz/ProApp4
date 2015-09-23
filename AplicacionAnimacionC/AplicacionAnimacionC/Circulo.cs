using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AplicacionAnimacionC
{
    class Circulo
    {
        public int radio { set; get; }
        public Point centro { set; get; }

        public Circulo(int radio, Point centro)
        {
            this.radio = radio;
            this.centro = centro;
        }

        public double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
