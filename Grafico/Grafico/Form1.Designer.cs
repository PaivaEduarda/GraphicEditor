namespace Grafico
{
    partial class frmGrafico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnPonto = new System.Windows.Forms.ToolStripButton();
            this.btnReta = new System.Windows.Forms.ToolStripButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripButton();
            this.btnElipse = new System.Windows.Forms.ToolStripButton();
            this.btnRetangulo = new System.Windows.Forms.ToolStripButton();
            this.btnPolilinha = new System.Windows.Forms.ToolStripButton();
            this.btnCor = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stMensagem = new System.Windows.Forms.StatusStrip();
            this.pbAreaDesenho = new System.Windows.Forms.PictureBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.btnSalvar,
            this.toolStripSeparator1,
            this.btnPonto,
            this.btnReta,
            this.btnCirculo,
            this.btnElipse,
            this.btnRetangulo,
            this.btnPolilinha,
            this.toolStripSeparator2,
            this.btnCor,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnAbrir
            // 
            this.btnAbrir.AutoSize = false;
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnAbrir.Text = "toolStripButton1";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 32);
            this.btnSalvar.Text = "toolStripButton2";
            // 
            // btnPonto
            // 
            this.btnPonto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPonto.Image = ((System.Drawing.Image)(resources.GetObject("btnPonto.Image")));
            this.btnPonto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(23, 32);
            this.btnPonto.Text = "toolStripButton3";
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnReta
            // 
            this.btnReta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReta.Image = global::Grafico.Properties.Resources.highlight_regular_24;
            this.btnReta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReta.Name = "btnReta";
            this.btnReta.Size = new System.Drawing.Size(23, 32);
            this.btnReta.Text = "toolStripButton4";
            // 
            // btnCirculo
            // 
            this.btnCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCirculo.Image = global::Grafico.Properties.Resources.circle_regular_24;
            this.btnCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(23, 32);
            this.btnCirculo.Text = "toolStripButton5";
            // 
            // btnElipse
            // 
            this.btnElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnElipse.Image = global::Grafico.Properties.Resources.elipse;
            this.btnElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(23, 32);
            this.btnElipse.Text = "toolStripButton6";
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRetangulo.Image = global::Grafico.Properties.Resources.rectangle_regular_24;
            this.btnRetangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(23, 32);
            this.btnRetangulo.Text = "toolStripButton7";
            // 
            // btnPolilinha
            // 
            this.btnPolilinha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPolilinha.Image = ((System.Drawing.Image)(resources.GetObject("btnPolilinha.Image")));
            this.btnPolilinha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPolilinha.Name = "btnPolilinha";
            this.btnPolilinha.Size = new System.Drawing.Size(23, 32);
            this.btnPolilinha.Text = "toolStripButton8";
            // 
            // btnCor
            // 
            this.btnCor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCor.Image = global::Grafico.Properties.Resources.palette_regular_24;
            this.btnCor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(23, 32);
            this.btnCor.Text = "toolStripButton9";
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = global::Grafico.Properties.Resources.exit_regular_24;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 32);
            this.btnSair.Text = "toolStripButton10";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // stMensagem
            // 
            this.stMensagem.Location = new System.Drawing.Point(0, 428);
            this.stMensagem.Name = "stMensagem";
            this.stMensagem.Size = new System.Drawing.Size(800, 22);
            this.stMensagem.TabIndex = 1;
            this.stMensagem.Text = "statusStrip1";
            // 
            // pbAreaDesenho
            // 
            this.pbAreaDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAreaDesenho.Location = new System.Drawing.Point(0, 28);
            this.pbAreaDesenho.Name = "pbAreaDesenho";
            this.pbAreaDesenho.Size = new System.Drawing.Size(800, 397);
            this.pbAreaDesenho.TabIndex = 2;
            this.pbAreaDesenho.TabStop = false;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAreaDesenho);
            this.Controls.Add(this.stMensagem);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGrafico";
            this.Text = "Desenho Geométrico";
            this.Load += new System.EventHandler(this.frmGrafico_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnSalvar;
        private ToolStripButton btnPonto;
        private ToolStripButton btnReta;
        private ToolStripButton btnCirculo;
        private ToolStripButton btnElipse;
        private ToolStripButton btnRetangulo;
        private ToolStripButton btnPolilinha;
        private ToolStripButton btnCor;
        private ToolStripButton btnSair;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip stMensagem;
        private PictureBox pbAreaDesenho;
        private OpenFileDialog dlgAbrir;
        private SaveFileDialog dlgSalvar;
    }
}