using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            double Num3;

            //Num1 = 100;
            //Num1 = int.Parse("100");


            //string TempString;
            //TempString = Console.ReadLine();
            //Num1 = int.Parse(TempString);


            //Console.WriteLine(Num1);
            //Console.WriteLine(Num2);
            while (true)
            {
                try
                {
                    Console.Write("첫번째 양수를 입력 : ");
                    Num1 = int.Parse(Console.ReadLine());
                    if (Num1 > 0)
                    {
                        Exception aException = new Exception();
                        throw aException;
                    }
                    Console.Write("두번째로 입력할 숫자 : ");
                    Num2 = int.Parse(Console.ReadLine());
                    Num3 = Num1 / Num2;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("*************");
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine("*************");
                    Console.WriteLine("문자를 입력함");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("음수를 입력했네 짜슥아");
                    continue;
                }
                finally
                {
                    Console.WriteLine("이건 예외가 있던 없던 무조건 거쳐 감");
                }
                break;
            }
        }
    }
}