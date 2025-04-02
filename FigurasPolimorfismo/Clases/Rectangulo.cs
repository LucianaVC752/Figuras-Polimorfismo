using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasPolimorfismo
{
    public class Rectangulo : Figura
    {
        private int ancho;
        private int alto;
        public Rectangulo(int coordenadaX, int coordenadaY, Color color) : base(coordenadaX, coordenadaY, color)
        {
            this.ancho = 50;
            this.alto = 25;
        }

        public override void Dibujar(Graphics gr)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                gr.FillRectangle(brush, CoordenadaX, CoordenadaY, ancho, alto);
            }
        }
    }
}
