namespace CSHARP_02.Models
{
    // Gemaakt door Rick
    public interface IShape
    {
        double Area { get; }
        double CalculatePerimeter();
        void Resize(double factor);
    }

    public class Rectangle : IShape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculatePerimeter() => 2 * (Width + Height);
        public void Resize(double factor)
        {
            Width *= factor;
            Height *= factor;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; private set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculatePerimeter() => 2 * Math.PI * Radius;
        public void Resize(double factor) => Radius *= factor;
    }

}
