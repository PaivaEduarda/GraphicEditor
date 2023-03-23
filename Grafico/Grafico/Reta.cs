namespace Grafico
{
    class Reta : Ponto
    {
        private int x1, x2, y1, y2;
        private Color cor;
        private Ponto pontoFinal;
        public Reta(int x1, int x2, int y1, int y2, Color novaCor) : base(x1, y1, novaCor)
        {
            pontoFinal = new Ponto(x2, y2, novaCor);
        }

        public int X1
        {
            get => x1;
            set => x1 = value;
        }
        public int X2
        {
            get => x2;
            set => x2 = value;
        }
        public int Y1
        {
            get => y1;
            set => y1 = value;
        }
        public int Y2
        {
            get => y2;
            set => y2 = value;
        }
        public Color Cor1 
        {
            get => cor; 
            set => cor = value; 
        }
        internal Ponto PontoFinal 
        {
            get => pontoFinal;
            set => pontoFinal = value;
        }
        public override void desenhar(Color cor, Graphics g)
        {
            Pen pen = new Pen(cor);
            g.DrawLine(pen, base.X, base.Y, pontoFinal.X, pontoFinal.Y);    
        }
    }
}
