using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject : Operations
    public class Calculator
    {

        public List<Calculation> Calculations = new List<Calculation>();


      
        public Calculator() { }
        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            CreateCalculation(listOfValues, _operation); 

        }
        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            CreateCalculation(a, b, _operation);

        }
        public void CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            
            var _calculation = new Calculation(a, b, _operation);

            Calculations.Add(_calculation);

        }
        
        //factory method
        public static Create(List<double> listOfValues, Func<List<double>, double> _operation)
        {
             CreateCalculation(listOfValues, _operation); 

            return CreateCalculation;

        }
}
