using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownUpCasting
{
    class Vehicle
    {

    }

    class Car : Vehicle
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle aVehicle = new Car();
            Car aCar = new Car();

            aCar = aVehicle as Car;

            if (aCar == null)
            {  
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(aCar); 
            }
        }
        static void Main3(string[] args)
        {
            Vehicle[] array = new Vehicle[] {
                                                new Vehicle(),
                                                new Car(),
                                                new Vehicle()
                                            };

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i].ToString());
        }
        static void Main2(string[] args)
        {
            Vehicle aVehicle = new Vehicle();
            Car aCar = new Car();
            try
            {

                aCar = (Car)aVehicle;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("잘못된 캐스팅입니다.");
            }
        }
        static void Main1(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            Vehicle a = car;        // 형변환 : 묵시적 암시적 자동
            Car b = (Car)a;         // 형변환 : 명시적 강제적 수동
        }
    }
}
