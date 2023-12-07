using System;
using MindboxTestFigure.Interfaces;

namespace MindboxTestFigure.Logic;

public class Circle : IFigure
{
    private readonly double _radius;
    
    /// <summary>
    /// Circle
    /// </summary>
    /// <param name="radius">Strictly positive</param>
    /// <exception cref="ArgumentException">Get negative radius</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius is not positive");
        _radius = radius;
    }
    
    /// <summary>
    /// Calculate square circle
    /// </summary>
    /// <returns>Area circle</returns>
    public double CalculateSquareFigure()
    {
        return Math.PI * _radius * _radius;
    }
}