using System;
using System.Collections.Generic;
using System.Text;

namespace LR5
{
    class Shoes:Cupboard
    {
        public Shoes(Sizes variant)
            : base(variant)
        {

        }
        public override void ShowSpecialization()
        {
            Console.WriteLine("Шкафчик для обуви.");
        }
        public override void Output()
        {
            this.ShowSpecialization();
            Passport passport = new Passport(10000, "Это шкаф для обуви.Используйте его для хранения обуви.", "Какая - то там мебельная фабрика.");
            passport.ShowPassport();
            base.Output();
        }
    }
}
