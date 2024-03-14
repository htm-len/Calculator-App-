using System;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Functionss
{
    class OpMultiply : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Multiplication;
        }
    }
}