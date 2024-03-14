using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CalculatorProject.CalculatorFunctions
{
    public class ListOperations
    {
        //linq
        public static Func<List<double>, double> SumList = (a) => a.Sum();
        public static Func<List<double>, double> SubtractionList = (a) => a.Subtraction();
        public static Func<List<double>, double> MultiList = (a) => a.Multiplication();
        public static Func<List<double>, double> DivisoinList = (a) => a.Subtraction();
        public static Func<List<double>, double> UnsigneList = (a) => a.Unassigned();
    }
}
