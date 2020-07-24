using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        delegate int Calculator(int num1, int num2);
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;

        }

        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            int iResult;
            Calculator[] aCalculator = new Calculator[] { Add, Sub, Mul, Div };
            for (int i = 0; i < aCalculator.Length; i++)
            {
                Console.WriteLine(aCalculator[i](3, 4));
            }

            foreach (var item in aCalculator)
            {
                Console.WriteLine(item(3, 4));
            }

            iResult = Add(3, 4);
            Console.WriteLine(iResult);

            iResult = Div(3, 4);
            Console.WriteLine(iResult);

            iResult = Sub(3, 4);
            Console.WriteLine(iResult);

            iResult = Mul(3, 4);
            Console.WriteLine(iResult);
        }
    }
}
