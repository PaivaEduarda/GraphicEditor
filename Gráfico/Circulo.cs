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
            return transformaString("c", 5) +
            transformaString(base.X, 5) +
            transformaString(base.Y, 5) +
            transformaString(Cor.R, 5) +
            transformaString(Cor.G, 5) +
            transformaString(Cor.B, 5) +
            transformaString(raio, 5);
        }

    }
}
