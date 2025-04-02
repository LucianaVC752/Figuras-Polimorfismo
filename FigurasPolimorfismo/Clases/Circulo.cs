using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasPolimorfismo
{
    public class Circulo : Figura
    {
        private int radio;
        public Circulo(int coordenadaX, int coordenadaY, Color color) : base(coordenadaX, coordenadaY, color)
        {
            this.radio = 25;
        }

        public override void Dibujar(Graphics gr)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                gr.FillEllipse(brush, CoordenadaX, CoordenadaY, radio * 2, radio * 2);
            }
        }
    }
}