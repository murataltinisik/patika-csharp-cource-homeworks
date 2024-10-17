namespace OOP
{
    class BaseGeometric
    {
        // Class Properties and getters, setters
        public int Width { get; private set; }
        public int Height { get; private set; }

        public BaseGeometric(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual int CalculateArea()
        {
            return Width * Height;
        }
    }

    class Square : BaseGeometric
    {
        public Square(int border) : base(border, border) { }
    }

    class Rectangle : BaseGeometric
    {
        public Rectangle(int width, int height) : base(width, height) { }
    }

    class Triangle : BaseGeometric
    {
        public Triangle(int width, int height) : base(width, height) { }

        public override int CalculateArea()
        {
            return (Width * Height) / 2;
        }
    }
}