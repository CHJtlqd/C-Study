using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param3
{
    class Program
    {
        public void Increase(ref int n)
        {
            n++;
        }
        static void Main(string[] args)
        {
            int i = 10;
            Program pr = new Program();
            Console.WriteLine("호출 전 : {0}", i);
            pr.Increase(ref i);
            Console.WriteLine("호출 후 : {0}", i);
        }
    }
}
