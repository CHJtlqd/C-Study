using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param6_1
{
    class Program
    {
        public static void VarMethod(params object[] arr) {
            Console.WriteLine("[가변 인자 개수]       : " + arr.Length);

            Console.Write("[인자 전체]  : ");
            foreach (object one in arr) {
                Console.Write(one + " ");
            }
            Console.WriteLine();

            Console.Write("[문자열 타입] : ");
            for (int i = 0; i < arr.Length; i++) {
                Type t = arr[i].GetType();
                if (t.Equals(typeof(System.String)))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[정수 타입] : ");
            foreach (object one in arr) {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Int32)))
                {
                    Console.Write(one + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[실수 타입] : ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Single)) || t.Equals(typeof(System.Double)))
                {
                    Console.Write(one + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            VarMethod(1000, 2000, "3000", "헬로", 3.1, 3.2f);
        }
    }
}
