using System;
using System.Runtime.InteropServices;

namespace L4._2
{
    class Program
    {
        [DllImport("NDLL.dll")]
        public static extern void use();
        [DllImport("NDLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void anotheruse();
        static void Main(string[] args)
        {
            use();
            anotheruse();
        }
    }
}
