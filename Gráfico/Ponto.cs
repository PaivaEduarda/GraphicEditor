using System;
using System.Drawing;

namespace Grafico 
{
    class Ponto : IComparable<Ponto>
    {

        private int x, y;
        private Color cor;
        
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

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y; 
        }

        public void setCor(Color cor)
        {
            this.cor = cor;
        }
        public virtual void Desenhar(Color cor, Graphics g)
        {
            Pen pen = new Pen(cor);
            g.DrawLine(pen, x, y, x+1, y);
        }
        public int CompareTo (Ponto other)
        {
            int diferencaX = X - other.X;
            if(diferencaX == 0)
                return Y - other.Y;
            return diferencaX;
        }

        public String transformaString(int valor, int quantasPosicoes)
        {
            String cadeia = valor + "";
            while (cadeia.Length < quantasPosicoes)
                cadeia = "0" + cadeia;
            return cadeia.Substring(0, quantasPosicoes); // corta, se necessário, para
                                                         // tamanho máximo
        }
        public String transformaString(String valor, int quantasPosicoes)
        {
            String cadeia = valor + "";
            while (cadeia.Length < quantasPosicoes)
                cadeia = cadeia + " ";
            return cadeia.Substring(0, quantasPosicoes); // corta, se necessário, para
                                                         // tamanho máximo
        }
        public override String ToString()
        {
            return transformaString("p", 5) +
            transformaString(X, 5) +
            transformaString(Y, 5) +
            transformaString(Cor.R, 5) +
            transformaString(Cor.G, 5) +
            transformaString(Cor.B, 5);

        }
    }
}
