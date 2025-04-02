using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class FiguraFactory
    {
        public Figura CrearFigura(int x, int y, Color color, int contador)
        {
            return new Rectangulo(x, y, color, contador);
        }
    }
}
