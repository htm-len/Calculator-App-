using System;
using MidtermCalculator.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Functions
{
    class OpDivide : IOperation
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Division;

        }
    }
}