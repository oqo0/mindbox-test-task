namespace MindBoxTestTask.Figures;

public class CircleFigure : IFigure
{
    public CircleFigure(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius can't be less than 0");
        }
        
        Radius = radius;
    }

    public double Radius { get; }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}