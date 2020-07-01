using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param5
{
    class Program
    {
        public void Increase(out int n) {
            n = 11;
        }
        static void Main(string[] args)
        {
            int i;
            Program pv = new Program();
            pv.Increase(out i);
            Console.WriteLine("호출후 값 : {0}", i);
        }
    }
}
