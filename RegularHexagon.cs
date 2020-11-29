using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_2_
{
    class RegularHexagon
    {

        string rad;
      public  double rad1 { get; set; }
      public double  ploshy1 { get; set; }
        // Конструкор 
        public void radiys()
        {
            Console.WriteLine("Введите радиус вписанной окружности");
            rad = Console.ReadLine();
            rad1 = Convert.ToDouble(rad);
        }
        public void ploshy()
        {
            ploshy1 = 2 * Math.Sqrt(3) * Math.Pow(rad1, 2);
        }
        public void rezzult()
        {
            Console.WriteLine("Площадь правильного шестиугольника=" + ploshy1);
        }
        //Деструктор
        ~RegularHexagon()
        {
            Console.WriteLine("Dispose object...");
        }
    }

}
