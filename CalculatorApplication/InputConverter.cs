using System;

namespace CalculatorApplication
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {


            double convertedNumber;
            if(!double.TryParse(argTextInput,out convertedNumber)) throw new ArgumentException("Expected a numaric value");
            return convertedNumber;
        }
    }
}