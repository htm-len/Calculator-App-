using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System.Reflection;

namespace CalculatorProject.Tests
{
    

    [TestClass()]
    public class CalculatorTests
    {
        
        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest() //Addition Test
        {
            //arrange
            double _a = 1;
            double _b =2;
            double _c;
            
            //act
            _c = Addition.Sum(_a, _b);

            //Assert
            Assert.AreEqual(_c, 3);
        }

        public void SubTest() //Subtraction Test
        {
            //arrange
            double _a = 4;
            double _b = 2;
            double _c;

            //operation
            _c = Subtract.Subtraction(_a,_b)

           //Assert
           Assert.AreEqual(_c,2);
        }

        public void MultiTest() Multiplication Test //Multiplication Test
        {
            //arrange
            double _a = 4;
            double _b = 2;
            double _c;

            //operation
            _c = Multiply.Mulkltiplication(_a,_b)

           //Assert
           Assert.AreEqual(_c,8);
        }

         public void DivideTest() //Division Test
        {
            //arrange
            double _a = 9;
            double _b = 3;
            double _c;

            //operation
            _c = Divide.Division(_a,_b)

           //Assert
           Assert.AreEqual(_c,3);
        }


        [TestMethod()]
        public void CalculatorIntantiationWithParametersTest()
        {
            double _a = 1;
            double _b = 2;
            Func<double, double, double> _operations = Operations.Multiplication;

            Calculator _calculator = new Calculator(_a, _b, _operations);
            double _result = _calculator.Calculations[0].GetResult();
            Assert.AreEqual(2, _result);
        }
        [TestMethod()]
        public void CreateCalculationTest()
        {
            double _a = 2;
            double _b = 2;
            Func<double, double, double> _operations = Operations.Division;
            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_a, _b, _operations);
            _operations = Operations.Division;
            _calculator.CreateCalculation(_a, _b, _operations);

            
            Assert.AreEqual(2, _calculator.Calculations[0].GetResult());
            Assert.AreEqual(.5, _calculator.Calculations[1].GetResult());

       
        }
        [TestMethod()] //Methods for testing Operations
        public void SumListTest() //Addition test
        {
            //list of numbers
            List<double> _values = new List<double> { 1, 2, 3, 4, 5, 6 };

            Func<List<double>, double> _operations = ListOperations.SumList;

            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_values, _operations);
            Assert.AreEqual(21, _calculator.Calculations[0].GetResult());
        }


            public void SubtractionList() //Subtraction test
        {
            //list of numbers
            List<double> _values = new List<double> { 1, 2, 3, 4, 5, 6 };

            Func<List<double>, double> _operations = ListOperations.SubtractionList;

            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_values, _operations);
            Assert.AreEqual(2, _calculator.Calculations[0].GetResult());
        
        }

            public void MultiplicatoinList() //Multiplication test
        {
            //list of numbers
            List<double> _values = new List<double> { 1, 2, 3, 4, 5, 6 };

            Func<List<double>, double> _operations = ListOperations.MultiList;

            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_values, _operations);
            Assert.AreEqual(6, _calculator.Calculations[0].GetResult());
        
        }

            public void DivideList() //Divis test
        {
            //list of numbers
            List<double> _values = new List<double> { 1, 2, 3, 4, 5, 6 };

            Func<List<double>, double> _operations = ListOperations.DivisionList;

            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_values, _operations);
            Assert.AreEqual(6, _calculator.Calculations[0].GetResult());
        
        }

}