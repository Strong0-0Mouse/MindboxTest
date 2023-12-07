using System;
using MindboxTestFigure.Interfaces;
using MindboxTestFigure.Logic;
using Xunit;
using Xunit.Abstractions;

namespace MindboxTestFigureTests;

public class CircleTests
{
    private IFigure? _figure;
    private readonly ITestOutputHelper _helper;
    
    private const int Precision = 2;
    
    public CircleTests(ITestOutputHelper helper)
    {
        _helper = helper;
    }
    
    [Theory]
    [InlineData(5.5, 95.03)]
    public void CalculateTest(double radius, double expectedResult)
    {
        _figure = new Circle(radius);
        var area = _figure.CalculateSquareFigure();
        Assert.Equal(expectedResult, area, Precision);
        _helper.WriteLine($"Radius = {radius} >> Excepted: {expectedResult} | Actual: {area}");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void ExceptionTest(double radius)
    {
        var exception = Assert.Throws<ArgumentException>(() => _figure = new Circle(radius));
        _helper.WriteLine($"Radius = {radius} | exception message: {exception.Message}");
    }
}