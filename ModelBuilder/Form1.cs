namespace ModelBuilder
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
            _width = FractalPictureBox.Width;
            _height = FractalPictureBox.Height;
        }
        public int Level; 
        private int _width;
        private int _height;
        private Bitmap _fractal;
        private Graphics _graph;
        public Pen p; 
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                _fractal = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height); 
                _graph = Graphics.FromImage(_fractal);  
                _graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
                p = new Pen(Color.Black);    

                
                DrawTree(FractalPictureBox.Width/2, FractalPictureBox.Height-100, 300, 180);

                FractalPictureBox.BackgroundImage = _fractal;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                _fractal = new Bitmap(_width, _height);
                _graph = Graphics.FromImage(_fractal);
                RectangleF carpet = new RectangleF(0, 0, _width, _height);
                DrawCarpet(Level= (int)numericUpDown1.Value, carpet);
              
                FractalPictureBox.BackgroundImage = _fractal;
            }
            if(comboBox1.SelectedIndex == 2)
            {
                 
                _fractal = new Bitmap(_width, _height);
               
                _graph = Graphics.FromImage(_fractal);
               
                PointF topPoint = new PointF(_width / 2f, 0);
                PointF leftPoint = new PointF(0, _height);
                PointF rightPoint = new PointF(_width, _height);
             
                DrawTriangle(Level=(int)numericUpDown1.Value, topPoint, leftPoint, rightPoint);
               
                FractalPictureBox.BackgroundImage = _fractal;
            }
        }
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }
        private void DrawCarpet(int level, RectangleF carpet)
        {
             
            if (level == 0)
            {
             _graph.FillRectangle(Brushes.OrangeRed, carpet);
            }
            else
            {
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;
                
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height));
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height));
            }
        }
        private void DrawTriangle(int level, PointF top, PointF left, PointF right)
        {
            
            if (level == 0)
            {
                PointF[] points = new PointF[3]
                {
                    top, right, left
                };
                
                _graph.FillPolygon(Brushes.BlueViolet, points);
            }
            else
            {
                
                var leftMid = MidPoint(top, left); 
                var rightMid = MidPoint(top, right); 
                var topMid = MidPoint(left, right); 
                
                DrawTriangle(level - 1, top, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, left, topMid);
                DrawTriangle(level - 1, rightMid, topMid, right);
            }
        }
        public int DrawTree(double x, double y, double a, double angle)
        {

            if (a > 2)
            {
                a *= 0.7; 

               
                double xnew = x + a * Math.Sin(angle * Math.PI * 2 / 360);
                double ynew = y + a * Math.Cos(angle * Math.PI * 2 / 360);

           
                _graph.DrawLine(p, (float)x, (float)y, (float)xnew, (float)ynew);

                x = xnew;
                y = ynew;
                double angle1 = (int)numericUpDown1.Value;
                DrawTree(x, y, a, angle + angle1);
                DrawTree(x, y, a, angle - angle1);
            }
            return 0;
        }
    }
}