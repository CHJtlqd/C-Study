using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    class Program
    {
        delegate int NewType(int Num);

        static int OnePlus(int Num)
        {
            return Num + 1;
        }

        static int TenPlus(int Num)
        {
            return Num + 10;
        }
        static void Main(string[] args)
        {
            NewType aNewType = new NewType(OnePlus);
            //Console.WriteLine(aNewType(1));

            //aNewType = new NewType(TenPlus);
            aNewType += TenPlus;
            Console.WriteLine(aNewType(1000));
        }
    }
}
