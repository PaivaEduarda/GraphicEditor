using System;
using System.Drawing;

namespace Grafico
{
    class Retangulo : Ponto
    {
        private Ponto pontoFinal;
        public Retangulo(int x1,int y1, int x2, int y2, Color cor) : base (x1, y1, cor)
        {
            pontoFinal = new Ponto(x2, y2, cor);
        }

        public override void Desenhar(Color cor, Graphics g)
        {
            int x;
            int y;
            int largura = pontoFinal.X - base.X;
            int altura = pontoFinal.Y - base.Y;

            if (largura < 0)
            {
                largura *= -1;
                x = base.X- largura;
            }
            else
            {
                x = base.X;
            }

            if (altura < 0)
            {
                altura *= -1;
                y = base.Y - altura;
            }
            else
            {
                y = base.Y;
            }

            Pen pen = new Pen(cor);
            g.DrawRectangle(pen, x, y, largura, altura);
        }

        public String transformaString(int valor, int quantasPosicoes)
        {
            String cadeia = valor + "";
            while (cadeia.Length < quantasPosicoes)
                cadeia = " " + cadeia;
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
            return transformaString("r", 5) +
            transformaString(base.X, 5) +
            transformaString(base.Y, 5) +
            transformaString(Cor.R, 5) +
            transformaString(Cor.G, 5) +
            transformaString(Cor.B, 5) +
            transformaString(pontoFinal.X, 5) +
            transformaString(pontoFinal.Y, 5);

        }
    }
}
