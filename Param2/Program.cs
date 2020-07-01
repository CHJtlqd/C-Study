using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param2
{
    public class ParamRef {
        public int myVal = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}", pr.myVal);
            Program.Increase(pr);
            Console.WriteLine("호출 후 : {0}", pr.myVal);

        }

        public static void Increase(ParamRef varRef) {
            varRef.myVal++;
        }




    }
}
