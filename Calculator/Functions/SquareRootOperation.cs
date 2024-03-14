using System;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Functions
{
    class DivisionOperation.cs : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.SquareRoot;
        }
    }
}