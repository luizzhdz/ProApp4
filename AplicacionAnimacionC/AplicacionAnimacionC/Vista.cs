using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AplicacionAnimacionC
{
    class Vista
    {
        private Graphics g;
        private int anchura, altura;
        private Pen lapiz;
        public Color colorlapiz { set; get; }

        public Vista(Panel areadibujo)
        {
            g = areadibujo.CreateGraphics();
            anchura = areadibujo.Width;
            altura = areadibujo.Height;
        }

        public void mostrar_circulo(Circulo c)
        {
            g.DrawEllipse(new Pen(colorlapiz,3), c.centro.X, c.centro.Y, c.radio, c.radio);
        }


        

    }
}
