using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsExample
{
    class Program
    {
        static int Add(params int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}
