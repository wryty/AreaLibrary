using AreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double Side1 { get; }
        private double Side2 { get; }
        private double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            if (!IsTriangleValid())
                throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        public double CalculateArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        private bool IsTriangleValid()
        {
            return Side1 + Side2 > Side3 && Side1 + Side3 > Side2 && Side2 + Side3 > Side1;
        }
    }
}
