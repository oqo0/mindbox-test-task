namespace MindBoxTestTask.Figures;

public class CircleFigure(double radius) : IFigure
{
    public double Radius { get; } = radius;

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}