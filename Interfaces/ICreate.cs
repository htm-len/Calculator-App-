using System;
using System.Collections.Generic;
using System.Text;
using CalculatorApp.Models

namespace CalculatorApp.Interfaces
{

    interface ICreate

        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation);
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation);
    }

}