using System;
using MindboxTestFigure.Interfaces;

namespace MindboxTestFigure.Logic;

public class Circle : IFigure
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        _radius = radius;
    }
    
    public double CalculateSquareFigure()
    {
        if (_radius < 0)
            throw new Exception("Radius is negative");
        return Math.PI * _radius * _radius;
    }
}