using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /// <summary>
    /// Find an area - 6 kyu - O(n)
    /// You have an array or list of coordinates or points (e.g. [ [1, 1], [3, 4], ... , [5, 2] ]).
    /// Your task is to find the area under the graph defined by these points (limited by x of the first and last coordinates as left and right borders, y = 0 as the bottom border and the graph as top border).
    /// 
    /// x can be negative;
    /// x of the next pair of coordinates will always be greater than the previous one;
    /// y >= 0;
    /// 
    /// the array will contain more than 2 points.
    /// 
    /// Trapezoidal Rule
    /// Area = y¹ + y² / 2 * (x¹ - x²)
    /// 
    /// </summary>

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Y { get; set; }
        public double X { get; set; }

    }

    public class FindAnArea
    {
        public static double FindArea (List<Point> points)
        {
           
            if (points.Count < 2)
            {
                return 0;
            }

            double totalArea = 0; 

            for(int i = 0; i < points.Count - 1; i++) 
            {
                Point p1 = points[i];
                Point p2 = points[i + 1];

                double distance = p2.X - p1.X;

                double average = (p1.Y + p2.Y) / 2.0;

                totalArea += average * distance;

            }
            
            return totalArea;
        }
    }
}
