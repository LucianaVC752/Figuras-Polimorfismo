using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasPolimorfismo
{
    public class Triangulo : Figura
    {
        private int tamaño;
        public Triangulo(int coordenadaX, int coordenadaY, Color color) : base(coordenadaX, coordenadaY, color)
        {
            this.tamaño = 50;
        }

        public override void Dibujar(Graphics gr)
        {
            Point[] puntos = new Point[3];
            puntos[0] = new Point(CoordenadaX, CoordenadaY + tamaño); 
            puntos[1] = new Point(CoordenadaX + tamaño, CoordenadaY + tamaño); 
            puntos[2] = new Point(CoordenadaX + (tamaño / 2), CoordenadaY); 

            using (SolidBrush brush = new SolidBrush(Color))
            {
                gr.FillPolygon(brush, puntos);
            }
        }
    }
}
