using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Generic4
{
    class FACT<T1, T2>
    {
        public T1 Value1;
        public T2 Value2;
        public void Print() {
            Console.WriteLine($"FACT Value1 = {this.Value1}, Value2 = {this.Value2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FACT<int,double> obj = new FACT<int,double>();
            obj.Value1 = 100;
            obj.Value2 = 1.1;
            obj.Print();

            FACT<string,int> obj1 = new FACT<string,int>();
            obj1.Value1 = "백";
            obj1.Value2 = 100;
            obj1.Print();
        }
    }
}
