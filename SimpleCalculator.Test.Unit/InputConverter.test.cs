using System;
using CalculatorApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputCOnverter = new InputConverter();
        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputCOnverter.ConvertInputToNumber(inputNumber);
            Assert.AreEqual(5,convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConverInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputCOnverter.ConvertInputToNumber(inputNumber);
   
        }
    }
}
