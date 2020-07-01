using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClear2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ClearArray = { 5, 4, 2, 6, 7, 1 };
            Array.Clear(ClearArray, 1, 2);

            foreach (int iNum in ClearArray)
            {
                Console.WriteLine(iNum);
            }
        }
    }
}
