using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnType
{
    class Program
    {
        static int[] Test()
        {
            int[] Array = new int[5];

            return Array;
        }

        static void Test(int[] var) {

            Console.WriteLine(var.Length);
        }

        static void Main(string[] args)
        {
            int[] Ret = Test();
            Console.WriteLine(Ret.Length);

            int[] Array = new int[5];
            Test(Array);
        }
    }
}
