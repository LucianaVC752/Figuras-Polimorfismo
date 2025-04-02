using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasPolimorfismo
{
    public abstract class Figura
    {
       public int CoordenadaX {  get; set; }
       public int CoordenadaY { get; set; }
        
       public Color Color { get; set; }
         public Figura(int coordenadaX, int coordenadaY, Color color) 
        {
            CoordenadaX = coordenadaX;
            CoordenadaY = coordenadaY;
            Color = color;
        }

        public abstract void Dibujar(Graphics gr);
    }
}
