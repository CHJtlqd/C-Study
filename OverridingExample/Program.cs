using System;

namespace OverridingExample
{
    abstract class Musician
    {
        public virtual void Name()
        {
            Console.WriteLine("Musician");
        }

        public abstract void Instruments(); // 추상 메서드 , 추상클래스 내부 선언 필요
       
    }

    class ViolinPlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("ViolinPlayer");
        }


        public override void Instruments()
        {
            Console.WriteLine("Violin");
        }
    }

    class PianoPlayer : Musician
    {
        public override void Instruments()
        {
            Console.WriteLine("Piano");
        }

        public override void Name()
        {
            Console.WriteLine("PianoPlayer");
        }

       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Musician[] Array = new Musician[2];
            Array[0] = new ViolinPlayer();
            Array[1] = new PianoPlayer();

            foreach (var item in Array)
            {
                item.Name();
                item.Instruments();
                Console.WriteLine("****************");
            }
        }
    }
}
