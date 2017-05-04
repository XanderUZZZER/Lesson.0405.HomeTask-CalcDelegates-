using System;

namespace Lesson._0405.HomeTask_CalcDelegates_
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;
            string[] temp;

            Console.WriteLine("Lesson 0305 HomeTask\n");
            Console.WriteLine("Input 2 numbers and operator to perform a calulation:\n");
            temp = Console.ReadLine().Split(' ');

            double.TryParse(temp[0], out num1);
            double.TryParse(temp[1], out num2);
            char.TryParse(temp[2], out op);

            result = Calculator.PerformOperation(op, num1, num2);
            Console.WriteLine($"Result is: {result}");

            Console.ReadLine();
        }
    }
}
