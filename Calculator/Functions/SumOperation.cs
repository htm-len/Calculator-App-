using System;
using CalculatorApp.Events;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Functions
{
    public class SumOperations : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Sum;
        }
    }
}