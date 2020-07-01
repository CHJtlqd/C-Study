using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param5
{
    class Program
    {
        public void Increase(out int n)
        {   // out 출력용 ref
            //Console.WriteLine(n);   // 오류 : 최초 n의 입력값을 바로 읽지 않고 참조 즉, read는 하지 않겠다.
            n = 11;
            // Console.WriteLine(n); // 정상작동 값이 변경되어 정상작동가능
        }
        static void Main(string[] args)
        {
            int i = 6;
            Program pv = new Program();
            pv.Increase(out i);
            Console.WriteLine("호출후 값 : {0}", i);
        }
    }
}
