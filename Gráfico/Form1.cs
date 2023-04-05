using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gráfico
{
    public partial class frmGeometrico : Form
    {
        public frmGeometrico()
        {
            InitializeComponent();
        }

        private ListaSimples<Ponto> figuras = new ListaSimples<Ponto>();
        
        bool esperaPonto = false;
        bool esperaInicioReta = false;
        bool esperaFimReta = false;
        bool esperaInicioDoRetangulo = false;
        bool esperaFimDoRetangulo = false;
        bool esperaInicioDoCirculo = false;
        bool esperaFimDoCirculo = false;
        bool esperaInicioDaElipse = false;
        bool esperaFimDaElipse = false;

        Color corAtual = Color.Black;
        private static Ponto p1 = new Ponto(0, 0, Color.Black); 

        private void limparEsperas()
        {
            esperaPonto = false;
            esperaInicioReta = false;
            esperaFimReta = false;
            esperaFimDoRetangulo = false;
            esperaInicioDoRetangulo = false;
            esperaInicioDoCirculo = false;
            esperaFimDoCirculo = false;
            esperaInicioDaElipse = false;
            esperaFimDaElipse = false;
        }
        private void pbAreaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            figuras.IniciarPercursoSequencial();

            while (figuras.PodePercorrer())
            {
                Ponto figuraAtual = figuras.Atual.Info;
                figuraAtual.Desenhar(figuraAtual.Cor, g);
            }
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            dlgCor.ShowDialog();
            corAtual = dlgCor.Color;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader arqFiguras = new StreamReader(dlgAbrir.FileName);
                    String linha;
                    //Double xInfEsq = Convert.ToDouble(linha.Substring(0, 5).Trim());
                    //Double yInfEsq = Convert.ToDouble(linha.Substring(5, 5).Trim());
                    //Double xSupDir = Convert.ToDouble(linha.Substring(10, 5).Trim());
                    //Double ySupDir = Convert.ToDouble(linha.Substring(15, 5).Trim());
                    while ((linha = arqFiguras.ReadLine()) != null)
                    {
                        String tipo = linha.Substring(0, 5).Trim();
                        int xBase = Convert.ToInt32(linha.Substring(5, 5).Trim());
                        int yBase = Convert.ToInt32(linha.Substring(10, 5).Trim());
                        int corR = Convert.ToInt32(linha.Substring(15, 5).Trim());
                        int corG = Convert.ToInt32(linha.Substring(20, 5).Trim());
                        int corB = Convert.ToInt32(linha.Substring(25, 5).Trim());
                        Color cor = new Color();
                        cor = Color.FromArgb(255, corR, corG, corB);
                        switch (tipo[0])
                        {

                            case 'p': // figura é um ponto
                                figuras.InserirAposFim(
                                new NoLista<Ponto>(new Ponto(xBase, yBase, cor), null));
                                break;
                            case 'l': // figura é uma reta
                                int xFinal = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int yFinal = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Reta(xBase, xFinal, yBase, yFinal, cor), null));
                                break;
                            case 'c': // figura é um círculo
                                int raio = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Circulo(raio, xBase, yBase, cor), null));
                                break;
                            case 'e': //figura é uma elipse
                                int raioX = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int raioY = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Elipse(raioX, raioY, xBase, yBase, cor), null));
                                break;
                            case 'r': //figura é um retângulo
                                int finalX = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int finalY = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Retangulo(xBase, finalX, yBase, finalY, cor), null));
                                break;
                        }
                    }

                    arqFiguras.Close();
                    this.Text = dlgAbrir.FileName;
                    pbAreaDesenho.Invalidate();

                }
                catch (IOException)
                {
                    Console.WriteLine("Erro de leitura no arquivo");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbAreaDesenho_MouseMove(object sender, MouseEventArgs e)
        {
            stMensagem.Items[3].Text = e.X + "," + e.Y;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "clique no local do ponto desejado:";
            limparEsperas();
            esperaPonto = true;
        }

        private void pbAreaDesenho_MouseClick(object sender, MouseEventArgs e)
        {
            if (esperaPonto)
            {
                Ponto pontoInicial = new Ponto(e.X, e.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(pontoInicial, null));
                pontoInicial.Desenhar(pontoInicial.Cor, pbAreaDesenho.CreateGraphics());
                esperaPonto = false;
                stMensagem.Items[1].Text = " ";
            }
            else
            if (esperaInicioReta)
            {
                p1.setCor(corAtual);
                p1.setX(e.X);
                p1.setY(e.Y);
                esperaInicioReta = false;
                esperaFimReta = true;
                stMensagem.Items[1].Text = "Clique o ponto final da reta";
            }
            else
            if (esperaFimReta)
            {
                esperaFimReta = false;
                Reta novaLinha = new Reta(p1.X, e.X, p1.Y, e.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novaLinha, null));
                novaLinha.Desenhar(novaLinha.Cor, pbAreaDesenho.CreateGraphics());
                esperaInicioReta = true;
            }
            else
            if (esperaInicioDoRetangulo)
            {
                p1.Cor = corAtual;
                p1.X = e.X;
                p1.Y = e.Y;
                esperaInicioDoRetangulo = false;
                esperaFimDoRetangulo = true;
                stMensagem.Items[1].Text = "Clique o ponto final do retangulo";
            }
            else
            if (esperaFimDoRetangulo)
            {
                esperaFimDoRetangulo = false;
                Retangulo novoRet = new Retangulo(p1.X, p1.Y, e.X, e.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novoRet, null));
                novoRet.Desenhar(novoRet.Cor, pbAreaDesenho.CreateGraphics());
                esperaInicioDoRetangulo = true;
            }
            else
            if (esperaInicioDoCirculo)
            {
                p1.setCor(corAtual);
                p1.setX(e.X);
                p1.setY(e.Y);
                esperaInicioDoCirculo = false;
                esperaFimDoCirculo = true;
                stMensagem.Items[1].Text = "Clique o ponto final do circulo";
            }
            else
            if (esperaFimDoCirculo)
            {
                esperaFimDoCirculo = false;
                Circulo novoCir;
                if (p1.X - e.X > 0)
                    novoCir = new Circulo(p1.X - e.X, p1.X, p1.Y, corAtual);
                else
                    novoCir = new Circulo(e.X - p1.X, p1.X, p1.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novoCir, null));
                novoCir.Desenhar(novoCir.Cor, pbAreaDesenho.CreateGraphics());
                esperaInicioDoCirculo = true;
            }
            else
            if (esperaInicioDaElipse)
            {
                p1.setCor(corAtual);
                p1.setX(e.X);
                p1.setY(e.Y);
                esperaInicioDaElipse = false;
                esperaFimDaElipse = true;
                stMensagem.Items[1].Text = "Clique o ponto final da elipse";
            }
            else
            if (esperaFimDaElipse)
            {
                esperaFimDaElipse = false;
                int raioX, raioY;
                if (p1.X - e.X > 0)
                    raioX = p1.X - e.X;
                else
                    raioX = e.X - p1.X;
                if (p1.Y - e.Y > 0)
                    raioY = p1.Y - e.Y;
                else
                    raioY = e.Y - p1.Y;
                Elipse novoEli = new Elipse(raioX, raioY, p1.X, p1.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novoEli, null));
                novoEli.Desenhar(novoEli.Cor, pbAreaDesenho.CreateGraphics());
                esperaInicioDaElipse = true;
            }
        }

        private void btnReta_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto inicial da reta:";
            limparEsperas();
            esperaInicioReta = true;
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto inicial do retangulo";
            limparEsperas();
            esperaInicioDoRetangulo = true;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto inicial do circulo";
            limparEsperas();
            esperaInicioDoCirculo = true;
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto inicial do circulo";
            limparEsperas();
            esperaInicioDaElipse = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter salvar = new StreamWriter(dlgSalvar.FileName);
                figuras.IniciarPercursoSequencial();
                while(figuras.PodePercorrer())
                {
                    salvar.Flush();
                    salvar.WriteLine(figuras.Atual.Info.ToString());
                }
                salvar.Close();
            }
        }
    }
}
