using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int point;
            string result;

            point = 100;

            if (point > 90)
            {
                result = "A";
            }
            else if (point > 80)
            {
                result = "B";
            }
            else if (point > 70)
            {
                result = "C";
            }
            else if (point > 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }

            switch (point / 10)
            {
                case 10:
                case 9:
                    result = "A";
                    break;
                case 8:
                    result = "B";
                    break;
                case 7:
                    result = "C";
                    break;
                case 6:
                    result = "D";
                    break;
                default:
                    result = "F";
                    break;
            }

            Console.WriteLine("당신의 점수는 {0}입니다.", point);
            Console.WriteLine("학점은 {0}입니다.", result);


            int num = 0;
            switch (num % 5)
            {

                case 1:
                    Console.WriteLine("나머지의 값은 1입니다.");
                    break;
                case 2:
                    Console.WriteLine("나머지의 값은 2입니다.");
                    break;
                case 3:
                    Console.WriteLine("나머지의 값은 3입니다.");
                    break;
                case 4:
                    Console.WriteLine("나머지의 값은 4입니다.");
                    break;
                default:
                    Console.WriteLine("5의 배수입니다.");
                    break;
            }
            //int i = 1;
            //for ( ; ; ) {
            //    if (i <= 10)
            //    {
            //        Console.WriteLine(i++);
            //    }
            //    else {
            //        break;
            //    }
            //}

            //for (int i = 0; i <= 9; i++) {
            //    if (i % 2 == 1)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 9; i++)
            //{
            //    if (i % 2 == 1)
            //        break ;
            //    Console.WriteLine(i);
            //}
            int a, b;
            float c = 0;

            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //try
            //{
            //    c = a / b;
            //}
            //catch (Exception eObj)
            //{
            //    Console.WriteLine("변수의 값이 올바르지 않습니다.");
            //    Console.WriteLine(eObj.Message);
            //    Environment.Exit(0);
            //}
            //finally
            //{

            //    Console.WriteLine("프로그램이 실행 되었습니다");
            //}
            //Console.WriteLine("A/B값은 {0}입니다.", c);

            while (true)
            {
                try
                {
                    Console.Write("변수1을 입력하세요 : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("변수2를 입력하세요 : ");
                    b = int.Parse(Console.ReadLine());
                    c = a / b;

                }
                catch (FormatException eObj)
                {
                    Console.WriteLine(eObj);
                    Console.WriteLine("숫자의 입력이 아닙니다.");
                    continue;
                }
                catch (Exception eObj)
                {
                    Console.WriteLine(eObj);
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                    continue;
                }
                finally
                {
                    Console.WriteLine("프로그램이 실행되었습니다.");
                }
                Console.WriteLine("A/B값은 {0}입니다.", c);
                break;
            }
        }
    }
}
