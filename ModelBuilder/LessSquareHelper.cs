using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBuilder
{
      class LessSquareHelper
    {
        public static void GetCoefficient(IList<Tuple<double, double>> points, out double k, out double b)
        {
            double n = points.Count;
            double Sx = 0;   
            double Sy = 0;   
            double Sxx = 0;  
            double Sxy = 0;  

            foreach (Tuple<double, double> point in points)
            {
                Sx += point.Item1;
                Sy += point.Item2;
                Sxx += point.Item1 * point.Item1;
                Sxy += point.Item1 * point.Item2;
            }

            k = (n * Sxy - Sy * Sx) / (n * Sxx - Sx * Sx);
            b = (Sxy * Sx - Sy * Sxx) / (Sx * Sx - n * Sxx);
        }
    }
}
