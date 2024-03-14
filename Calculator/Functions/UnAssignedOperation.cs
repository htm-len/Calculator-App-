using System;
using Calculator.Interfaces;

namespace CalculatorApp.Functions
{
    class UnAssignedOperations : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Unassigned;
        }

    }
}