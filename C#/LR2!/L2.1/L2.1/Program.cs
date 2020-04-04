using System;

namespace L2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count;
            string dop;
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] {' '});
            count=words.GetLength(0);
            for(i=0;i<count/2 ;i++ )
            {
                dop=words[i];
                words[i] = words[count-1 - i];
                words[count-1 - i] = dop;
            }
            str = null;
            for(i=0;i<count ;i++ )
            {
                str += words[i] + " ";
            }
            Console.WriteLine(str);
        }
    }
}
