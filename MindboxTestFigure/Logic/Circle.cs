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
        return Math.PI * _radius * _radius;
    }
}