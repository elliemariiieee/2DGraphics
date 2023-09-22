namespace _2DGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 750;
            this.BackColor = ColorTranslator.FromHtml("#008F8C");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ColorTranslator.FromHtml("#023535"), 15.0F);
            Brush lightestTealBrush = new SolidBrush(ColorTranslator.FromHtml("#0FC2C0"));

            //draws hexagon in background
            g.DrawPolygon(pen, new Point[] { new Point(350, 100), new Point(200, 375), new Point(350, 650), new Point(650, 650), new Point(800,375), new Point(650, 100) });

            //draws ellipses for buttons

            //draws text in each button

            //draws pause button in upper right corner
            g.FillRectangle(lightestTealBrush, 910, 10, 10, 50);
            g.FillPolygon(lightestTealBrush, new Point[] { new Point(930, 10), new Point(955, 35), new Point(930, 60) });

            //draws player info in upper left corner
            pen.Width = 5.0F;
            pen.Color = ColorTranslator.FromHtml("#015958");
            g.DrawRectangle(pen, 10, 10, 100, 100);
            g.FillEllipse(lightestTealBrush, 35, 20, 50, 50);
            pen.Color = ColorTranslator.FromHtml("#0FC2C0");
            g.DrawArc(pen, 35, 70, 50, 50, 0, -205);
        }
    }
}