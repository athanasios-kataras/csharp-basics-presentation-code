using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Open_Closed.Bertrand_Meyer
{

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }

    public class Square {
        public double side;
    }

    public class AllShapesAreaCalculator: AreaCalculator
    {
        public new double Area(object[] shapes)
        {
            double area = base.Area(shapes);
            foreach (var shape in shapes)
            {
                if (shape is Square)
                {
                    Square square = (Square)shape;
                    area += Math.Pow(square.side, 2);
                }
            }
            return area;
        }
    }

}