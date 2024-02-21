using FluentAssertions;
using MindBoxTestTask.Figures;

namespace MindBotTestTask.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(10, Math.PI * 100)]
    [InlineData(2, 12.56637)]
    public void CircleFigure_GetArea_ShouldReturnCorrectArea(double radius, double expectedArea)
    {
        var circleFigure = new CircleFigure(radius);
        var circleArea = circleFigure.GetArea();
        
        Assert.True(Math.Abs(circleArea - expectedArea) < 1e-6);
    }
}