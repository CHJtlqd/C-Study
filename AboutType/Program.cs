using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutType
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 3.14;

            Console.WriteLine("radius의 형:{0}", radius.GetType());
            Console.WriteLine("radius의 값:{0}", radius.ToString());

            string name = "이효리";

            Console.WriteLine("name 형:{0}", name.GetType());
            Console.WriteLine("name 값:{0}", name.ToString());
            Console.WriteLine();

            Console.WriteLine("radius == name : {0}", name.Equals(radius));

        }
    }
}
