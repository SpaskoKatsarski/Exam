using System;

namespace T04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalLiteres = 0;
            double temperatureSum = 0;

            for (int i = 0; i < days; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double temperature = double.Parse(Console.ReadLine());

                totalLiteres += quantity;
                temperatureSum += quantity * temperature;
            }
            double averageTemperature = temperatureSum / totalLiteres;

            Console.WriteLine($"Liter: {totalLiteres:f2}");
            Console.WriteLine($"Degrees: {averageTemperature:f2}");

            if (averageTemperature < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageTemperature <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
