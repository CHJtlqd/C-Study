using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Program
    {
        static void ArrayCopy<T>(T[] Dst, T[] Src)
        {
            for (int Temp = 0; Temp < Dst.Length; Temp++)
            {
                Dst[Temp] = Src[Temp];
            }
        }
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
            int[] ArrayInt1 = { 2, 4, 6, 8 };
            int[] ArrayInt2 = new int[4];

            ArrayPrint(ArrayInt1);
            ArrayPrint(ArrayInt2);

            double[] ArrayDouble1 = { 2.1, 4.1, 6.1, 8.1 };
            double[] ArrayDouble2 = new double[4];
            //ArrayInt2 = (int[])ArrayInt1.Clone();
            ArrayCopy<int>(ArrayInt2, ArrayInt1);
            ArrayCopy<double>(ArrayDouble2, ArrayDouble1);
            ArrayPrint(ArrayInt2);
        }
    }
}
