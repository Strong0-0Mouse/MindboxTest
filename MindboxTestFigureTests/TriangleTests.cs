using System;
using MindboxTestFigure.Interfaces;
using MindboxTestFigure.Logic;
using Xunit;
using Xunit.Abstractions;

namespace MindboxTestFigureTests;

public class TriangleTests
{
    private IFigure? _figure;
    private readonly ITestOutputHelper _helper;
    
    private const int Precision = 2;
    
    public TriangleTests(ITestOutputHelper helper)
    {
        _helper = helper;
    }
    
    [Theory]
    [InlineData(3, 6, 5, 7.48)]
    public void CalculateTest(double sideA, double sideB, double sideC, double expectedResult)
    {
        _figure = new Triangle(sideA, sideB, sideC);
        var area = _figure.CalculateSquareFigure();
        Assert.Equal(expectedResult, area, Precision);
        _helper.WriteLine($"Sides: [{sideA}, {sideB}, {sideC}] >> Excepted: {expectedResult} | Actual: {area}");
    }
    
    [Theory]
    [InlineData(1, 2, 3, false)]
    [InlineData(3, 4, 5, true)]
    public void IsRightTest(double sideA, double sideB, double sideC, bool expectedResult)
    {
        _figure = new Triangle(sideA, sideB, sideC);
        var isRight = (_figure as Triangle)!.IsRightTriangle();
        Assert.Equal(expectedResult, isRight);
        _helper.WriteLine($"Sides: [{sideA}, {sideB}, {sideC}] >> Excepted: {expectedResult} | Actual: {isRight}");
    }
    
    [Theory]
    [InlineData(1, 1, 3)]
    [InlineData(-1, 2, 3)]
    public void ExceptionTest(double sideA, double sideB, double sideC)
    {
        var exception = Assert.Throws<ArgumentException>(() => _figure = new Triangle(sideA, sideB, sideC));
        _helper.WriteLine($"Sides: [{sideA}, {sideB}, {sideC}] | exception message: {exception.Message}");
    }
}