﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic__поликлиника_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oldLadiesInLine;
            int timeOfReceipt = 10;
            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек, посчитайте количество старушек.");
            Console.Write("Введите количество старушек в очереди:");
            oldLadiesInLine = Convert.ToInt32(Console.ReadLine());
            int waitingTime = oldLadiesInLine * timeOfReceipt;
            int minutesInAnHour = 60;
            int hours = waitingTime / minutesInAnHour;
            int minutes = waitingTime % minutesInAnHour;
            Console.WriteLine($"Вы должны отстоять в очереди {hours} часа и {minutes} минут");
        }
    }
}
