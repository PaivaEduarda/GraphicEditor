using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                var arquivo = new StreamReader(dlgAbrir.FileName);
                string linha = "";
                while (!arquivo.EndOfStream)
                {
                    linha = arquivo.ReadLine();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
