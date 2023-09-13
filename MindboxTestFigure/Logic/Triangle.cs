using System;
using MindboxTestFigure.Interfaces;

namespace MindboxTestFigure.Logic;

public class Triangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    public double CalculateSquareFigure()
    {
        if (_sideA + _sideB < _sideC || _sideA + _sideC < _sideB || _sideB + _sideC < _sideA)
            throw new Exception("Triangle doesn't exist");

        var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
    }
}