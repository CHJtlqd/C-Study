using System;

namespace OOP
{
    class Car
    {
        // 속성(attribute) : variable
        int speed;
        public int Speed
        {
            set { speed = value; }
            get { return speed; }
        }
        const int SpeedValue = 10;


        // 행위(behavior) : method
        public void Run()
        {
            Console.WriteLine("달립니다.");
        }

        public void Accel()
        {
            Speed += SpeedValue;
            if (Speed > 200)
            {
                Speed = 200;
            }
            Console.WriteLine("현재 속도는 {0}입니다.", Speed);
        }

        public void Break()
        {
            Speed -= SpeedValue;
            if (Speed < 0)
            {
                Speed = 0;
            }
            Console.WriteLine("현재 속도는 {0}입니다.", Speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new Car();
            while (true)
            {
                aCar.Accel();
            }
        }
        static void Main1(string[] args)
        {
            Car aCar;
            aCar = new Car();
            aCar.Run();
            aCar.Speed = 0;
            Console.WriteLine("aCar의 속도는 {0}입니다.", aCar.Speed);
        }
    }
}
