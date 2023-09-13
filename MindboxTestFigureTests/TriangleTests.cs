using System;
using MindboxTestFigure.Interfaces;
using MindboxTestFigure.Logic;
using Xunit;

namespace MindboxTestFigureTests;

public class TriangleTests
{
    private IFigure? _figure;
    private const int Precision = 2;
    
    [Theory]
    [InlineData(1, 2, 3, 0, true)]
    [InlineData(2, 4, 5, 3.799, true)]
    [InlineData(1, 1, 3, 0, false)]
    public void CalculateTest(double sideA, double sideB, double sideC, double expectedResult, bool isRightTriangle)
    {
        _figure = new Triangle(sideA, sideB, sideC);

        if (!isRightTriangle)
        {
            Assert.Throws<Exception>(() => _figure.CalculateSquareFigure());
        }
        else
        {
            Assert.Equal(expectedResult, _figure.CalculateSquareFigure(), Precision);
        }
    }
}