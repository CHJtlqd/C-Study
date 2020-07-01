using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Program
    {
        public static ulong Factorial(ulong number)
        {
            if (number <= 1) return 1;
            else
                return number * Factorial(number - 1);
        }
        static void MethodTest()
        {
            Console.WriteLine("여기는 MethodTest 입니다.");
        }
        public static int classvari1 = 0;

        public int classvari2 = 0;
        public Program()
        {

            classvari1++;
            classvari2++;
        }

        public void Print()
        {
            Console.WriteLine("classvari1 : " + classvari1);
            Console.WriteLine("classvari2 : " + classvari2);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("여기는 Main 메소드입니다.");
            MethodTest();
            Console.WriteLine("MethodTest 메소드를 호출하였습니다.");
            ulong nfact = Factorial(5);
            Console.WriteLine("5*4*3*2*1 = " + nfact);

            Program e1;
            Program e2;
            e1 = new Program();
            e1.Print();

            e2 = new Program();
            e2.Print();

            e1.Print();
        }
    }





}
