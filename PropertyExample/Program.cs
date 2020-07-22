using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class PropertyTest
    {
        private string _name;
        private int _readOnly;
        private int _writeOnly;
        private static int _Static;

        public static int Static
        { 
            get { return _Static; }
            set { _Static = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ReadOnly
        {
            get { return _readOnly; }
        }

        public int WriteOnly
        {
            set { _writeOnly = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PropertyTest pt = new PropertyTest();
            pt.Name = "헬로키티";
            Console.WriteLine(pt.Name);
            Console.WriteLine(pt.ReadOnly);
            pt.WriteOnly = 100;

            PropertyTest.Static = 200;
            Console.WriteLine(PropertyTest.Static);
        }
    }
}
