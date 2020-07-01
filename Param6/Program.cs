using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param6
{
    class Program
    {
        //        C# params 규칙
        //1. params 키워드는 타입 왼쪽에 기입
        //2. 반드시 1차원 배열로 선언
        public int VarMethod(params int[] arr)
        {        // 가변인자
            int sum = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    sum = sum + arr[i];
            //}

            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int result;
            Program vl = new Program();
            result = vl.VarMethod(10, 20);
            Console.WriteLine(result);
            result = vl.VarMethod(1, 2, 3, 4);
            Console.WriteLine(result);
        }
    }
}
