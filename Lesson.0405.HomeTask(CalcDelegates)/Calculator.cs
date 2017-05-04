using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._0405.HomeTask_CalcDelegates_
{
    class Calculator
    {
        //private delegate double OperationDelegate(double x, double y);
        private static Dictionary<char, Func<double, double, double>> operations =
                        new Dictionary<char, Func<double, double, double>>
                            {
                                { '+', (x, y) => x + y },
                                { '-', (x, y) => x - y },
                                { '*', (x, y) => x * y },
                                { '/', (x, y) => x / y },
                            };
        public static double PerformOperation(char operation, double x, double y)
        {
            if (!operations.ContainsKey(operation))
                throw new ArgumentException(string.Format($"Operation {operation} is invalid"), "op");
            return operations[operation](x, y);
        }
    }
}
