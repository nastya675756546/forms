using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Class1
    {
        public static double S(double x,double y,double z)
        {
            double p = 1.00 / 2.00 * ((x + y) * z);
            return p;
        }
        public int index = 0;
        public Point[] points;
        public  Class1(int size)
        {
            if (size <= 0)
            {
                size = 2;
            }
             points = new Point[size];
        }
        public void SetPoint(int x, int y)
        {
            if (index>=points.Length)
            {
                index = 0;
            }
            points[index] = new Point(x, y);
            index++;
        }
        public void Reset()
        {
            index = 0;
        }
        public int GetCount()
        {
            return index;
        }
        public Point[] Get()
        {
            return points;
        }
    }
}
