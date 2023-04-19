namespace ModelBuilder
{
    public partial class Form1 : Form
    {
        private string imageFilepath;
        private FractalDimension fdc;
        public Form1()
        {
            InitializeComponent();
            _width = FractalPictureBox.Width;
            _height = FractalPictureBox.Height;
            fdc = new FractalDimension();

            imageFilepath = string.Empty;

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


                Fractal(point1, point2, point3, (int)numericUpDown3.Value);
                Fractal(point2, point3, point1, (int)numericUpDown3.Value);
                Fractal(point3, point1, point2, (int)numericUpDown3.Value);
                KochpictureBox.BackgroundImage = _fractal;
            }
            if(comboBox2.SelectedIndex == 1)
            {
                _fractal = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height);
                _graph = Graphics.FromImage(_fractal);
                pen = new Pen(Color.Black);
                Draw(150, 350, 300, 0, (int)numericUpDown3.Value, 0);
                KochpictureBox.BackgroundImage = _fractal;
            }
        }

       

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            zoom -= zoomSpeed / zoom;
            Draw_Mandelbrot();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Draw_Mandelbrot();
            timer1.Stop();

        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                res -= 1;
            }
            if (e.KeyCode == Keys.E)
            {
                res += 1;
            }
            if (e.KeyCode == Keys.W)
            {
                wy -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.S)
            {
                wy += speed * (5 - Math.Abs(zoom));
            }

            if (e.KeyCode == Keys.A)
            {
                wx -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.D)
            {
                wx += speed * (5 - Math.Abs(zoom));
            }


            if (e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                Draw_Mandelbrot();
            }
            if (e.KeyCode == Keys.Z)
            {
                timer1.Start();
                Draw_Mandelbrot();
            }
            
        }

        private void LoadImagebotton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                     
                    imageFilepath = openFileDialog.FileName;
                    ImageBox.BackgroundImage = Image.FromFile(imageFilepath);

                    //CellSizeInput.Enabled = true;
                    //CellSizeInput.Maximum = Math.Min(ImageBox.BackgroundImage.Width, ImageBox.BackgroundImage.Height) / 16;
                     
                }
            }
        }

        private void LSMbutton_Click(object sender, EventArgs e)
        {
            fdc.BlackBoundary = (int)LSMnumericUpDown.Value;
            textBoxAnswer.Text = fdc.CalculateCapacitiveDimension(imageFilepath).ToString();
        }

        private void LSMBoundary_Click(object sender, EventArgs e)
        {
            SetBlackBoundaryToImageBox();
        }
        private void SetBlackBoundaryToImageBox()
        {
            int blackBoundary = (int)LSMnumericUpDown.Value;
            Bitmap image = new Bitmap(Image.FromFile(imageFilepath));
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    if (pixel.R <= blackBoundary && pixel.G <= blackBoundary && pixel.B <= blackBoundary)
                    {
                        newImage.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                }
            }

            ImageBox.BackgroundImage = newImage;
        }
    }
}