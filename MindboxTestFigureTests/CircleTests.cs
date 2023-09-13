using System;
using MindboxTestFigure.Interfaces;
using MindboxTestFigure.Logic;
using Xunit;

namespace MindboxTestFigureTests;

public class CircleTests
{
    private IFigure? _figure;
    private const int Precision = 2;
    
    [Theory]
    [InlineData(2, 12.57, true)]
    [InlineData(5.5, 95.03, true)]
    [InlineData(-1, 0, false)]
    public void CalculateTest(double radius, double expectedResult, bool isRightCircle)
    {
        _figure = new Circle(radius);

        if (!isRightCircle)
        {
            Assert.Throws<Exception>(() => _figure.CalculateSquareFigure());
        }
        else
        {
            Assert.Equal(expectedResult, _figure.CalculateSquareFigure(), Precision);
        }
    }
}