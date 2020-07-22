using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceType
{
    class Coordinate
    {
        public int x;
        public int y;
    }


    class Program
    {
        static Coordinate test()
        {
            Coordinate temp = new Coordinate();
            return temp;
        }
        static void Main(string[] args)
        {
            Coordinate c = test();

            c.x = 1;
            c.y = 2;

            Console.WriteLine("c ={0}, {1}", c.x, c.y);

            c = null;

            try
            {
                c.x = 1;

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("c는 Null");
            }
        }
    }
}
