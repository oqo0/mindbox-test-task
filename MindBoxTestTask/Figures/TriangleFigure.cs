namespace MindBoxTestTask.Figures;

public class TriangleFigure : IFigure
{
    public TriangleFigure(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new ArgumentException("Triangle sides can't be negative");
        }

        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
        
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    public double GetArea()
    {
        // Используем Формулу Герона
        var s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }

    public bool IsRectangular()
    {
        double[] sides = { Side1, Side2, Side3 };
        Array.Sort(sides);

        // Пытаемся вычислить площать при помощи основания и высоты
        double area = 0.5 * sides[0] * sides[1];
        
        double actualArea = GetArea();
        const double tolerance = 1e-6; // погрешность

        // Сравним результат с правильной площадью (прямоугольный если соответствует)
        return Math.Abs(area - actualArea) < tolerance;
    }
}