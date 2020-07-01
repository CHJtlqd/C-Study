using System;

namespace ArrayClone2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Original = { 5, 4, 2, 6, 7, 1 };
            int[] Clone = (int[])Original.Clone();
            
            Console.Write("Original : ");
            foreach (int one in Original)
            {
                Console.Write(one + " ");
            }
            Console.WriteLine();

            Console.Write("Clone : ");
            foreach (int one in Clone)
            {
                Console.Write(one + " ");
            }
            Console.WriteLine();

            Console.WriteLine("**************************");
            Array.Sort(Clone);

            Console.Write("Original : ");
            foreach (int one in Original)
            {
                Console.Write(one + " ");
            }
            Console.WriteLine();

            Console.Write("Clone : ");
            foreach (int one in Clone)
            {
                Console.Write(one + " ");
            }
            Console.WriteLine();


        }
    }
}
