using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBuilder
{
      class FractalDimension
    {
        
        public int BlackBoundary = 100;
        private Bitmap image;
        public List<Tuple<double, double>> CDPoints { get; private set; }
        public double CalculateCapacitiveDimension(string imagepath)
        {
            image = new Bitmap(imagepath);

            double result = CalculateCapacitiveDimension();

            image.Dispose();

            return result;
        }

        private double CalculateCapacitiveDimension()
        {
            double result = 0d;

            CDPoints = new List<Tuple<double, double>>();

            int epsilon = Math.Min(image.Width, image.Height) / 2;

            while (epsilon > 1)
            {
                CDPoints.Add(GetPoint(epsilon));
                epsilon /= 2;
            }

            result = GetAproximationByLessSquareMethod(CDPoints);

            return result;
        }

        private Tuple<double, double> GetPoint(int epsilon)
        {
            double NEpsilon = 0f;

            
            for (int x = 0; x <= image.Width; x += epsilon)
            {
                 
                if (image.Width - x < epsilon)
                    continue;

                int x1 = x + epsilon;

                for (int y = 0; y <= image.Height; y += epsilon)
                {
                     
                    if (image.Height - y < epsilon)
                        continue;

                    int y1 = y + epsilon;

                     
                    NEpsilon += IsFractalInCell(x, x1, y, y1) ? 1 : 0;
                }
            }

            return new Tuple<double, double>(Math.Log(1d / epsilon), Math.Log(NEpsilon));
        }

        
        private bool IsFractalInCell(int xStart, int xEnd, int yStart, int yEnd)
        {
            for (int x = xStart; x < xEnd; x++)
            {
                for (int y = yStart; y < yEnd; y++)
                {
                    if (IsBlackPixel(image.GetPixel(x, y)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsBlackPixel(Color pixel)
        {
            if (pixel.R <= BlackBoundary && pixel.G <= BlackBoundary && pixel.B <= BlackBoundary)
            {
                return true;
            }

            return false;
        }

        private double GetAproximationByLessSquareMethod(List<Tuple<double, double>> points)
        {
            LessSquareHelper.GetCoefficient(points, out double k, out double b);

            return k;
        }
    }
}
