using System;
using CalculatorApp.Interfaces;

namespace CalculatorApp.CalculatorFunctions
{
    class OpSquare : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Square;
        }
    }
}