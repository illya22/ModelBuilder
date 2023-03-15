using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBuilder
{
    public partial class Form1:Form
    {
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


                _graph.DrawLine(pen, (float)x, (float)y, (float)xnew, (float)ynew);

                x = xnew;
                y = ynew;
                double angle1 = (int)numericUpDown1.Value;
                DrawTree(x, y, a, angle + angle1);
                DrawTree(x, y, a, angle - angle1);
            }
            return 0;
        }

        static int Fractal(PointF p_1, PointF p_2, PointF p_3, int iter)
        {
            
            if (iter > 0)   
            {
                
                var p4 = new PointF((p_2.X + 2 * p_1.X) / 3, (p_2.Y + 2 * p_1.Y) / 3);
                var p5 = new PointF((2 * p_2.X + p_1.X) / 3, (p_1.Y + 2 * p_2.Y) / 3);
            
                var ps = new PointF((p_2.X + p_1.X) / 2, (p_2.Y + p_1.Y) / 2);
                var pn = new PointF((4 * ps.X - p_3.X) / 3, (4 * ps.Y - p_3.Y) / 3);
             
                g.DrawLine(pen1, p4, pn);
                g.DrawLine(pen1, p5, pn);
                g.DrawLine(pen2, p4, p5);


              
                Fractal(p4, pn, p5, iter - 1);
                Fractal(pn, p5, p4, iter - 1);
                Fractal(p_1, p4, new PointF((2 * p_1.X + p_3.X) / 3, (2 * p_1.Y + p_3.Y) / 3), iter - 1);
                Fractal(p5, p_2, new PointF((2 * p_2.X + p_3.X) / 3, (2 * p_2.Y + p_3.Y) / 3), iter - 1);

            }
            return iter;
        }

        void Draw(double x, double y, double l, double u, int t, int q)
        {
        
            if (t > 0)
            {
                if (q == 1)
                {
                     
                    x += l * Math.Cos(u);
                    y -= l * Math.Sin(u);
                    u += Math.PI;
                }
                u -= 2 * Math.PI / 19; 
                l /= Math.Sqrt((int)numericUpDown2.Value);  
                 
                Paint(ref x, ref y, l, u, t - 1, 0);
                Paint(ref x, ref y, l, u + Math.PI / 3, t - 1, 1);
                Paint(ref x, ref y, l, u + Math.PI, t - 1, 1);
                Paint(ref x, ref y, l, u + 2 * Math.PI / 3, t - 1, 0);
                Paint(ref x, ref y, l, u, t - 1, 0);
                Paint(ref x, ref y, l, u, t - 1, 0);
                Paint(ref x, ref y, l, u - Math.PI / 3, t - 1, 1);
            }
            else _graph.DrawLine(pen, (float)Math.Round(x), (float)Math.Round(y), (float)Math.Round(x + Math.Cos(u) * l), (float)Math.Round(y - Math.Sin(u) * l));
        }

        void Paint(ref double x, ref double y, double l, double u, int t, int q)
        {
            Draw(x, y, l, u, t, q);
            x += l * Math.Cos(u);
            y -= l * Math.Sin(u);
        }
    }
}
