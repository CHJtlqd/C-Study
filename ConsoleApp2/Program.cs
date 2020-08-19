using System;

namespace ConsoleApp2
{
    class Program
    {
        static void ArrayIntPrint(int[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.WriteLine();
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void ArrayDoublePrint(double[] Num)
        {
            for (int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine(Num[i]);
            }
            Console.WriteLine();
            foreach (double num in Num)
            {
                Console.WriteLine(num);
            }
        }

        static void ArrayStringPrint(string[] Num)
        {
            for (int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine(Num[i]);
            }
            Console.WriteLine();
            foreach (string num in Num)
            {
                Console.WriteLine(num);
            }
        }

      

        static void Main(string[] args)
        {
            int[] Numbers1 = { 1, 3, 5, 7, 9 };

            ArrayIntPrint(Numbers1);

            double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };
            ArrayDoublePrint(Numbers2);

            string[] Numbers3 = { "일", "이" };
            ArrayStringPrint(Numbers3);

        }
    }
}
