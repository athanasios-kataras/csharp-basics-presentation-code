using System;

namespace Microsoft.Workshop.Net.OOPFundamentals.OOP___Clean_Code.Class_Design
{
    public class Point
    {
        public int x;
        public int y;
    }
    public class Proximity
    {
        private Point a;
        private Point b;
        public Proximity(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }
        public int GetProximity()
        {
            this.ValidatePoints();

            int distance = this.CalculateDistance();

            return this.CreateProximityResult();
        }

        private void ValidatePoints()
        {
            this.ValidateNonZeroPoints();
            this.ValidateNonSamePoints();
            this.ValidateSomeOtherThing();
        }
        private void ValidateNonZeroPoints()
        {
            throw new NotImplementedException();
        }
        private void ValidateNonSamePoints()
        {
            throw new NotImplementedException();
        }
        private void ValidateSomeOtherThing()
        {
            throw new NotImplementedException();
        }
        private int CalculateDistance()
        {
            throw new NotImplementedException();
        }
        private int CreateProximityResult()
        {
            throw new NotImplementedException();
        }

    }
}