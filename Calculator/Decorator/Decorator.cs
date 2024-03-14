using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject;
using Calculator;

// Decorator Pattern
 public CalcDecorator
{
    class DecProgram
    {
        public static void 
    }

    // Base Interface 
    public interface ICalculator
    {
        private double SumList();

    }

    // concrete implementation
    class Calc : ICalculator
    {
        public double SumList();
        {
           return SumList;
        }
    }

// base decorator
class CalcDecorator : ICalculator
{
    private ICalculator _calculator;

    // constructor for decorator
    public CalcDecorator(ICalculator _calculator);
    {
         _calculator = calculator;
     }

        public double SumList();
        {
           return SumList;
        }
}
    