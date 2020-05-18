using System;
using System.Collections.Generic;
using System.Text;

namespace LR5
{
    class Clothes:Cupboard
    {
        public Clothes()
            :base()
        {

        }
        public Clothes(Sizes variant)
            :base(variant)
        {

        }
        public override void ShowSpecialization()
        {
            Console.WriteLine("Шкафчик для одежды.");
        }
        public override void Output()
        {
            this.ShowSpecialization();
            Passport passport = new Passport(10000, "Это шкаф для одежды.Используйте его для хранения одежды.", "Какая - то там мебельная фабрика.");
            passport.ShowPassport();
            base.Output();
        }

    }
}
