using System;

namespace OOP4._1
{
    class sostzdor
    {
        private int temp;
        public int temperatura
        {
            get
            {
                return temp;
            }
            set
            {
                if (value < 34 || value > 41)
                  
                    Console.WriteLine("Вы меня обманываете?");
                
                if (value >= 34 && value <= 36)
                    Console.WriteLine("Вам нужно обратиться к врачу");
                if (value >= 36 && value <= 36.9)
                    Console.WriteLine("У вас всё в порядке");
                if (value > 37 && value <= 37.3)
                    Console.WriteLine("Ничего серьезного");
                if (value >= 37.4 && value <= 40.2)
                    Console.WriteLine("Нужно врачебное вмешательство");
                if (value > 40.3)
                    Console.WriteLine("Угрожающая жизни температура тела");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу температуту тела");
            int chislo = Convert.ToInt32(Console.ReadLine());
            sostzdor sostzd = new sostzdor();
            sostzd.temperatura = chislo;
            Console.ReadLine();
        }
    }
}
