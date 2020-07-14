using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 144, 123, 232, 111, 145 };
            int index = System.Array.IndexOf(Array, 232);
            Console.WriteLine(index);


            for (int i = 0; i < Array.Length; i++) {
                if (Array[i] == 232) {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }
}
