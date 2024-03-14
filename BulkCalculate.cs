using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    class BulkCalculation
    {
      
        public List<double> ListOfValues { get; set; }

        //bulk operation storage
        public Func<List<double>, double> BulkOperation { get; set; }
        public BulkCalculation(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

         
            BulkOperation = calculation;
        }

        public BulkCalculation() { }

        public BulkCalculation(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            CreateCalculation(listOfValues, _operation);

        }
        public double GetResult() 
        {
            return BulkOperation(ListOfValues);
        }
    }
    
     
}
