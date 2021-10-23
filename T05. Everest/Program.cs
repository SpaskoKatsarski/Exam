using System;

namespace T05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EVEREST_METERES = 8848;

            string option = Console.ReadLine();

            int currentMeteres = 5364;
            int dayCounter = 1;

            bool hasClimbed = false;

            while (option != "END")
            {
                if (option == "Yes")
                {
                    dayCounter++;
                }
                if (dayCounter > 5)
                {
                    break;
                }
                int climbedMeters = int.Parse(Console.ReadLine());
                currentMeteres += climbedMeters;
                if (currentMeteres >= EVEREST_METERES)
                {
                    hasClimbed = true;
                    break;
                }
                option = Console.ReadLine();
            }
            if (hasClimbed)
            {
                Console.WriteLine($"Goal reached for {dayCounter} days!");
            }
            else
            {
                Console.WriteLine($"Failed!\n{currentMeteres}");
            }
        }
    }
}
