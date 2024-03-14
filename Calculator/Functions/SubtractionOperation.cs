using System;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Functions
{
    class SubtractionOperation : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Subtraction;
        }
    }
}