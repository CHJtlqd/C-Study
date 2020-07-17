using System;
using System.Collections;

namespace Overriding
{
    class Parent
    {
        public virtual void Name()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child : Parent
    {
        public override void Name()
        {
            Console.WriteLine("Child");
        }
    }


    class Mammal
    {
        public virtual void Move()
        {
            Console.WriteLine("이동한다");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네발로 걷는다");
        }
    }
    class whale : Mammal
    {
        public void Move()
        {
            Console.WriteLine("수영한다");
        }
    }
    class Human : Mammal
    {
        public void Move()
        {
            Console.WriteLine("두발로 걷는다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mammal one = new Mammal();
            one.Move();

            one = new Lion();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            whale whale = new whale();
            whale.Move();

            Human human = new Human();
            human.Move();
        }
    }
}
