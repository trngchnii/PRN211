using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public delegate T MathOperation<T>(T a, T b);

    public class Calculator
    {
        public static T Add<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }

        public static T Subtract<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }

        public static T Multiply<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }

        public static T Divide<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 / num2;
        }
    }

    public class Program1
    {
        public static void Main()
        {
            // Declare delegates
            MathOperation<int> addDelegate = Calculator.Add;
            MathOperation<int> subtractDelegate = Calculator.Subtract;
            MathOperation<int> multiplyDelegate = Calculator.Multiply;
            MathOperation<int> divideDelegate = Calculator.Divide;

            // Perform calculations
            int a = 10, b = 5;
            int result;

            result = addDelegate(a, b);
            Console.WriteLine($"Addition: {result}");

            result = subtractDelegate(a, b);
            Console.WriteLine($"Subtraction: {result}");

            result = multiplyDelegate(a, b);
            Console.WriteLine($"Multiplication: {result}");

            result = divideDelegate(a, b);
            Console.WriteLine($"Division: {result}");
        }
    }
}
