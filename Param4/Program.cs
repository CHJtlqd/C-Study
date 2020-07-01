using System;

namespace Param4
{
    public class ParamRef
    {
        public int myVal = 10;
    }
    class Program
    {
        public static void Increase(ref ParamRef varRef)
        {
            varRef.myVal++;
        }
        static void Main(string[] args)
        {
            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}", pr.myVal);
            Program.Increase(ref pr);
            Console.WriteLine("호출 후 : {0}", pr.myVal);
        }
    }
}
