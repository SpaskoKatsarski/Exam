using System;

namespace T02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kilosOfFood = int.Parse(Console.ReadLine());
            double kilosPerDay1 = double.Parse(Console.ReadLine());
            double kilosPerDay2 = double.Parse(Console.ReadLine());
            double kilosPerDay3 = double.Parse(Console.ReadLine());

            double neededFood1 = days * kilosPerDay1;
            double neededFood2 = days * kilosPerDay2;
            double neededFood3 = days * kilosPerDay3;
            double sum = neededFood1 + neededFood2 + neededFood3;

            if (kilosOfFood >= sum)
            {
                double leftFood = Math.Floor(kilosOfFood - sum);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else
            {
                double neededFood = Math.Ceiling(sum - kilosOfFood);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
