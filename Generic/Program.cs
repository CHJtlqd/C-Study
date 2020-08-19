using System;

namespace ConsoleApp2
{
    class Program
    {
        static void ArrayPrint<T>(T[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] Numbers1 = { 1, 3, 5, 7, 9 };
            double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };
            string[] Numbers3 = { "일", "이" };

            ArrayPrint<int>(Numbers1);
            ArrayPrint(Numbers2);
            ArrayPrint(Numbers3);
        }
    }
}
