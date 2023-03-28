using System;
using System.Drawing;

namespace Grafico
{
    class Circulo : Ponto
    {
        int raio;

        public int Raio
        {
            get => raio;
            set => raio = value;
        }

        public Circulo(int novoRaio, int xCentro, int yCentro, Color novaCor) : base(xCentro, yCentro, novaCor)
        {
           raio = novoRaio;
        }

        public void SetRaio(int novoRaio)
        {
            raio = novoRaio;
        }

        public override void Desenhar(Color corDesenho, Graphics g)
        {
            Pen pen = new Pen(corDesenho);
            g.DrawEllipse(pen, base.X - raio, base.Y - raio, 2 * raio, 2 * raio);
        }

    }
}
