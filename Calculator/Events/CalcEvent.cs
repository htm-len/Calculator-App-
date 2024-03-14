using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Models;

namespace MidtermCalculator.Events
{
    public class CalculationEvent
    {
        public event EventHandler<CalculationEventArgs> completedCalculation;

        public void GetCalculation(ICalculate calculation)
        {
            OnCalculation(calculation);
        }

        protected virtual void OnCalculation(ICalculate calculation)
        {

            if (completedCalculation != null)
                completedCalculation(this, new CalculationEventArgs() { Calculation = calculation });
        }
    }
}