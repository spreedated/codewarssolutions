using Solutions.Attributes;
using System;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("58dced7b702b805b200000be", PRIMARY_AUTHOR)]
    public static class GeoBasicDistanceBetween2dPoints
    {
        public static double DistanceBetweenPoints(MyPoint a, MyPoint b)
        {
            return Math.Round(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)), 6);
        }
    }

    public sealed class MyPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public MyPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
