using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Original = { 5, 4, 2, 6, 7, 1 };
            int[] Clone = (int[])Original.Clone();

            foreach (int iNum in Clone)
            {
                Console.WriteLine(iNum);
            }

            Original[3] = 20;
            Console.WriteLine("복제배열[3] : " + Clone[3]);
        }
    }
}
