using System;
using System.Drawing;

namespace Grafico
{
    class Retangulo : Ponto
    {
        private Ponto pontoFinal;
        public Retangulo(int x1,int x2, int y1, int y2, Color cor) : base (x1, y1, cor)
        {
            pontoFinal = new Ponto(x2, y2, cor);
        }

        public override void Desenhar(Color cor, Graphics g)
        {
            Pen pen = new Pen(cor);
           // g.DrawRectangle(pen, base.X, base.Y, )
        }
    }
}
