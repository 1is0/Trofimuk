using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    class Dishes : Cupboard
    {
        public Dishes(Sizes variant)
            :base(variant)
        {

        }
        public override void ShowSpecialization()
        {
            Console.WriteLine("Шкафчик для посуды.");
        }
        public override void Output()
        {
            this.ShowSpecialization();
            Passport passport = new Passport(10000, "Это шкаф для посуды.Используйте его для хранения посуды.", "Какая - то там мебельная фабрика.");
            passport.ShowPassport();
            base.Output();
        }
    }
}
