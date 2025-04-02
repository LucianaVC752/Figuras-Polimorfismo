using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasPolimorfismo
{
    public class Linea : Figura
    {
        private int x2;
        private int y2;
        private float grosor;
        public Linea(int coordenadaX, int coordenadaY, Color color) : base(coordenadaX, coordenadaY, color)
        {
            this.x2 = coordenadaX + 50;
            this.y2 = coordenadaY;
            this.grosor = 2.0f;
        }

        public override void Dibujar(Graphics gr)
        {
            using (Pen pen = new Pen(Color, grosor))
            {
                gr.DrawLine(pen, CoordenadaX, CoordenadaY, x2, y2);
            }
        }
    }
}
