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
        public Rectangulo(int coordenadaX, int coordenadaY, Color color) : base(coordenadaX, coordenadaY, color)
        {
        }

        public override Graphics Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
