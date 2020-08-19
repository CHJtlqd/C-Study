using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadFunc1);
            Thread t2 = new Thread(threadFunc2);
            Thread t3 = new Thread(threadFunc3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("메인 스레드 종료");
            // 더는 주 스레드가 실행할 명령어가 없으므로 주 스레드는 제거됨
        }

        static void threadFunc1()
        {
            Console.WriteLine("3초 후에 프로그램 종료1");
            Thread.Sleep(3000);
            //현재 주 스레드는 종료됐어도 t 스레드는 존속한다.
            Console.WriteLine("1스레드 종료!");
        }

        static void threadFunc2()
        {
            Console.WriteLine("1초 후에 프로그램 종료2");
            Thread.Sleep(1000);
            //현재 주 스레드는 종료됐어도 t 스레드는 존속한다.
            Console.WriteLine("2스레드 종료!");
        }

        static void threadFunc3()
        {
            Console.WriteLine("2초 후에 프로그램 종료3");
            Thread.Sleep(2000);
            //현재 주 스레드는 종료됐어도 t 스레드는 존속한다.
            Console.WriteLine("3스레드 종료!");
        }
    }
}
