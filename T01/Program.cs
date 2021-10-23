using System;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatPercent = int.Parse(Console.ReadLine());
            int proteinPercent = int.Parse(Console.ReadLine());
            int carbohydratesPercent = int.Parse(Console.ReadLine());
            int caloriesSum = int.Parse(Console.ReadLine());
            int waterPercentage = int.Parse(Console.ReadLine());

            double gramsFromFat = (double)fatPercent * caloriesSum / 9;
            double gramsFromProtein = (double)proteinPercent * caloriesSum / 4;
            double gramsFromCarbohydrates = (double)carbohydratesPercent * caloriesSum / 4;

            double foodWeight = gramsFromFat + gramsFromProtein + gramsFromCarbohydrates;
            double caloriesPerGram = (double)caloriesSum / foodWeight;

            double percentage = 100 - waterPercentage;
            double caloriesPerGramWithoutWater = percentage / 100 * caloriesPerGram * 100;

            Console.WriteLine($"{caloriesPerGramWithoutWater:f4}");
        }
    }
}
