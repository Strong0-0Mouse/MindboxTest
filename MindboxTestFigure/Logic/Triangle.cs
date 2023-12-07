using System;
using System.Linq;
using MindboxTestFigure.Interfaces;

namespace MindboxTestFigure.Logic;

public class Triangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    /// <summary>
    /// Triangle
    /// </summary>
    /// <param name="sideA">Strictly positive</param>
    /// <param name="sideB">Strictly positive</param>
    /// <param name="sideC">Strictly positive</param>
    /// <exception cref="ArgumentException">Get invalid sides</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Invalid sides");
        
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        
        if (_sideA + _sideB < _sideC || _sideA + _sideC < _sideB || _sideB + _sideC < _sideA)
            throw new ArgumentException("Triangle doesn't exist");
    }
    
    /// <summary>
    /// Calculate square triangle using Heron's formula
    /// </summary>
    /// <returns>Area triangle</returns>
    public double CalculateSquareFigure()
    {
        var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
    }
    
    /// <summary>
    /// Check is triangle right
    /// </summary>
    /// <returns>Is triangle right</returns>
    public bool IsRightTriangle()
    {
        const double tolerance = 0.01;
        var sides = new[] { _sideA, _sideB, _sideC }.OrderBy(s => s).ToArray();
        var hypotenuse = sides.Last();
        var legs = sides.SkipLast(1);
        return Math.Abs(legs.Sum(l => l * l) - hypotenuse * hypotenuse) < tolerance;
    }
}