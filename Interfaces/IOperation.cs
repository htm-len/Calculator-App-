using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatoApp.Interfaces
{
    public interface IOperation
    {
        public Func<double, double, double> getOperation();

    }
}