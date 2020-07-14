using System;

namespace MethodOverloading
{
    class Program
    {
        static int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        static double Add(double Num1, double Num2)
        {
            return Num1 + Num2;
        }

        static float Add(float Num1, float Num2)
        {
            return Num1 + Num2;
        }

        static void Main(string[] args)
        {
            int iNum = Add(3, 4);
            double dNum = Add(3.1, 11.2);
            float fNum = Add(3.1f, 2.2f);


        }
    }
}
