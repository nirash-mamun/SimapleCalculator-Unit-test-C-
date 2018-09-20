using System;
using System.Globalization;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.Write("Input first Number: ");
                double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                Console.Write("Input Second Number: ");
                double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                Console.Write("What Type Operation You Need( '+' '-' '*' '/' : ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine("Result: " + result);

                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
