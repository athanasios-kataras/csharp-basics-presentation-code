namespace Microsoft.Workshop.Net.OOPFundamentals.SOLID_Principles.Liskov_Substitution
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int height;
        private int width;
        public override int Height
        {
            get { return height; }
            set
            {
                height = value;
                width = value;
            }
        }
        // Same thing as Height
        public override int Width
        {
            get { return width; }
            set
            {
                height = value;
                width = value;
            }
        }
    }

    /// <summary>
    /// In this example the GetArea(Rectangle) is our Φ(x)
    /// </summary>
    public class AreaCalculator
    {
        public int GetArea(Rectangle rec)
        {
            return rec.Height * rec.Width;
        }

        public void DoWork() {
            Rectangle rec = new Rectangle() {
                Height = 5,
                Width = 4
            };

            Rectangle sq = new Square() {
                Width = 5,
                Height = 4
            };

            if (GetArea(rec) != GetArea(sq)) {
                throw new System.Exception("Unexpected results");
            }
        }
    }
}