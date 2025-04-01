using System;
using System.Drawing;

namespace DibujarRectangulosFactory

public abstract class Figura
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }

    protected Figura(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public abstract void Dibujar(Graphics g);
}