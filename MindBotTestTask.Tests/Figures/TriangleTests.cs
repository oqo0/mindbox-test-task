using MindBoxTestTask.Figures;

namespace MindBotTestTask.Tests.Figures;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(7, 8, 9, 26.83)]
    [InlineData(2, 3, 5, 0)]
    public void TriangleFigure_GetArea_ShouldReturnCorrectArea(
        double side1, double side2, double side3, double expectedArea)
    {
        var triangleFigure = new TriangleFigure(side1, side2, side3);
        var triangleArea = triangleFigure.GetArea();
        
        Assert.True(Math.Abs(triangleArea - expectedArea) < 1e-2);
    }
    
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(6, 8, 10, true)]
    [InlineData(2, 3, 5, false)]
    [InlineData(7, 8, 9, false)]
    public void TriangleFigure_IsRectangular_ShouldReturnCorrectResult(
        double side1, double side2, double side3, bool expectedResult)
    {
        var triangleFigure = new TriangleFigure(side1, side2, side3);
        var result = triangleFigure.IsRectangular();
        
        Assert.Equal(expectedResult, result);
    }
    
    [Fact]
    public void TriangleFigure_NegativeSide_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => new TriangleFigure(3, 4, -5));
    }
}