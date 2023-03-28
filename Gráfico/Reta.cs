using System;
using System.Drawing;

namespace Grafico
{
    class Reta : Ponto
    {
        private Ponto pontoFinal;
        public Reta(int x1, int x2, int y1, int y2, Color novaCor) : base(x1, y1, novaCor)
        {
            pontoFinal = new Ponto(x2, y2, novaCor);
        }

        internal Ponto PontoFinal 
        {
            get => pontoFinal;
            set => pontoFinal = value;
        }
        public override void Desenhar(Color cor, Graphics g)
        {
            Pen pen = new Pen(cor);
            g.DrawLine(pen, base.X, base.Y, pontoFinal.X, pontoFinal.Y);    
        }
    }
}
