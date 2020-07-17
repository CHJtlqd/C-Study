using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface test
    {        // interface 추상메서드만 보유 가능
        void tt();
    }

    class Auto : test
    {
        public void tt()
        {
        }
    }

    interface IMusician
    {
        void Singing();
    }

    interface IActor
    {
        void Playing();
    }

    class PianoPlayer : IMusician
    {
        public void Singing()
        {
            throw new NotImplementedException();
        }
    }

    class ViolinPlayer : IMusician
    {
        public void Singing()
        {
            throw new NotImplementedException();
        }
    }

    class Musical : IMusician, IActor
    {
        public void Playing()
        {
            Console.WriteLine("연기하다");

        }

        public void Singing()
        {
            Console.WriteLine("노래하다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Musical aMusical = new Musical();
            aMusical.Playing();
            aMusical.Singing();
        }
    }
}
