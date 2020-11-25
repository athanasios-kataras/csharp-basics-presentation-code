using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Fundamental_Priniciples
{
    abstract class Shape
    {
        public abstract int Area { get; set; }
        public abstract int GetArea();
    }

    class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        public override int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // GetArea is required to avoid a compile-time error.
        public override int GetArea() => side * side;
    }
    // Output: Area of the square = 144

    class SquareExt : Square
    {
        public SquareExt(int n) : base(n)
        {
        }

        public override int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetArea()
        {
            return base.GetArea();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


    interface IPoint
    {
        // Property signatures:
        int X { get; set; }

        int Y { get; set; }

        double GetDistance();
    }

    class Point : IPoint
    {
        // Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }

        public int Y { get; set; }

        // Property implementation
        public double GetDistance() { return Math.Sqrt(X * X + Y * Y); }
    }
}