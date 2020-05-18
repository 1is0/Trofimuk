using System;
using System.Collections.Generic;
using System.Text;

namespace LR5
{
    abstract class Cupboard: Furniture
    {
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
            }
        }
        public Cupboard(double n_width, double n_length, double n_height)
            : base(n_width, n_length, n_height)
        { }
        public abstract void ShowSpecialization();
        public struct Passport 
        {
            int SerialNumber;
            string Instruction;
            string Manufacturer;
            public Passport(int series,string instruction,string manufacturer)
            {
                Random rnd = new Random();
                this.SerialNumber = rnd.Next(series, series+9999);
                this.Instruction = instruction;
                this.Manufacturer = manufacturer;
            }
            public void ShowPassport()
            {                
                Console.WriteLine($"Серийный номер:{this.SerialNumber}");
                Console.WriteLine($"Инструкция:{this.Instruction}");
                Console.WriteLine($"Производитель:{this.Manufacturer}");
            }
        }
    }
}
