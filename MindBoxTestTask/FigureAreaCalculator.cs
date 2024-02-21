namespace MindBoxTestTask;

public class FigureAreaCalculator
{
    // Вычисление площади фигуры без знания типа фигуры в compile-time
    public double GetArea(IFigure figure)
    {
        return figure.GetArea();
    }
}