using System;

namespace LR7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите два числа,которые будут преобразованы в одно рациольнальное(первое должно быть целым,второе натуральным):");
            Rational a = new Rational(Console.ReadLine());
            a.Show();
            Console.WriteLine("Введите два числа,которые будут преобразованы в одно рациольнальное(первое должно быть целым,второе натуральным):");
            Rational b = new Rational(Console.ReadLine());
            b.Show();
            Rational result = new Rational(1, 1);
            //
            Console.WriteLine("Их сумма:");
            result = a + b;
            result.Show();
            //
            Console.WriteLine("Их разность:");
            result = a - b;
            result.Show();
            //
            Console.WriteLine("Их произведение:");
            result = a * b;
            result.Show();
            //
            Console.WriteLine("Их частное:");
            result = a / b;
            result.Show();
            //
            Random random = new Random();
            int degree= random.Next(0, 10);
            Console.WriteLine($"Возведение в случайную степень от 0 до 10 первого рационального числа({degree}):");
            result = a ^ degree;
            result.Show();
            //
            Console.WriteLine("Приведение к целым и действительным числам второго рационального числа:");
            int intresult =(int)b;
            Console.WriteLine($"Приведение к целым:{intresult}");
            double doublereult =(double)b;
            Console.WriteLine($"Приведение к действительным:{doublereult}");
            //
            Console.WriteLine("Сравнение:");
            if(a>b)
            {
                Console.WriteLine("Первое больше второго.");
            }
            else if(a<b)
            {
                Console.WriteLine("Второе больше первого.");
            }
            else
            {
                Console.WriteLine("Они равны.");
            }
        }
    }
}
