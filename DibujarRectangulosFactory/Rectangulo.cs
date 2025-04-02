using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Rectangulo : Figura
    {
        public int Contador { get; set; }
        
        public Rectangulo(int x, int y, Color color, int contador) : base(x, y, color)
        {
            Contador = contador;
        }

        public int IncrementarContador()
        {
            Contador++;
            return Contador;
        }

        public override void Dibujar(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, 100, 50); // Dibuja un rectángulo de tamaño fijo
            }
        }
    }
}
