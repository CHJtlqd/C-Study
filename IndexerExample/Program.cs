using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Car
    {
        public string name;
    }
    class TestCar
    {
        private Car[] _array;

        public TestCar()
        {
            _array = new Car[5];
        }

        public TestCar(int size)
        {
            _array = new Car[size];
        }


        public Car this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TestCar aTestCar = new TestCar();

            aTestCar[0] = new Car();
            aTestCar[1] = new Car();
            aTestCar[0].name = "소세지";
            aTestCar[1].name = "고로케";

            Console.WriteLine(aTestCar[0].name);
            Console.WriteLine(aTestCar[1].name);
        }
    }
}
