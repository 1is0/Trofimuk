using System;

namespace L3
{    
    class Program
    {
        static void Main(string[] args)
        {
            int wight, legth, heigth;
            Console.WriteLine("Введите ширину объекта:");
            wight=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину объекта:");
            legth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту объекта:");
            heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите наценку(изначальная наценка:12%):");
            Furniture.markup = Convert.ToInt32(Console.ReadLine());
            Furniture furniture = new Furniture(wight, legth, heigth);
            furniture.count(furniture.Wight, furniture.Length);
            furniture.count(furniture.Wight,furniture.Length, furniture.Heigth);
            furniture.output();
        }
    }
}
