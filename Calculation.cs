using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;

namespace CalculatorProject.Models
{
    public class Calculation : CalculatorFunctions

        public double A { get; set; }
     
        public double B { get; set; }
 
        public List<double> ListOfValues { get; set; }
 
        public Func<double, double, double> Operations { get; set; }
 
        public Func<List<double>, double> BulkOperation { get; set; }

 
        public Calculation(double a, double b, Func<double, double, double> calculation)
        {
            A = a;
            B = b;
       
            Operations = calculation;
        }
      
        public Calculation(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

       
            BulkOperation = calculation;
        }
    
        public Calculation() { }

      
        public double GetResult()
        {
            if (BulkOperation != null)
            {
                return BulkOperation(ListOfValues);
            }
            else
            {
                return Operations(A, B);
            }


        }
    }
}