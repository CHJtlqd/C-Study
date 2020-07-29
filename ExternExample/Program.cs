using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExternExample
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern int MessageBeep(uint uType);
        static void Main(string[] args)
        {
            MessageBeep(0);
        }
    }
}
