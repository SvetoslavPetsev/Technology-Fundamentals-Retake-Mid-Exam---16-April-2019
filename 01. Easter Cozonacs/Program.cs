using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFloor = double.Parse(Console.ReadLine());

            double priceOneLitterMilk = priceFloor * 1.25;
            double packEggs = priceFloor * 0.75;
            double milkForOneCozonac = priceOneLitterMilk / 4;
            double priceForOneCozonac = milkForOneCozonac + packEggs + priceFloor;

            int counterMadeCozunac = 0; ;
            int countColoredEggs = 0;

            while (true)
            {
                if (budget < priceForOneCozonac)
                {
                    break;
                }
                budget -= priceForOneCozonac;
                counterMadeCozunac++;
                if (counterMadeCozunac % 3 == 0)
                {
                    countColoredEggs -= counterMadeCozunac - 2;
                }
                countColoredEggs += 3;
            }
            Console.WriteLine($"You made {counterMadeCozunac} cozonacs! Now you have {countColoredEggs} eggs and {budget:F2}BGN left.");
        }
    }
}
