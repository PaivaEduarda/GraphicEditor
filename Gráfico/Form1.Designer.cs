namespace Gráfico
{
    partial class frmGeometrico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPonto = new System.Windows.Forms.ToolStripButton();
            this.btnReta = new System.Windows.Forms.ToolStripButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripButton();
            this.btnElipse = new System.Windows.Forms.ToolStripButton();
            this.btnRetangulo = new System.Windows.Forms.ToolStripButton();
            this.btnPolilinha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.stMensagem = new System.Windows.Forms.StatusStrip();
            this.tl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbAreaDesenho = new System.Windows.Forms.PictureBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.dlgCor = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.stMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.btnSalvar,
            this.toolStripSeparator2,
            this.btnPonto,
            this.btnReta,
            this.btnCirculo,
            this.btnElipse,
            this.btnRetangulo,
            this.btnPolilinha,
            this.toolStripSeparator1,
            this.btnCor,
            this.toolStripSeparator3,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(706, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = global::Gráfico.Properties.Resources.folder_open_solid_24;
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = global::Gráfico.Properties.Resources.save_solid_24;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPonto
            // 
            this.btnPonto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPonto.Image = global::Gráfico.Properties.Resources.target_lock_regular_24;
            this.btnPonto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(23, 22);
            this.btnPonto.Text = "Ponto";
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnReta
            // 
            this.btnReta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReta.Image = global::Gráfico.Properties.Resources.highlight_regular_24;
            this.btnReta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReta.Name = "btnReta";
            this.btnReta.Size = new System.Drawing.Size(23, 22);
            this.btnReta.Text = "Reta";
            this.btnReta.Click += new System.EventHandler(this.btnReta_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCirculo.Image = global::Gráfico.Properties.Resources.circle_regular_24;
            this.btnCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(23, 22);
            this.btnCirculo.Text = "Círculo";
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnElipse.Image = global::Gráfico.Properties.Resources.elipse;
            this.btnElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(23, 22);
            this.btnElipse.Text = "Elipse";
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRetangulo.Image = global::Gráfico.Properties.Resources.rectangle_regular_24;
            this.btnRetangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(23, 22);
            this.btnRetangulo.Text = "Retângulo";
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // btnPolilinha
            // 
            this.btnPolilinha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPolilinha.Image = global::Gráfico.Properties.Resources.line_chart_regular_24__1_;
            this.btnPolilinha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPolilinha.Name = "btnPolilinha";
            this.btnPolilinha.Size = new System.Drawing.Size(23, 22);
            this.btnPolilinha.Text = "Polilinhas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCor
            // 
            this.btnCor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCor.Image = global::Gráfico.Properties.Resources.palette_regular_24;
            this.btnCor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(23, 22);
            this.btnCor.Text = "Cores";
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = global::Gráfico.Properties.Resources.exit_regular_24;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // stMensagem
            // 
            this.stMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tl1,
            this.tlMensagem,
            this.tl2,
            this.tlCoordenadas});
            this.stMensagem.Location = new System.Drawing.Point(0, 353);
            this.stMensagem.Name = "stMensagem";
            this.stMensagem.Size = new System.Drawing.Size(706, 22);
            this.stMensagem.TabIndex = 1;
            this.stMensagem.Text = "statusStrip1";
            // 
            // tl1
            // 
            this.tl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl1.Name = "tl1";
            this.tl1.Size = new System.Drawing.Size(71, 17);
            this.tl1.Text = "Mensagem:";
            // 
            // tlMensagem
            // 
            this.tlMensagem.Name = "tlMensagem";
            this.tlMensagem.Size = new System.Drawing.Size(91, 17);
            this.tlMensagem.Text = "sem mensagem";
            // 
            // tl2
            // 
            this.tl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl2.Name = "tl2";
            this.tl2.Size = new System.Drawing.Size(81, 17);
            this.tl2.Text = "Coordenadas:";
            // 
            // tlCoordenadas
            // 
            this.tlCoordenadas.Name = "tlCoordenadas";
            this.tlCoordenadas.Size = new System.Drawing.Size(25, 17);
            this.tlCoordenadas.Text = "x, y";
            // 
            // pbAreaDesenho
            // 
            this.pbAreaDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAreaDesenho.Location = new System.Drawing.Point(0, 38);
            this.pbAreaDesenho.Name = "pbAreaDesenho";
            this.pbAreaDesenho.Size = new System.Drawing.Size(706, 312);
            this.pbAreaDesenho.TabIndex = 2;
            this.pbAreaDesenho.TabStop = false;
            this.pbAreaDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAreaDesenho_Paint);
            this.pbAreaDesenho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAreaDesenho_MouseClick);
            this.pbAreaDesenho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAreaDesenho_MouseMove);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "C:\\Users\\u22125\\Documents\\";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.Filter = "Text Files | *.txt";
            // 
            // frmGeometrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.Controls.Add(this.pbAreaDesenho);
            this.Controls.Add(this.stMensagem);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGeometrico";
            this.Text = "Desenho Geométrico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stMensagem.ResumeLayout(false);
            this.stMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnPonto;
        private System.Windows.Forms.ToolStripButton btnReta;
        private System.Windows.Forms.ToolStripButton btnCirculo;
        private System.Windows.Forms.ToolStripButton btnElipse;
        private System.Windows.Forms.ToolStripButton btnRetangulo;
        private System.Windows.Forms.ToolStripButton btnPolilinha;
        private System.Windows.Forms.ToolStripButton btnCor;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip stMensagem;
        private System.Windows.Forms.PictureBox pbAreaDesenho;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ColorDialog dlgCor;
        private System.Windows.Forms.ToolStripStatusLabel tl1;
        private System.Windows.Forms.ToolStripStatusLabel tlMensagem;
        private System.Windows.Forms.ToolStripStatusLabel tl2;
        private System.Windows.Forms.ToolStripStatusLabel tlCoordenadas;
    }
}

