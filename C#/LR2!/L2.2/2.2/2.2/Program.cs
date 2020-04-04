using System;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i;
            string command = null;
            for (i = 0; String.Compare(command, "Выход") != 0; i++)
            {
                Console.WriteLine("Введите Выход,чтобы остановится.");
                command = Console.ReadLine();
                int strsize = random.Next(1, 5);
                string str = null;
                for (i = 0; i < strsize; i++)
                {                    
                    str += Convert.ToString((char)random.Next(97, 122));
                }
                Console.WriteLine(str);
            }

        }
    }
}