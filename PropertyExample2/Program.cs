using System;
using System.Collections;

namespace PropertyExample2
{
    class TestInt // 6개짜리 인덱서로 작성
    {
        private int[] _array = new int[6];


        public int this[int index]      // 인덱서
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

    }
    class IndexerTest
    {
        private Hashtable myFavorite = new Hashtable();
        private string[] _array = new string[4];

        public string this[int index]
        {
            get { return (string)_array[index]; }
            set { _array[index] = value; }
        }
        public string this[string kind]
        {
            get { return (string)myFavorite[kind]; }
            set { myFavorite[kind] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexerTest it = new IndexerTest();
            it["fruit"] = "apple";
            it["color"] = "blue";

            it[0] = "할룽";

            Console.WriteLine(it["fruit"]);
            Console.WriteLine(it["color"]);
            Console.WriteLine(it[0]);

            TestInt ti = new TestInt();
            for (int i = 0; i < 6; i++)
            {
                ti[i] = i;
                Console.WriteLine(ti[i]);
            }
            
        }
    }
}
