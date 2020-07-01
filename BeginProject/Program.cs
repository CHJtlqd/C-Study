//프롤로그 시작
using System;

namespace BeginProject
// 프롤로그 끝
{
    enum Week
    {
        Mon = 100,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    struct Book
    {
        public string name;
        public int price;

        static Book()
        {
            Console.WriteLine("static ");
        }

        public void test()
        {
            Console.WriteLine("북 메서드");
        }
    }
    class Program
    {
        static void Main(string[] args)     // Entry Point, Program 객체를 생성하는 부분이 없기에 static으로 정적으로 선언하여 실행할 수 있게한다
        {
            //string inValue = Console.ReadLine();
            //Console.WriteLine(inValue);

            //int iNumber = 0x12345678;
            //float fNumber = 41.625f;

            Week GoodDay;
            Week ToDay;
            GoodDay = Week.Fri;
            ToDay = Week.Thu;

            //Console.WriteLine($"GoodDay = {GoodDay}");
            //Console.WriteLine($"ToDay = {ToDay}");

            //Console.WriteLine("Index = {0}", (int)Week.Mon);
            //Console.WriteLine("Index = {0}", (int)Week.Tue);
            //Console.WriteLine("Index = {0}", (int)Week.Wed);
            //Console.WriteLine("Index = {0}", (int)Week.Thu);
            //Console.WriteLine("Index = {0}", (int)Week.Fri);
            //Console.WriteLine("Index = {0}", (int)Week.Sat);
            //Console.WriteLine("Index = {0}", (int)Week.Sun);

            Book aBook;
            aBook.name = "test";
            aBook.price = 1000;
            aBook.test();

            Book aBook2 = new Book();
            aBook2.name = "test2";
            aBook2.test();
        }
    }
}
