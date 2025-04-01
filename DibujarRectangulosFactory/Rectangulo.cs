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
        private static int contador = 0; 
        public static int Contador => contador;
        public Rectangulo(int x, int y, Color color) : base(x, y, color)
        {
            contador++; // Incrementa el contador al crear una instancia
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
