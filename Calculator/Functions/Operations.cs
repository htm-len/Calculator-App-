using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CalculatorProject.CalculatorFunctions
{
    public class ListOperations
    {
        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Subtraction = (a, b) => a - b;
        public static Func<double, double, double> Multiplication = (a, b) => a * b;
        public static Func<double, double, double> Division = (a, b) => a / b;
        public static Func<double, double, double> Square = (a, b) => Math.Pow(a, 2);
        public static Func<double, double, double> SquareRoot = (a, b) => Math.Sqrt(a);
        public static Func<double, double, double> Unassigned = (a, b) => 0;
    }
}
