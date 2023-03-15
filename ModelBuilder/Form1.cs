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
        public Pen pen;
        static Pen pen1;
        static Pen pen2;
        static Graphics g;
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                _fractal = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height); 
                _graph = Graphics.FromImage(_fractal);  
                _graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
                pen = new Pen(Color.Black);    

                
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

        private void KochpictureBox_Click(object sender, EventArgs e)
        {
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                _fractal = new Bitmap(KochpictureBox.Height, KochpictureBox.Width);

                g = Graphics.FromImage(_fractal);
                pen1 = new Pen(Color.Green, 1);
                pen2 = new Pen(Color.Blue, 1);
                            
                PointF point1 = new PointF(200, 200);
                PointF point2 = new PointF(500, 200);
                PointF point3 = new PointF(350, 400);



                g.DrawLine(pen1, point1, point2);
                g.DrawLine(pen1, point2, point3);
                g.DrawLine(pen1, point3, point1);


                Fractal(point1, point2, point3, 10);
                Fractal(point2, point3, point1, 10);
                Fractal(point3, point1, point2, 10);
                KochpictureBox.BackgroundImage = _fractal;
            }
            if(comboBox2.SelectedIndex == 1)
            {
                _fractal = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height);
                _graph = Graphics.FromImage(_fractal);
                pen = new Pen(Color.Black);
                Draw(150, 350, 300, 0, 3, 0);
                KochpictureBox.BackgroundImage = _fractal;
            }
        }
    }
}