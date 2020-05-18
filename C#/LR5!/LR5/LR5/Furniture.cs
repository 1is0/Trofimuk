using System;
using System.Collections.Generic;
using System.Text;

namespace LR5
{
    abstract class Furniture
    {
        public string[] materials = { "пластик", "дерево", "дерево+пластик" };
        public static int markup = 12;
        private double length;
        public double Length
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                else
                {
                    length = value;
                }
            }
            get
            {
                return length;
            }
        }
        private double width;
        public double Wight
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                else
                {
                    width = value;
                }
            }
            get
            {
                return width;
            }
        }
        private double heigth;
        public double Heigth
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                else
                {
                    heigth = value;
                }
            }
            get
            {
                return heigth;
            }
        }
        public double square;
        public double size;
        double[] totalcost;
        public double this[int index]
        {
            get
            {
                return totalcost[index];
            }
        }
        public Furniture()
        {
            heigth = 1;
            square = 1;
            width = 1;
        }
        public Furniture(double n_width, double n_length, double n_height)
        {
            this.Wight = n_width;
            this.Length = n_length;
            this.Heigth = n_height;
        }
        public void Count(double n_width, double n_length)
        {
            square = n_width * n_length;
        }
        public void Count(double n_width, double n_length, double n_height)
        {
            size = n_width * n_length * n_height;
            totalcost = new double[3];
            totalcost[0] = (size * 1.5) + (size * 1.5 * markup/100);
            totalcost[1] = (size * 3) + (size * 3 * markup/100);
            totalcost[2] = (size * 2) + (size * 2 * markup/100);
        }
        public virtual void Output()
        {            
            Console.WriteLine($"Площадь:{square} Объём:{size}");
            for (int i=0;i<3 ;i++ )
            {
                Console.WriteLine(materials[i]);
                Console.WriteLine($"Цена:{this[i]}");
            }
        }
    }
}
