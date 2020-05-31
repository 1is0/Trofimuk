using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    abstract class Furniture
    {
        public delegate void ViewMessage(string message);
        public event ViewMessage ViewEvent;
        public string[] materials = { "пластик", "дерево", "дерево+пластик" };
        public static int markup = 12;
        private double length;
        public double Length
        {
            set
            {
                if (value <= 0)
                {
                    ViewEvent?.Invoke("Ошибка ввода параметра длины.");
                    throw new ArgumentOutOfRangeException();
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
                    ViewEvent?.Invoke("Ошибка ввода параметра ширины.");
                    throw new ArgumentOutOfRangeException();
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
                    ViewEvent?.Invoke("Ошибка ввода параметра высоты.");
                    throw new ArgumentOutOfRangeException();
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
            ViewEvent?.Invoke($"Площадь:{square} Объём:{size}");
            for (int i=0;i<3 ;i++ )
            {
                ViewEvent?.Invoke(materials[i]);
                ViewEvent?.Invoke($"Цена:{this[i]}");
            }
        }
    }
}
