namespace ScreenSound.Interfaces;

internal interface IForma
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle : IForma
{
    public double Ray { get; set; }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Ray; 
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Ray, 2);
    }
}

public class Rectangle : IForma
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }

    public double CalculateArea()
    {
        return Length * Width;
    }
}