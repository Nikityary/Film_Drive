using System;
using System.Threading;

namespace Film_drive
{
    internal class Car
    {
        public static void dvij()
        {
            double Road = 1000;
            double kmSpeed;
            Random rand = new Random();
            double AllSpeed = 0;
            double sredspeed;
            double time = 0;
            double OstSec;
            double msSpeed;
            for (; Road >= 0; Road -= msSpeed)
            {
                kmSpeed = rand.Next(87, 95);
                AllSpeed += kmSpeed;
                time++;
                sredspeed = AllSpeed / time;
                msSpeed = (kmSpeed / 3.6);
                OstSec = (Road / (sredspeed / 3.6));
                Console.WriteLine("Текущая скорость: " + kmSpeed + " км/ч");
                Console.WriteLine("Средняя скорость: " + Math.Round(sredspeed, 3) + " км/ч");
                Console.WriteLine("Осталось ехать: " + Math.Round(Road, 2) + " м");
                Console.WriteLine("Времени до прибытия: " + Math.Round(OstSec/2, 2) + " c\n");
                try
                {
                    Thread.Sleep(500);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
            if (Road < 27)
            {
                Console.WriteLine("Текущая скорость: 0 км/ч \nОсталось ехать: 0 м \nВремени до прибытия: 0 c");
            }
        }
    }
}
