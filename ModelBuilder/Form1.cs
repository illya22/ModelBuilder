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
        
    }
}