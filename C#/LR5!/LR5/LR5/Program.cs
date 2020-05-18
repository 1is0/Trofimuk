using System;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {

            int variant=0, specialization=0;
            bool check;
            Cupboard cupboard=new Clothes();
            for(; specialization != 1 && specialization != 2 && specialization!=3; )
            {
                Console.WriteLine("Введите специализацию шкафа:");
                Console.WriteLine("1-для одежды");
                Console.WriteLine("2-для обуви");
                Console.WriteLine("3-для посуды");
                check = int.TryParse(Console.ReadLine(),out specialization);
                
            }
            for(; variant!=1 && variant !=2 && variant !=3 && variant !=4; )
            {
                Console.WriteLine("Введите шаблон размерности(длина-ширина-высота):");
                Console.WriteLine("1-малый:1-0.5-0.5");
                Console.WriteLine("2-средний:1.5-0.5-2.5");
                Console.WriteLine("3-большой:3-1-3");
                Console.WriteLine("4-очень большой:6-2-3");
                check = int.TryParse(Console.ReadLine(), out variant);                
            }
            switch((Cupboard.Specialization)specialization)
            {
                case Cupboard.Specialization.Clothes:
                    cupboard = new Clothes((Cupboard.Sizes)variant);
                    break;
                case Cupboard.Specialization.Dishes:
                    cupboard = new Dishes((Cupboard.Sizes)variant);
                    break;
                case Cupboard.Specialization.Shoes:
                    cupboard = new Shoes((Cupboard.Sizes)variant);
                    break;
            }
            cupboard.Count(cupboard.Wight,cupboard.Length);
            cupboard.Count(cupboard.Wight,cupboard.Length,cupboard.Heigth);
            cupboard.Output();
        }
    }
}
