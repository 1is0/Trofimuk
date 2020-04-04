using System;

namespace L2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            string str=Console.ReadLine();
            for (int i=0;i<12 ;i++)
            {                
                Console.WriteLine(date1.ToString("MMMM", new System.Globalization.CultureInfo(str)));
                date1=date1.AddMonths(1);
            }            
        }
    }
}
//de-DE-немецкий
//it-IT-итальянский
//en-US-английский
//es-ES-испанский
//fr-FR-французский




