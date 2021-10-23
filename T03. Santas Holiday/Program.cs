using System;

namespace T03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();

            int nights = days - 1;
            double sum = 0;

            if (room == "room for one person")
            {
                sum = 18.00 * nights;
            }
            else if (room == "apartment")
            {
                sum = 25.00 * nights;
                if (days < 10)
                {
                    sum *= 0.70;
                }
                else if (days <= 15)
                {
                    sum *= 0.65;
                }
                else
                {
                    sum *= 0.50;
                }
            }
            else
            {
                sum = 35.00 * nights;
                if (days < 10)
                {
                    sum *= 0.90;
                }
                else if (days <= 15)
                {
                    sum *= 0.85;
                }
                else
                {
                    sum *= 0.80;
                }
            }
            if (opinion == "positive")
            {
                sum *= 1.25;
            }
            else
            {
                sum *= 0.90;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
