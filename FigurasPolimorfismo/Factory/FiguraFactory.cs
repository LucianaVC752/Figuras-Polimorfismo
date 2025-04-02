using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasPolimorfismo.Factory
{
    public class FiguraFactory
    {
        public static Figura CrearFigura(int coordenadaX, int coordenadaY, Color color, int tipo) 
        {
            try
            {
                switch (tipo)
                {
                    case 0:
                        return new Rectangulo(coordenadaX, coordenadaY,color);
                    case 1:
                        return new Circulo(coordenadaX, coordenadaY, color);
                    case 2:
                        return new Triangulo(coordenadaX, coordenadaY, color);
                    case 3:
                        return new Linea(coordenadaX, coordenadaY, color);
                    default:
                        return null;
                }

            }
            catch(Exception ex)
            {
                throw new ArgumentException("Ocurrió un error "+ex);
            }
        }
    }
}
