using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Grafico
{
    class Elipse : Ponto
    {
        int raioX, raioY;

        public int RaioX 
        { 
            get => raioX; 
            set => raioX = value; 
        }

        public int RaioY 
        { 
            get => raioY; 
            set => raioY = value; 
        }

        public Elipse(int novoRaioX, int novoRaioY, int xCentro, int yCentro, Color novaCor) : base(xCentro, yCentro, novaCor)
        {
            RaioX = novoRaioX;
            RaioY = novoRaioY;
        }

        public void SetRaioX(int novoRaio)
        {
            raioX = novoRaio;
        }

        public void SetRaioY(int novoRaio)
        {
            raioY = novoRaio;
        }

        public override void Desenhar(Color corDesenho, Graphics g)
        {
            Pen pen = new Pen(corDesenho);
            g.DrawEllipse(pen, base.X - raioX, base.Y - raioY, 2 * raioX, 2 * raioY);
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
            return transformaString("e", 5) +
            transformaString(base.X, 5) +
            transformaString(base.Y, 5) +
            transformaString(Cor.R, 5) +
            transformaString(Cor.G, 5) +
            transformaString(Cor.B, 5) +
            transformaString(raioX, 5) +
            transformaString(raioY, 5);

        }
    }
}
