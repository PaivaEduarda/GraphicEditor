using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Grafico
{
    class Polilinha : Ponto 
    {
        private ListaSimples<Ponto> listaPontos;

        public Polilinha(int cX, int cY, Color qualCor) : base(cX, cY, qualCor)
        {
            listaPontos = new ListaSimples<Ponto>();
            Ponto p = new Ponto(cX, cY, qualCor);
            p.FazParteDePolilinha = true;
            listaPontos.InserirAposFim(p);
        }

        internal ListaSimples<Ponto> ListaPontos { get => listaPontos; set => listaPontos = value; }

        public override void Desenhar(Color cor, Graphics g)
        {
            if (listaPontos != null)
            {
                listaPontos.Atual = listaPontos.Primeiro;
                while (listaPontos.Atual != null)
                {
                    if (listaPontos.Atual.Prox != null)
                    {
                        Ponto pontoInicial = listaPontos.Atual.Info;
                        Ponto pontoFinal = listaPontos.Atual.Prox.Info;

                        Pen pen = new Pen(cor);
                        g.DrawLine(pen, pontoInicial.X, pontoInicial.Y, pontoFinal.X, pontoFinal.Y);
                    }

                    listaPontos.Atual = listaPontos.Atual.Prox;
                }
            }
        }
    }
}
