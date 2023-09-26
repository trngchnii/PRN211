using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Calculator<T>
    {
        public T Add(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        public T Subtract(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }

        public T Multiply(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a * b;
        }

        public T Divide(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Addition: " + intCalculator.Add(5, 4));
            Console.WriteLine("Subtraction: " + intCalculator.Subtract(5, 4));
            Console.WriteLine("Multiplication: " + intCalculator.Multiply(5, 4));
            Console.WriteLine("Division: " + intCalculator.Divide(5, 4));

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("Addition: " + doubleCalculator.Add(5.5, 3.2));
            Console.WriteLine("Subtraction: " + doubleCalculator.Subtract(5.5, 3.2));
            Console.WriteLine("Multiplication: " + doubleCalculator.Multiply(5.5, 3.2));
            Console.WriteLine("Division: " + doubleCalculator.Divide(5.5, 3.2));
        }
    }

}
