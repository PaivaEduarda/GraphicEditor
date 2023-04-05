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
            return transformaString("l", 5) +
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
