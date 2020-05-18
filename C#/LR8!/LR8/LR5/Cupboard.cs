using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    abstract class Cupboard : Furniture, IComparer, IAction
    {
        public delegate void ShowInColor();
        public delegate void Operation();
        public event Operation PlanSomething;
        public delegate void ErorMessage(string message);
        public event ErorMessage ErorEvent;
        public enum Sizes
        {
            Small=1,
            Medium,
            Huge,
            VeryHuge
        }
        public enum Specialization
        {
            Clothes = 1,
            Shoes,
            Dishes
        }
        public Cupboard()
            :base()
        { }
        public Cupboard(Sizes variant)
            :base()
        {
            this.ErorEvent += mes => Console.WriteLine(mes);
            switch(variant)
            {
                case Sizes.Small:
                    this.Wight = 0.5;
                    this.Heigth = 0.5;
                    this.Length = 1;
                    break;
                case Sizes.Medium:
                    this.Wight = 0.5;
                    this.Heigth = 2.5;
                    this.Length = 1.5;
                    break;
                case Sizes.Huge:
                    this.Wight = 1;
                    this.Heigth = 3;
                    this.Length = 3;
                    break;
                case Sizes.VeryHuge:
                    this.Wight = 2;
                    this.Heigth = 3;
                    this.Length = 6;
                    break;
                default:
                    ErorEvent("Ошибка ввода,поэтому был создан шкаф размеров 1-1-1.");
                    this.Wight = 1;
                    this.Heigth = 1;
                    this.Length = 1;
                    break;
            }
        }
        public Cupboard(double n_width, double n_length, double n_height)
            : base(n_width, n_length, n_height)
        { }
        public abstract void ShowSpecialization();
        public struct Passport 
        {
            public delegate void ViewMessage(string message);
            public event ViewMessage ViewEvent;
            int SerialNumber;
            string Instruction;
            string Manufacturer;
            public Passport(int series,string instruction,string manufacturer)
            {
                
                Random rnd = new Random();
                this.SerialNumber = rnd.Next(series, series+9999);
                this.Instruction = instruction;
                this.Manufacturer = manufacturer;
                this.ViewEvent = mes => Console.WriteLine(mes);
            }
            public void ShowPassport()
            {
                ViewEvent?.Invoke($"Серийный номер:{this.SerialNumber}");
                ViewEvent?.Invoke($"Инструкция:{this.Instruction}");
                ViewEvent?.Invoke($"Производитель:{this.Manufacturer}");
            }
        }
        public int Compare(Cupboard anothercupboard)
        {
            if (this.size > anothercupboard.size)
                return 1;
            else if (this.size < anothercupboard.size)
                return -1;
            else return 0;
        }
        public void Up()
        {
            this.Heigth *= 2;
            this.Length *= 2;
            this.Wight *= 2;
            markup=(int)(markup+(markup*0.3));
        }
        public void Down()
        {
            this.Heigth /= 2;
            this.Length /= 2;
            this.Wight /= 2;
            markup = (int)(markup - (markup * 0.3));
        }
        public void DoSomething()
        {
            PlanSomething();
        }
    }
}
