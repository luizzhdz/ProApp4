using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AplicacionAnimacionC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAnimacion.Checked)
            {
                Random aleatorio = new Random();
                panel1.BackColor = Color.LightSteelBlue;
                int r = aleatorio.Next(20, 40);
                int x = aleatorio.Next(0, panel1.Width - r);
                int y = aleatorio.Next(0, panel1.Height - r);
                Point punto = new Point(x, y);
                Circulo circulo = new Circulo(r,punto);
                Task tarea = new Task(() => animar_circulo(circulo, new Vista(panel1)));
                tarea.Start();
            }
        }

        private void animar_circulo(Circulo circulo, Vista vista)
        {
            vista.colorlapiz = Color.DarkRed;
            vista.mostrar_circulo(circulo);
            bool sentido = true;
            while (true)
            {
                while (cbAnimacion.Checked)
                {
                    Thread.Sleep(500);
                    vista.colorlapiz = Color.LightSteelBlue;
                    vista.mostrar_circulo(circulo);
                    if (sentido)
                    {
                        if (circulo.centro.X <= panel1.Width - 2 * circulo.radio)
                            circulo.centro = new Point(circulo.centro.X + circulo.radio, circulo.centro.Y);
                        else
                            sentido = false;
                    }
                    else
                    {
                        if (circulo.centro.X > circulo.radio)
                            circulo.centro = new Point(circulo.centro.X - circulo.radio, circulo.centro.Y);

                        else
                            sentido = true;
                    }
                    vista.colorlapiz = Color.DarkRed;
                    vista.mostrar_circulo(circulo);
                }
            }

        }

        
    }
}
