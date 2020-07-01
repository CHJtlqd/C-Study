using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param1
{
    class Program
    {
        public void Increase(int n) {
            n++;
        }
        static void Main(string[] args)
        {
            int i = 10;
            Program pv = new Program();
            Console.WriteLine("호출 전 : {0}", i);
            pv.Increase(i);
            Console.WriteLine("호출 후 : {0}", i);
        }
    }
}
