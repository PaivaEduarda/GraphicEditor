using System;
using System.Drawing;

namespace Grafico 
{
    class Ponto : ICon
    {
        private int x, y;
        private Color cor;
        private ListaSimples<Ponto> figuras = new ListaSimples<Ponto>();
        public Ponto(int cX, int cY, Color qualCor)
        {
            x = cX;
            y = cY;
            cor = qualCor;
        }

        public int X 
        {
            get => x; 
            set => x = value; 
        }
        public int Y 
        {
            get => y;
            set => y = value; 
        }
        public Color Cor
        {
            get => cor;
            set => cor = value;
        }
        public virtual void Desenhar(Color cor, Graphics g)
        {
            Pen pen = new Pen(cor);
            g.DrawLine(pen, x, y, x, y);
        }
    }
}
